using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetHotel.Models
{
    public class Employee
    {
        public string Initials { get; set; };
        public List<Reservation> Reservations { get; set; };
    }
}