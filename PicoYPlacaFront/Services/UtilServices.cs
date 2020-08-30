using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using PicoYPlacaUtil.Models;

namespace PicoYPlacaFront.Services
{
    public static class UtilServices
    {
        public static async Task<ResponseObj> PostPicoYPlacaService(PicoYPlacaInput picoYPlacaInput, string urlString)
        {
            try
            {
                HttpClient myClient = new HttpClient();

                //string urlString = Environment.GetEnvironmentVariable("AzureFunctionsUrl");

                Uri uriString = new Uri(urlString);
                var jsonBody = JsonSerializer.Serialize(picoYPlacaInput);
                var resp = await myClient.PostAsync(uriString, new StringContent(jsonBody, Encoding.UTF8, "application/json")); ;

                var value = resp.Content.ReadAsStringAsync().Result;

                return JsonSerializer.Deserialize<ResponseObj>(value);
            }
            catch (Exception ex)
            {
                return new ResponseObj(-200, ex.Message);
            }
        }
    }
}
