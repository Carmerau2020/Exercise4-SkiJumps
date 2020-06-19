using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SkiingJumps.Models;

namespace SkiingJumps.Controllers
{
    public class SkiJumpResultController : ApiController
    {
        public IHttpActionResult GetActionResult()
        {
            Entities db = new Entities();
            List<Countries> countries_list = db.Countries.ToList();
            List<Cities> cities_list = db.Cities.ToList();
            List<ski_jumpers> jumpers_list = db.ski_jumpers.ToList();
            List<ski_jumping_hills> hills_list = db.ski_jumping_hills.ToList();
            List<ski_jumps> jumps_list = db.ski_jumps.ToList();

            var query = from jump in jumps_list
                        join jumper in jumpers_list on jump.JumperID equals jumper.JumperID into TR1
                        from jumper in TR1.DefaultIfEmpty()
                        join hill in hills_list on jump.JumpinhHillID equals hill.JumpingHillID into TR2
                        from hill in TR2.DefaultIfEmpty()
                        join ci in cities_list on hill.CityID equals ci.CityID into TR3
                        from ci in TR3.DefaultIfEmpty()
                        join c in countries_list on jumper.CountryID equals c.CountryID into TR4
                        from c in TR4.DefaultIfEmpty()
                        join co in countries_list on hill.CountryID equals co.CountryID into TR5
                        from co in TR5.DefaultIfEmpty()

                        select new JumpsResult
                        {
                            GetJumpersCountries = c,
                            GetHillsCountries = co,
                            GetCities = ci,
                            GetJumpers = jumper,
                            GetJumps = jump,
                            GetHills = hill
                        };

            return Ok(query);
        }
    }
}
