using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PetHotel.Models
{
    public class Repository
    {

        private Dictionary<String, int> prices = new Dictionary<string, int>();
        public Dictionary<String, int> Prices
        {
            get
            {
                return prices;
            }
        }

        private List<Reservation> reservations = new List<Reservation>();
        public List<Reservation> Reservations
        {
            get
            {
                return reservations;
            }
        } 

        public Repository()
        {
            prices.Add("Dog", 180);
            prices.Add("Cat", 140);
            prices.Add("Snake", 120);
            prices.Add("Guinea Pig", 75);
            prices.Add("Canary", 60);

            Customer c1 = new Customer(1, "Susan", "Peterson", "Borgergade 45", "8000", "Aarhus", "supe@xmail.dk", "21212121");
            Customer c2 = new Customer(2, "Brian", "Smith", "Algade 108", "8000", "Aarhus", "brsm@xmail.dk", "45454545");

            Reservation r1 = new Reservation(1, "Dog", "Hamlet", new DateTime(2014, 9, 2), new DateTime(2014, 9, 20), c1);
            Reservation r2 = new Reservation(2, "Dog", "Samson", new DateTime(2014, 9, 14), new DateTime(2014, 9, 21), c1);
            Reservation r3 = new Reservation(3, "Cat", "Darla", new DateTime(2014, 9, 7), new DateTime(2014, 9, 10), c2);

            reservations.Add(r1);
            reservations.Add(r2);
            reservations.Add(r3);

            
        }
    }
}