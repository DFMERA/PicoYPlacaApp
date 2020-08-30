using System;
using Xunit;
using PicoYPlacaService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PicoYPlacaUtil.Models;
using System.Text.Json;
using Newtonsoft.Json;

namespace PicoYPlacaServices.Test
{
    public class UnitTest1
    {
        private readonly ILogger logger = TestFactory.CreateLogger();

        [Fact]
        public async void Digits1and2CanNotRoadMondaysMorning()
        {
            PicoYPlacaInput picoYPlacaInput = new PicoYPlacaInput()
            {
                LicensePlate = "ABC-123",
                Date = new DateTime(2020, 09, 1),
                Time = "08:00"
            };
            var request = TestFactory.CreateHttpRequest("Data", JsonConvert.SerializeObject(picoYPlacaInput));
            var response = (OkObjectResult)await PicoYPlacaPredictor.Run(request, logger);
            Assert.Equal("Hello, Bill. This HTTP triggered function executed successfully.", response.Value);

        }

        [Fact]
        public void Digits3and4CanNotRoadTuesdaysMorning()
        {

        }

        [Fact]
        public void Digits5and6CanNotRoadWednesdaysMorning()
        {

        }

        [Fact]
        public void Digits7and8CanNotRoadThursdaysMorning()
        {

        }

        [Fact]
        public void Digits9and10CanNotRoadWednesdaysMorning()
        {

        }
    }
}
