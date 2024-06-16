using Microsoft.AspNetCore.Mvc;
using WebAppL.Models;
using WebAppL.Service;

namespace WebAppL.Controllers
{
    public class PersonController(IListService listService) : Controller
    {
        private readonly IListService _listService = listService;

        public IActionResult Index()
        {
            var items = _listService.GetAll();
            ViewBag.PersonList = items;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return RedirectToAction(nameof(Index)); 
        }

        [HttpPost]
        public IActionResult Create(PersonModel item)
        {
            PersonModel person = item;

           

            if (ModelState.IsValid)
            {
                // Проверяем, что ученик с такими же данными не существует в этой группе
                if (_listService.GetAll().Any(s => s.Group == item.Group && s.Surname == item.Surname && s.Name == item.Name && s.MidName == item.MidName))
                {
                    ModelState.AddModelError("", "Ученик с такими же данными уже существует в этой группе.");
                    return RedirectToAction(nameof(Index));
                }

                _listService.Add(item);
                return RedirectToAction(nameof(Index));
            }
            
            //return RedirectToAction(nameof(Index));
            return View(item);
            
        }
    }
}