using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsempioMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EsempioMVC.Controllers
{
    public class CategoriesController : Controller
    {
        //passaggio di un modello da controller a view: tramite le strutture condivise ViewBag e viewData, e tramite return del model
        public IActionResult Index() 
        {
            var model = GetCategories();
            //strutture dati utili condivise fra controller e view
            ViewBag.Message = "Ciao Mondo!!";
            ViewData["1"] = "primo"; //come ViewBag ma con la sintassi di un dizionario con key string
            ViewData["2"] = "secondo";
            return View(model); //così facendo passiamo il modello alla view
        }
        private IEnumerable<Category> GetCategories() 
            //per ora generiamo in locale l'array delle categorie, ma poi lo prenderemo dal db
        {
            return new[]
            {
                new Category{Id=1, Name="Bevande"},
                new Category{Id=2, Name="Snacks"}
            };
        }
    }
}
