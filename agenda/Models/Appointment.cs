using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace agenda.Models
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        [Required]
        public DateTime DateHour { get; set; }
        public int BrokerID { get; set; }
        public int CustomerID { get; set; }
        public virtual Broker Brokers { get; set; }
        public virtual Customer Customers { get; set; }
    }
}