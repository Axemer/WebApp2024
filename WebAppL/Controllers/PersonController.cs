using Microsoft.AspNetCore.Mvc;
using WebAppL.Models;
using WebAppL.Service;

namespace WebAppL.Controllers
{
    public class PersonController : Controller
    {
        private PersonModel person = new PersonModel();
        private List<PersonModel> PersonList { get; set; } = new List<PersonModel>();
        private Group Group { get; set; } = new Group();

        //private readonly ListService _listService;

        public IActionResult Index()
        {
            Group.Persons.Add(new PersonModel
            {
                Surname = "Гринев",
                Name = "Алексей",
                MidName = "Ярославович",
                Group = "571-2",
                TelNum = "87678787878",
                Email = "alexa@mvx.com"
            });
            

            ViewBag.PersonList = Group.Persons;
            return View(person);

            //var items = _listService.GetAll();
            //return View(items);
        }

        [HttpPost]
        public IActionResult Create(PersonModel NewPerson)
        {
            // Проверяем, что ученик с такими же данными не существует в этой группе
            if (PersonList.Any(s => s.Group == NewPerson.Group && s.Surname == NewPerson.Surname && s.Name == NewPerson.Name && s.MidName == NewPerson.MidName))
            {
                ModelState.AddModelError("", "Ученик с такими же данными уже существует в этой группе.");
                //return View(person);
            }

            // Валидируем данные ученика
            if (ModelState.IsValid)
            {
                PersonList.Add(NewPerson);
                //return View(NewPerson); 
                ViewBag.PersonList = PersonList;
                //return RedirectToAction("Index"); 
            }

           
            return RedirectToAction("Index");
        }

    }
}


//Group.Persons.Add(new PersonModel
//{
//    Surname = "ваывфывафываф",
//    Name = "Алексей",
//    MidName = "Ярославович",
//    Group = "571-2",
//    TelNum = "87678787878",
//    Email = "alexa@mvx.com"
//});

//PersonModel person = new PersonModel().Create(Фамилия, Имя, Отчество, Группа, Телефон, Email);

//person.People?.Add(person);

//return View("Index");

//[HttpPost]
//public IActionResult Create(PersonModel person)
//{
//    // Проверяем, что ученик с такими же данными не существует в этой группе
//    if (ViewBag.Person.Any(s => s.Group == person.Group && s.Surname == person.Surname && s.Name == person.Name && s.MidName == person.MidName))
//    {
//        ModelState.AddModelError("", "Ученик с такими же данными уже существует в этой группе.");
//        return View(person);
//    }

//    // Валидируем данные ученика
//    if (ModelState.IsValid)
//    {
//        person.PersonList.Add(person);
//        return View(person); //RedirectToAction("Index"); 
//    }

//    //PersonModel person = new PersonModel().Create(Фамилия, Имя, Отчество, Группа, Телефон, Email);

//    //person.People?.Add(person);

//    return View("Index");
//}

//public IActionResult FindPerson(string surname, string name, string midname)
//{
//    var matchingPersons = person.PersonList.Where(s => s.Surname == surname && s.Name == name && s.MidName == midname);
//    return View("Index", matchingPersons.GroupBy(s => s.Group).ToList());
//}

//// Метод для создания таблицы и заполнения ее данными из списка
//public ActionResult CreateAndPopulateTable()
//{
//    // Список данных для заполнения таблицы
//    List<TableData> data = new List<TableData>
//    {
//        new TableData { LastName = "Иванов", FirstName = "Петр", Patronymic = "Сергеевич", Group = "Группа 1", Phone = "1234567890", Email = "ivanov@example.com" },
//        new TableData { LastName = "Петров", FirstName = "Иван", Patronymic = "Александрович", Group = "Группа 2", Phone = "9876543210", Email = "petrov@example.com" },
//        // Добавьте остальные данные в список
//    };

//    // Создание таблицы в виде HTML-разметки
//    string tableHtml = "<table><thead><tr><th>Фамилия</th><th>Имя</th><th>Отчество</th><th>Группа</th><th>Телефон</th><th>E-mail</th></tr></thead><tbody>";

//    // Заполнение таблицы данными из списка
//    foreach (var item in data)
//    {
//        tableHtml += $"<tr><td>{item.LastName}</td><td>{item.FirstName}</td><td>{item.Patronymic}</td><td>{item.Group}</td><td>{item.Phone}</td><td>{item.Email}</td></tr>";
//    }

//    tableHtml += "</tbody></table>";

//    // Возвращение таблицы в виде HTML-разметки
//    return Content(tableHtml, "text/html");
//}