using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetHotel.Models
{
    public class Person
    {
        public int PersonID { get; set; };
        public string Firstname { get; set; };
        public string Lastname { get; set; };
        public string Phone { get; set; };
    }
}