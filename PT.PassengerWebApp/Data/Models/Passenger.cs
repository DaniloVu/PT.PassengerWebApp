using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PT.PassengerWebApp.Data.Models
{
    [Table("Passenger")]  //schema if applicable
    public class Passenger
    {
        public int PassengerID { get; set; }
        public Guid PassengerGuid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
    }
}