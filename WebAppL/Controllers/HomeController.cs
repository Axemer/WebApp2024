﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppL.Models;

namespace WebAppL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public string Rex()
        {
            return "Rex says woof!" + "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣠⡴⠶⣶⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⣼⣶⣦⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⠃⠀⠀⠀⠘⢿⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⢹⣏⡿⢿⣿⡦⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⠇⠀⠀⣴⣴⡀⠘⢻⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⢻⣇⡀⠙⢿⣮⡈⠳⣦⣤⣀⠀⠀⠀⠀⠀⣿⠀⠀⢰⣿⣿⣿⡀⠈⢻⣿⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠈⣿⡆⠀⠀⠻⡿⣦⠀⠉⢽⣿⣶⠶⢦⣶⣿⠀⠀⢸⣿⣿⣿⡇⠀⠘⢿⣿⣷⢄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠘⣧⣄⣀⡀⠘⠽⣷⣤⣾⡟⠀⠀⠀⣿⣿⣦⡀⠈⢿⣿⣿⠇⠀⠀⠸⣿⣿⡇⠹⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠘⣇⠀⠀⠀⢀⣼⠿⠃⠀⠀⢀⣤⠟⠻⠿⣿⣄⢸⣿⠏⠀⠀⠀⠀⠻⢿⣷⠀⠈⢻⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⢹⡄⢀⡶⠛⠁⠀⠀⢀⣴⣿⠋⠀⠀⠀⠀⠉⠻⠋⠀⠀⠀⠀⠀⠀⠀⣿⡄⠀⠀⠙⣿⢦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠈⣿⠟⢀⡴⢀⡇⢀⣿⠿⠛⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⣷⡀⠀⠀⠈⢦⡙⣷⡀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⣿⣶⠟⠀⢸⡁⣾⠀⠀⠀⠀⠀⠀⠠⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣧⠀⠀⠀⠀⠑⢿⣿⣷⣄⡀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⣿⠏⠀⢀⣿⠀⣿⣠⠖⠓⣦⠀⠀⠀⠈⠳⢦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣧⡀⠀⠀⠀⠀⢹⣾⣿⠛⠶⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⢠⣿⡀⠀⢸⡇⠠⣿⡏⠀⠀⣟⣀⡀⠀⠀⠀⠀⠙⢷⡀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡇⠀⠀⠀⠀⠀⠙⣿⠀⠀⠀⠀⡀\r\n⠀⠀⠀⠀⠀⠀⢈⣿⣿⣶⣾⠃⠀⣿⠀⠐⢋⣽⠿⢿⢾⡿⢷⣦⡀⠀⠉⠒⠀⠀⠀⠀⠀⠀⠀⢻⡄⠀⠀⠀⠀⠀⠈⣿⡇⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠘⣿⣿⣿⠃⠀⠀⠘⢷⣴⣿⣿⣶⠶⠟⠁⠀⠈⣿⣷⣦⣤⣀⡀⠀⠀⠀⠀⠀⠈⢻⡆⠀⠀⠀⠀⠀⠸⡇⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⢿⣼⠃⠀⠀⠀⢀⢾⠟⠉⠀⠀⠀⠀⠀⠀⢠⣿⡇⠀⠉⠉⠛⣷⠀⠀⠀⠀⠀⠀⡇⠀⠀⠀⠀⠀⠀⣇⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⢀⡾⠁⠀⠀⠀⠀⠠⢻⣦⣴⣄⣀⣙⣷⡦⣶⣦⣿⣷⡀⠀⠀⢠⣿⠀⠀⠀⠀⠀⠀⡇⠀⠀⠀⠀⠀⠈⣿⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⣠⠎⠀⠀⠀⠀⢀⡠⠒⠉⠉⠉⠉⠉⠛⠛⠀⠀⢿⣿⣿⣷⡀⢀⣾⣿⠀⠀⠀⠀⠀⠀⣉⠀⠀⠀⠀⠀⠀⣿⠀⠀⠀⠀\r\n⠀⠀⠀⢀⡼⠅⢀⣴⠆⠀⠔⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠁⠙⠛⣿⣿⠃⠀⠀⠀⠀⠀⠀⡟⠀⠀⠀⠀⠀⢸⡇⠀⠀⠀⠀\r\n⠀⠀⣠⠾⠀⣠⣿⣋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣇⠀⠀⠀⠀⠀⠀⢀⡇⠀⠀⠀⠀⠀⢸⡃⠀⠀⠀⠀\r\n⠀⡼⠁⠀⣴⣻⣿⣧⠖⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣠⠖⠁⠘⢿⣷⠀⠀⠀⠀⠀⠀⢸⠀⠀⠀⠀⠀⠀⠾⠁⠀⠀⠀⠀\r\n⠈⣷⣾⣿⣿⣿⣿⠟⠀⠀⠀⠀⠀⠀⠀⠀⢀⡴⠃⠀⣠⣾⠿⠋⠀⠀⠀⠀⠀⢿⠀⠀⠀⠀⠀⢀⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠈⢿⣿⣿⣽⡟⠀⠀⠀⠀⠀⠀⢀⣠⣞⣩⣤⠴⠚⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠉⠻⢧⣀⣠⣄⣀⣤⡶⣞⡿⠟⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡰⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠈⠙⠛⠛⣿⡟⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣷⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢘⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀";
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
