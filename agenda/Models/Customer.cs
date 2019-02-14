using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace agenda.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
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
        [Phone]
        public string PhoneNumber { get; set; }
        public double Budget { get; set; }
        public string Subject { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}