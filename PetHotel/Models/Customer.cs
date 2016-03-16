using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetHotel.Models
{
    public class Customer : Person
    {
        public string Address
        {
            get; set;
        }
        public string Zipcode
        {
            get; set;
        }
        public string City
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }

        public Customer(int PersonID, String FirstName, String LastName, String Address, String Zipcode, String City, String Email, String Phone)
        {
            this.PersonID = PersonID;
            this.Firstname = FirstName;
            this.Lastname = LastName;
            this.Address = Address;
            this.Zipcode = Zipcode;
            this.City = City;
            this.Email = Email;
            this.Phone = Phone;
        }
    }
}