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

namespace PicoYPlacaService
{
    public static class PicoYPlacaPredictor
    {
        [FunctionName("PicoYPlacaPredictor")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            //1. Get the parameters from the request
            //license plate number (the full number, not the last digit), a date (as a String), and a time
            string licensePlate = req.Query["licensePlate"];
            string date = req.Query["date"];
            string time = req.Query["time"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            //name = name ?? data?.name;

            //2. Load the rules from data
            var picoYPlacaRules = await PicoYPlacaDA.GetAllPicoYPlacaRules();
            int count = picoYPlacaRules.Count;
            //3. Query the parametres into the data

            
            //4. Instace the response object
            string responseMessage = string.IsNullOrEmpty(licensePlate)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {licensePlate}. This HTTP triggered function executed successfully.";

            return new OkObjectResult(responseMessage);
        }
    }
}
