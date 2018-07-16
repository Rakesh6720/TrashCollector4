using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector4.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int ZipCode { get; set; }
        public string PickupDay { get; set; }

    }
}