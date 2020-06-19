using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using SkiingJumps.Models;


namespace SkiingJumps.Controllers
{
    public class InsertRecordController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(InsertData inD)
        {
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44360/api/InsertData");

            var insertRec = hc.PostAsJsonAsync<InsertData>("InsertData", inD);
            insertRec.Wait();
            ViewBag.message = "Values insert successfully";

            return View();
        }
    }
}