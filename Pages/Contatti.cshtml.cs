using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EsempioMVC.RasorPages
{
    public class ContattiModel : PageModel
    {
        [Required(ErrorMessage = "Messaggio personalizzato: Nome obbligatorio")]
        [RegularExpression("[A-Z][a-z]{1,11}", ErrorMessage = "Il nome non è conforme ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Messaggio personalizzato: Cognome obbligatorio")]
        [RegularExpression("[A-Z][a-z]{1,11}", ErrorMessage = "Il cognome non è conforme ")]
        public string Cognome { get; set; }

        [Required(ErrorMessage = "Messaggio personalizzato: Titolo obbligatorio")]
        [RegularExpression("Dottore in [A-Z][a-z]{1,11}", ErrorMessage = "Il titolo di studio non è conforme ")]
        public string Titolo { get; set; }

        public void OnPost()
        {
            ViewData["result1"] = "Method: POST";
            ViewData["result2"] = "Dati arrivati alla Rasor Page in formato corretto";
        }
    }
}
