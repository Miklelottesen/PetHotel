using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetHotel.Models
{
    public class Reservation
    {
        public int ReservationID
        {
            get;
        }

        public String PetName
        {
            get; set;
        }

        public DateTime Birthday
        {
            get; set;
        }

        public String Specie
        {
            get; set;
        }

        public DateTime StartDate
        {
            get; set;
        }

        public DateTime EndDate
        {
            get; set;
        }

        public Customer Customer
        {
            get;
        }

        public String Employee
        {
            get; set;
        }

        public Reservation(int ReservationID, String PetName, String Specie, DateTime StartDate, DateTime EndDate, Customer Customer)
        {
            this.ReservationID = ReservationID;
            this.PetName = PetName;
            this.Specie = Specie;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Customer = Customer;
        }

    }
}