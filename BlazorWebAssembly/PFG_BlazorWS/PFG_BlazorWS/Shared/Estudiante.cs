using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PFG_BlazorWS.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "Apellido")]
        public string LastName { get; set; }

        public string FullName
        {
            get { return Name + " " + LastName; }
        }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "Email"), EmailAddress(ErrorMessage = "El formato del texto no corresponde a un Email")]
        public string Email { get; set; }

        [MaxLength(30), Display(Name = "Teléfono"), Phone(ErrorMessage = "El formato del texto no corresponde a un teléfono")]
        public string Telefono { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaDeNacimiento { get; set; }

        public bool HasCV { get; set; }
        
        public bool HasPhoto { get; set; }

        [Display(Name = "Experiencia laboral")]
        public List<ExperienciaLaboral> ExperienciaLaboral { get; set; }

        [Display(Name = "Estudios académicos")]
        public List<EstudiosAcademicos> TitulosAcademicos { get; set; }

        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "País")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "Ciudad")]
        public string Ciudad { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Idioma> Idiomas { get; set; }

        public List<Oferta> OfertasSolicitadas { get; set; }

        [Display(Name = "Ficheros adjuntos")]
        public List<Fichero> FicherosAdjuntos { get; set; }
        public byte[] Foto { get; set; }
    }
}
