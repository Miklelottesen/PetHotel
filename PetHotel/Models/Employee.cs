using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetHotel.Models
{
    public class Employee : Person
    {
        public string Initials { get; set; };
        public List<Reservation> Reservations { get; set; };

        public Employee (int PersonID, string Firstname, string Lastname, string Initials, string Phone)
        {
            this.PersonID = PersonID;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Initials = Initials;
            this.Phone = Phone;
        }
    }
}