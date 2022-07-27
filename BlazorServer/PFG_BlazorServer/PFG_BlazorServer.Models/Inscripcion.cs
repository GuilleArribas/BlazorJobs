using System;
using System.Collections.Generic;
using System.Text;

namespace PFG_BlazorServer.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }
        public Oferta Oferta { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public DateTime Fecha { get; set; }
    }
}
