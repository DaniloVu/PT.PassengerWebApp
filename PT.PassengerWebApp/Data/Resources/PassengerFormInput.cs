using PT.PassengerWebApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PT.PassengerWebApp.Data.Resources
{
    public class PassengerFormInput
    {
        public string Destination { get; set; }
        public DateTime DepartureTime { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public FlightMeal Meal { get; set; }
        public bool ChildMealPicked { get; set; }
        public FlightClass FlightClass { get; set; }
        public int NativeCountryID { get; set; }

    }
}