using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EsempioMVC.Models;

namespace EsempioMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) //risolve la dipendenza per il logger
        {
            _logger = logger;
        }

        //da 1 a N metody "Action qualcosa"
        public IActionResult Index() //chiama il file index del sito
        {
            //throw new InvalidOperationException();
            return View();
        }

        public IActionResult Privacy() //chiama il file con le info Privacy
        {
            return View();
        }

        /*[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }*/

        public IActionResult Error()
        {
            return View();
        }

    }
}
