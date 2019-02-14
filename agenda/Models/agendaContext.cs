using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace agenda.Models
{
    public class agendaContext : DbContext
    {
        public agendaContext() : base("agendaContext")
        {
            
        }
        public DbSet<Broker> Brokers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}