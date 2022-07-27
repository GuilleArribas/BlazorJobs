using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PFG_BlazorWS.Models
{
    public class Oferta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "Puesto de Trabajo")]
        public string Puesto { get; set; }

        [MaxLength(100), Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), MaxLength(100), Display(Name = "Empresa")]
        public Empresa Empresa { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido"), Display(Name = "Tipo de Contrato")]
        public TipoContrato TipoContrato { get; set; } // modificar para que sea una elección

        [Display(Name = "Salario mínimo")]
        public int MinSalario { get; set; }

        [Display(Name = "Salario máximo")]
        public int MaxSalario { get; set; }

        [MaxLength(100), Display(Name = "País")]
        public string Pais { get; set; }

        [MaxLength(100), Display(Name = "Ciudad")]
        public string Ciudad { get; set; }

        [Display(Name = "Disponibilidad para viajar")]
        public bool DisponibilidadViajar { get; set; } // checkbox 

        [Required(ErrorMessage = "El Campo {0} es requerido"), Display(Name = "Duración Contrato")]
        public int DuracionContrato { get; set; }

        public DateTime PublicacionOferta { get; set; }
        public DateTime CaducidadOferta { get; set; }
        public string NivelEstudios { get; set; }
        public int Experiencia { get; set; }
        public Titulacion Titulacion { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Idioma> Idiomas { get; set; }
        public Fichero FicheroAdjunto { get; set; }
        public EstadoOferta EstadoOferta { get; set; }
        public string NombreContacto { get; set; }

        [MaxLength(100), Display(Name = "Email de contacto"), EmailAddress(ErrorMessage = "El formato del texto no corresponde a un Email")]
        public string EmailContacto { get; set; }

        [MaxLength(30), Display(Name = "Teléfono de contacto"), Phone(ErrorMessage = "El formato del texto no corresponde a un teléfono")]
        public string TelefonoContacto { get; set; }
    
    }

    public enum EstadoOferta
    {
        PUBLICADA = 0,
        PENDIENTE = 1,
        CADUCADA = 2
    }

    public enum TipoContrato
    {
        PRACTICAS = 0,
        MEDIA_JORNADA = 1,
        INDEFINIDO = 2
    }

    public enum Titulacion
    {
        GRADO_MEDIO = 0,
        GRADO_SUPERIOR = 1,
        GRADO_UNIVERSITARIO = 2,
        MASTER = 3,
        DOCTORADO = 4
    }




}
