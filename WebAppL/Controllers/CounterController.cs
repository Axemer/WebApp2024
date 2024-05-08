using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;
using WebAppL.Models;

namespace WebAppL.Controllers
{
    public class CounterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Count(string Text)
        {
            CounterModel counter = new CounterModel();
            counter.Count(Text);

            ViewBag.Pluses = counter._count_plus;
            ViewBag.Minuses = counter._count_minus;
            ViewBag.Both = counter._count_all;
            ViewBag.Letters = counter._count_otherall;
            return View("Index");
        }
    }
}
