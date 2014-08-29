using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class ContactModel
    {
        //Champs obligatoires
        [Required(ErrorMessage="Required")] //Affiche Requi seulement
        public string Name { get; set; }

        [Required]
        [RegularExpression(@".*@.*", ErrorMessage = "Must be a valid email")]
        public string Email { get; set; }
        
        [Required]
        public string Comments { get; set; }
    }
}