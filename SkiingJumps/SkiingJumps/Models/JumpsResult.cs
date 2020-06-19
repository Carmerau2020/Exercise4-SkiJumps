using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SkiingJumps.Models
{
    public class JumpsResult
    {
        public Countries GetJumpersCountries { get; set; }
        public Countries GetHillsCountries { get; set; }
        public ski_jumpers GetJumpers { get; set; }
        public Cities GetCities { get; set; }
        public ski_jumping_hills GetHills { get; set; }
        public ski_jumps GetJumps { get; set; }
    }
}