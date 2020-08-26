using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EsempioMVC.ViewModels
{
    //nell'esempio vengono iniettate le regole di validazione dei campi
    public class ContactViewModel //deve riflettere i campi del form che vogliamo creare
    {
        [Required(ErrorMessage ="Messaggio personalizzato: Nome obbligatorio")]
        [RegularExpression("[A-Z][a-z]{1,11}",ErrorMessage ="Il nome non è conforme ")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Messaggio personalizzato: Cognome obbligatorio")]
        [RegularExpression("[A-Z][a-z]{1,11}", ErrorMessage = "Il cognome non è conforme ")]
        public string Cognome { get; set; }

        [Required(ErrorMessage = "Messaggio personalizzato: Titolo obbligatorio")]
        [RegularExpression("Dottore in [A-Z][a-z]{1,11}", ErrorMessage = "Il titolo di studio non è conforme ")]
        public string Titolo { get; set; }
    }
}
