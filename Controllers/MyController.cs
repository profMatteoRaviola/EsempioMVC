using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsempioMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EsempioMVC.Controllers
{
    public class MyController : Controller 
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Other()
        {
            return View();
        }

        public IActionResult Contact() //permette di vedere il form contatti
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(ContactViewModel model) //risponde al post del form
            //passaggio di un modello da una view al controller
        {
            //se i dati che arrivano rispettano le regole di validazione di ContactViewModel
            if(ModelState.IsValid)
            {
                //gestione della richiesta
                ViewBag.Message = "Dati inseriti correttamente";

            }
            return View();
        }
    }
}
    /*la convenzione per return View() di MVC è che MVC si aspetta che in Views ci sia una 
    sottocartella che si chiama come il prefisso della classe , quindi un folder My
    al cui interno tanti file, quate le Action, che si chiamano come le action a cui corrispondono, 
    quindi index, other e contact in questo caso*/
