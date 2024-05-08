using WebAppL.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAppL.Controllers
{
    public class BdayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CompareDates(DateTime FirstDate, DateTime SecondDate)
        {
            string result = BDayModel.CheckDates(FirstDate, SecondDate);
            ViewBag.Bday = result;
            return View("Index");
        }
    }
}
