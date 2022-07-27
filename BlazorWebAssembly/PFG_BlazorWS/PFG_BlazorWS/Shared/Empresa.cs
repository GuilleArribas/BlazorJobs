using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PFG_BlazorWS.Models
{
    public class Empresa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "Industria")]
        public string Industry { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "Email"), EmailAddress(ErrorMessage = "El formato del texto no corresponde a un Email")]
        public string Email { get; set; }

        [MaxLength(30), Display(Name = "Teléfono"), Phone(ErrorMessage = "El formato del texto no corresponde a un teléfono")]
        public string Telefono { get; set; }

        [MaxLength(100), Display(Name = "Descripcion")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "País")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "Ciudad")]
        public string Ciudad { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "Calle")]
        public string Calle { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "Codigo Postal")]
        public int CodigoPostal { get; set; }

        public List<Oferta> OfertasPublicadas { get; set; }

        [Display(Name = "Ficheros")]
        public List<Fichero> FicherosAdjuntos { get; set; }
    }
}
