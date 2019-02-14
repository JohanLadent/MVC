using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace agenda.Models
{
    public class Broker
    {
        public int BrokerID { get; set; }
        [MaxLength(50), Required]
        [Display(Name = "Nom :")]
        public string LastName { get; set; }
        [MaxLength(50), Required]
        [Display(Name = "Prénom :")]
        public string FirstName { get; set; }
        [MaxLength(100), Required]
        [Display(Name = "Mail :")]
        public string Mail { get; set; }
        [MaxLength(10), Required]
        [Display(Name = "Numéro de telephone :")]
        public string PhoneNumber { get; set; }
        public virtual ICollection <Appointment>Appointments { get; set; }
    }
}