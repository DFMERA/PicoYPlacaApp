using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PicoYPlacaService.Model;

namespace PicoYPlacaService.DataAccess
{
    public static class PicoYPlacaDA
    {
        public static async Task<List<PicoYPlacaRule>> GetAllPicoYPlacaRules()
        {
            string jsonString = await File.ReadAllTextAsync("JsonData.json");
            List<PicoYPlacaRule> picoYPlacaRules = JsonSerializer.Deserialize<List<PicoYPlacaRule>>(jsonString);

            return picoYPlacaRules;
        }
    }
}
