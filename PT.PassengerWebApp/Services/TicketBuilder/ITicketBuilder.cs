using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PT.PassengerWebApp.Services.TicketBuilder
{
    public interface ITicketBuilder
    {
        string ResetBuilder();
        string AddDestinationLetters();
        string AddGenderLetters();
        string AddMealLetters();
        string AddFlightClassLetters();
        string AddNativeCountryLetters();
    }
}