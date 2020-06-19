using SkiingJumps.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SkiingJumps.Controllers
{
    public class InsertDataController : ApiController
    {
        public IHttpActionResult InsertRecords(InsertData insertData)
        {
            Entities db = new Entities();
            db.InsertDataResults(insertData.JumperName,
                                    insertData.JumperSurname,
                                    insertData.JumperCountry,
                                    insertData.Meters,
                                    insertData.Points,
                                    insertData.HillName,
                                    insertData.Height,
                                    insertData.City,
                                    insertData.HillCountry,
                                    0, 0, 0, 0, 0);
            db.SaveChanges();
            return Ok();
        }
    }
}
