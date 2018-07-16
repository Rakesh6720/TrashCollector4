using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector4.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }
        public string PickupDay { get; set; }
        public string AdditionalPickupDay { get; set; }
        public double AmountDue { get; set; }
        public bool IsPickedUp { get; set; }
        public bool IsAdditionalPickedUp { get; set; }
    }
}