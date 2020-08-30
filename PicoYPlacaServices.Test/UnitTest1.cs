using System;
using Xunit;
using PicoYPlacaService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PicoYPlacaUtil.Models;
using System.Text.Json;

namespace PicoYPlacaServices.Test
{
    public class UnitTest1
    {
        private readonly ILogger logger = TestFactory.CreateLogger();

        [Fact]
        public async void Digit1CanNotRoadMondaysMorning()
        {
            PicoYPlacaInput picoYPlacaInput = new PicoYPlacaInput()
            {
                LicensePlate = "ABC-121",
                Date = "31/08/2020",
                Time = "08:00"
            };
            var request = TestFactory.CreateHttpRequest("Body", JsonSerializer.Serialize(picoYPlacaInput));
            var response = (OkObjectResult)await PicoYPlacaPredictor.Run(request, logger);
            Assert.Equal("{\"Code\":3,\"Message\":\"Your car can not road at all\"}", response.Value);

        }

        [Fact]
        public async void Digit3CanNotRoadTuesdaysMorning()
        {
            PicoYPlacaInput picoYPlacaInput = new PicoYPlacaInput()
            {
                LicensePlate = "ABC-123",
                Date = "01/09/2020",
                Time = "08:00"
            };
            var request = TestFactory.CreateHttpRequest("Body", JsonSerializer.Serialize(picoYPlacaInput));
            var response = (OkObjectResult)await PicoYPlacaPredictor.Run(request, logger);
            Assert.Equal("{\"Code\":3,\"Message\":\"Your car can not road at all\"}", response.Value);

        }

        [Fact]
        public async void Digit5CanNotRoadWednesdaysMorning()
        {
            PicoYPlacaInput picoYPlacaInput = new PicoYPlacaInput()
            {
                LicensePlate = "ABC-125",
                Date = "02/09/2020",
                Time = "08:00"
            };
            var request = TestFactory.CreateHttpRequest("Body", JsonSerializer.Serialize(picoYPlacaInput));
            var response = (OkObjectResult)await PicoYPlacaPredictor.Run(request, logger);
            Assert.Equal("{\"Code\":3,\"Message\":\"Your car can not road at all\"}", response.Value);

        }

        [Fact]
        public async void Digit7CanNotRoadThursdaysMorning()
        {
            PicoYPlacaInput picoYPlacaInput = new PicoYPlacaInput()
            {
                LicensePlate = "ABC-127",
                Date = "03/09/2020",
                Time = "08:00"
            };
            var request = TestFactory.CreateHttpRequest("Body", JsonSerializer.Serialize(picoYPlacaInput));
            var response = (OkObjectResult)await PicoYPlacaPredictor.Run(request, logger);
            Assert.Equal("{\"Code\":3,\"Message\":\"Your car can not road at all\"}", response.Value);
        }

        [Fact]
        public async void Digit9CanNotRoadWednesdaysMorning()
        {
            PicoYPlacaInput picoYPlacaInput = new PicoYPlacaInput()
            {
                LicensePlate = "ABC-129",
                Date = "04/09/2020",
                Time = "08:00"
            };
            var request = TestFactory.CreateHttpRequest("Body", JsonSerializer.Serialize(picoYPlacaInput));
            var response = (OkObjectResult)await PicoYPlacaPredictor.Run(request, logger);
            Assert.Equal("{\"Code\":3,\"Message\":\"Your car can not road at all\"}", response.Value);
        }

        [Fact]
        public async void Digit1CanRoadMondaysNoon()
        {
            PicoYPlacaInput picoYPlacaInput = new PicoYPlacaInput()
            {
                LicensePlate = "ABC-121",
                Date = "31/08/2020",
                Time = "12:00"
            };
            var request = TestFactory.CreateHttpRequest("Body", JsonSerializer.Serialize(picoYPlacaInput));
            var response = (OkObjectResult)await PicoYPlacaPredictor.Run(request, logger);
            Assert.Equal("{\"Code\":2,\"Message\":\"Your car can not road this day but it can road on this hour\"}", response.Value);

            //{"Code":1,"Message":"Your car can road all day"}
        }

        [Fact]
        public async void Digit1CanRoadTuesday()
        {
            PicoYPlacaInput picoYPlacaInput = new PicoYPlacaInput()
            {
                LicensePlate = "ABC-121",
                Date = "02/09/2020",
                Time = "12:00"
            };
            var request = TestFactory.CreateHttpRequest("Body", JsonSerializer.Serialize(picoYPlacaInput));
            var response = (OkObjectResult)await PicoYPlacaPredictor.Run(request, logger);
            Assert.Equal("{\"Code\":1,\"Message\":\"Your car can road all day\"}", response.Value);

        }
    }
}
