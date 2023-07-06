using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PT.PassengerWebApp.Data.Models
{
    [Table("Ticket")]
    public class Ticket
    {
        public int TicketID { get; set; }
        public int PassengerID { get; set; }
        public string PassengerCode { get; set; }
        public DateTime Created { get; set; }

        //UK 
        //uk(10pm to 6AM)
        //X


    }
}