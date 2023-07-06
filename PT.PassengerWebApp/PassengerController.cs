using Microsoft.AspNetCore.Mvc;
using PT.PassengerWebApp.Data.Resources;
using PT.PassengerWebApp.Services.PassengerValidation;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace PT.PassengerWebApp
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        private readonly IPassengerFormValidator _passengerFormValidator;

        public PassengerController(IPassengerFormValidator passengerFormValidator)
        {
            this._passengerFormValidator = passengerFormValidator;
        }
        //GET: api/passenger/all
        [HttpGet, Route("all")]
        public async Task<ActionResult> GetPassengersAsync()
        {
          return Ok();
        }

        // POST api/passenger/createTicket
        public async Task<ActionResult> BoardPassengerAsync([FromBody] PassengerFormInput passengerInput)
        {
            if (_passengerFormValidator.IsPassengerValidAge(passengerInput.Age))
                return BadRequest("Your age is not suitable for this flight");

            if (_passengerFormValidator.UnapprovedChildMeal(passengerInput.Age, passengerInput.ChildMealPicked))
                return BadRequest("You cannot pick child meal with provided age");

            if (_passengerFormValidator.UnapprovedFirstClass(passengerInput.Destination, passengerInput.FlightClass))
                return BadRequest("There is no first class for selected destination");



        }

    }
}