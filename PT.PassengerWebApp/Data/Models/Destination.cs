using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PT.PassengerWebApp.Data.Models
{
    [Table("Destination")]
    public class Destination
    {
        public int DestinationID { get; set; }
        public string Name { get; set; }
        public char CountryLetter { get; set; }
    }
}