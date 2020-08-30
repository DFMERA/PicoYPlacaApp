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
       
        [BindProperty(SupportsGet = true)]
        public PicoYPlacaInput PicoYPlacaInputs { get; set; }
        public ResponseObj PicoYPlacaPrediction { get; set; }

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void OnGet()
        {
            PicoYPlacaInputs = new PicoYPlacaInput()
            {
                LicensePlate = "ABC-123",
                Date = "01/09/2020",
                Time = "00:00"
            };

            PicoYPlacaPrediction = new ResponseObj(0, "Enter the Values");
        }

        public async Task OnPostAsync()
        {
            string urlString = _configuration.GetSection("AzureFunctionsUrl").Value;
            PicoYPlacaPrediction = await Services.UtilServices.PostPicoYPlacaService(PicoYPlacaInputs, urlString);

            if(PicoYPlacaPrediction.Code <0)
            {
                //TODO: redirect to an error page
            }
        }
    }
}
