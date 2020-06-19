using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using SkiingJumps.Models;

namespace SkiingJumps.Controllers
{
    public class SkiJumpsResultTablesController : Controller
    {
        
        // GET: SkiJumpsResultTables
        public ActionResult Index()
        {
            IEnumerable<JumpsResult> jr = null;
            HttpClient hc = new HttpClient();
            hc.BaseAddress = new Uri("https://localhost:44360/api/SkiJumpResult");

            var consumeApi = hc.GetAsync("SkiJumpResult");
            consumeApi.Wait();

            var readData = consumeApi.Result;
            if (readData.IsSuccessStatusCode)
            {
                var displayData = readData.Content.ReadAsAsync<IList<JumpsResult>>();
                displayData.Wait();
                jr = displayData.Result;

            }
            return View(jr);
        }
    }
}