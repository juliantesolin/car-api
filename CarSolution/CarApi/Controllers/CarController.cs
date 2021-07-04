using CarLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Controllers
{
    [ApiController]
    [Route("api/car")]
    public class CarController : ControllerBase
    {

        private readonly ILogger<CarController> _logger;

        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Welcome to the car
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public string Car()
        {
            return "Welcome!";
        }

        /// <summary>
        /// Moves the car forward
        /// </summary>
        /// <param name="meters">Decimal, Number of meters</param>
        /// <returns></returns>
        [Route("MoveForward/{meters}")]
        [HttpGet]
        public string MoveForward(decimal meters)
        {
            string result = String.Empty;

            try
            {
                Car car = new Car(new V8());

                result = car.MoveForward(meters);

            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return result;
        }

        /// <summary>
        /// Moves the car backwards
        /// </summary>
        /// <param name="meters">Decimal, Number of meters</param>
        /// <returns></returns>
        [Route("MoveBackwards/{meters}")]
        [HttpGet]
        public string MoveBackwards(decimal meters)
        {
            string result = String.Empty;

            try
            {
                Car car = new Car(new V8());

                result = car.MoveBackwards(meters);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
            }

            return result;
        }
    }
}
