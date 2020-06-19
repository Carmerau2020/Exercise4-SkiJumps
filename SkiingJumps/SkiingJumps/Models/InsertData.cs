using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkiingJumps.Models
{
    public class InsertData
    {
        public string JumperName { get; set; }
        public string JumperSurname { get; set; }
        public string JumperCountry { get; set; }
        public float Meters { get; set; }
        public float Points { get; set; }
        public string HillName { get; set; }
        public int Height { get; set; }
        public string City { get; set; }
        public string HillCountry { get; set; }
    }
}