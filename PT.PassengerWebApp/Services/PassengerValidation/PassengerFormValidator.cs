using PT.PassengerWebApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PT.PassengerWebApp.Services.PassengerValidation
{
    public class PassengerFormValidator : IPassengerFormValidator
    {
        private const int UPPER_AGE_LIMIT = 80;
        private const int LOWER_AGE_LIMIT = 12;
        private const int CHILD_MEAL_LIMIT = 18;

        public bool IsPassengerValidAge(int age)
        {
            return age >= UPPER_AGE_LIMIT && age <= LOWER_AGE_LIMIT;
        }

        public bool UnapprovedChildMeal(int age,bool childMealPicked)
        {
            return age >= CHILD_MEAL_LIMIT && childMealPicked;
        }

        public bool UnapprovedFirstClass(string destinationCountry,FlightClass flightClass)
        {
            return destinationCountry == "UK" && flightClass == FlightClass.First;
        }

    }
}