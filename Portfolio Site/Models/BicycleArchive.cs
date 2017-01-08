using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio_Site.Models
{
    public class BicycleArchive
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public int Year { get; set; }
        public int Rating { get; set; }
        public string Info { get; set; }

    }
}