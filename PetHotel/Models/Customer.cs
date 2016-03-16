using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetHotel.Models
{
    public class Customer
    {
        public string Address
        {
            get; set;
        };
        public string Zipcode
        {
            get; set;
        };
        public string City
        {
            get; set;
        };
        public string Email
        {
            get; set;
        };
    }
}