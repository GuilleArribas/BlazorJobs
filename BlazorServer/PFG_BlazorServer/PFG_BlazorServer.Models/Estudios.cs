using System;
using System.Collections.Generic;
using System.Text;

namespace PFG_BlazorServer.Models
{
    public class EstudiosAcademicos
    {
        public int Id { get; set; }
        public string NameCurso { get; set; }
        public DateTime InicioCurso { get; set; }
        public DateTime FinCurso { get; set; }
        public bool IsActive { get; set; }
        public string NameCentro { get; set; }
        public string DescripcionCurso { get; set; }

    }
}
