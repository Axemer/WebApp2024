using Microsoft.AspNetCore.Mvc;
using WebAppL.Models;

namespace WebAppL.Controllers
{
    public class PersonController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string Фамилия, string Имя, string Отчество, string Группа, string Телефон, string Email)
        {
            PersonModel person = new PersonModel().Create(Фамилия, Имя, Отчество, Группа, Телефон, Email);

            ViewBag.Persons += person;
            return View("Index");
        }


    }
}
