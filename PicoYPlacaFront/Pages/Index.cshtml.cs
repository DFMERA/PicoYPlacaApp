using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using PicoYPlacaUtil.Models;

namespace PicoYPlacaFront.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration _configuration;

        public PicoYPlacaInput picoYplacaInput;
        public ResponseObj picoYPlacaPrediction;
        
        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void OnGet()
        {
            picoYplacaInput = new PicoYPlacaInput()
            {
                LicensePlate = "ABC-123",
                Date = DateTime.Now,
                Time = "00:00"
            };
        }

        public async Task OnPostAsync()
        {
            string urlString = _configuration.GetSection("AzureFunctionsUrl").Value;
            picoYPlacaPrediction = await Services.UtilServices.PostPicoYPlacaService(picoYplacaInput, urlString);

            if(picoYPlacaPrediction.Code <0)
            {
                //TODO: redirect to an error page
            }
        }
    }
}
