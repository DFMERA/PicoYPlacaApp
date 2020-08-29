using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PicoYPlacaService.Model;
using PicoYPlacaService.DataAccess;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using PicoYPlacaUtil.Models;

namespace PicoYPlacaService
{
    public static class PicoYPlacaPredictor
    {
        [FunctionName("PicoYPlacaPredictor")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            ResponseObj responseObj;
            log.LogInformation("C# HTTP trigger function processed a request.");

            try
            {

                //1. Get the parameters from the request
                //license plate number (the full number, not the last digit), a date (as a String), and a time
                string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
                dynamic data = JsonConvert.DeserializeObject(requestBody);
                string licensePlate = data?.licensePlate;
                string date = data?.date;
                string time = data?.time;

                //name = name ?? data?.name;

                //2. Load the rules from data
                var picoYPlacaRules = await PicoYPlacaDA.GetAllPicoYPlacaRules();
                int count = picoYPlacaRules.Count;

                //3. Query the first rule into the data
                var dayRules = picoYPlacaRules.Select(x => x).Where(x => x.Digit == Convert.ToInt32(licensePlate.Last().ToString()))
                                .Where(x => x.DayOfWeek == DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.CurrentCulture).DayOfWeek.ToString())
                                .ToList();

                //4 validate the rule & Instace the response object
                if (dayRules.Count > 0)
                {
                    var hourRules = dayRules.Select(x => x).Where(x => x.Hour == Convert.ToInt32(time.Split(':')[0]))
                                .Where(x => x.MinutesStart <= Convert.ToInt32(time.Split(':')[1]) && x.MinutesEnd >= Convert.ToInt32(time.Split(':')[1]))
                                .ToList();

                    if (hourRules.Count > 0)
                    {
                        //Your car can not road at all
                        responseObj = new ResponseObj(3, "Your car can not road at all");
                    }
                    else
                    {
                        //Your car can not road this day but it can road on this hour
                        responseObj = new ResponseObj(2, "Your car can not road this day but it can road on this hour");
                    }
                }
                else
                {
                    //your car can road all day
                    responseObj = new ResponseObj(1, "Your car can road all day");
                }

                log.LogInformation("C# HTTP trigger function ended. Code: " + responseObj.Code.ToString());
            }
            catch (Exception ex)
            {
                log.LogError(ex, ex.Message + '\n' + ex.StackTrace);
                responseObj = new ResponseObj(-100, ex.Message);
            }
            return new OkObjectResult(responseObj);
        }

    }
    /*public class ResponseObj
    {
        public ResponseObj(int code, string message)
        {
            Code = code;
            Message = message;
        }
        public int Code { get; set; }
        public string Message { get; set; }
    }*/
}
