using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PT.PassengerWebApp.Services.TicketBuilder
{
    public class TicketBuilder : ITicketBuilder
    {
        
        private string _ticket;
        private int LOWER_DATE_LIMIT = 22;
        private int UPPER_HOUR_LIMIT = 6;
        public string AddDestinationLetters(char countryLetter,DateTime departureTime)
        {
            if (_ticket is null)
                _ticket = "";
            if(IsWithinLimit(departureTime))
                return $"{_ticket}{Char.ToLower(countryLetter)}";

            return $"{_ticket}{Char.ToUpper(countryLetter)}";
        }

        public string AddFlightClassLetters()
        {
            throw new NotImplementedException();
        }

        public string AddGenderLetters()
        {
            throw new NotImplementedException();
        }

        public string AddMealLetters()
        {
            throw new NotImplementedException();
        }

        public string AddNativeCountryLetters()
        {
            throw new NotImplementedException();
        }

        public void ResetBuilder()
        {
            _ticket = string.Empty;
        }
        private bool IsWithinLimit(DateTime departureTime)
        {
            throw new NotImplementedException();
        }
    }
}