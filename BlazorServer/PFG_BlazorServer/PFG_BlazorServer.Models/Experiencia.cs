using System;
using System.Collections.Generic;
using System.Text;

namespace PFG_BlazorServer.Models
{
    public class ExperienciaLaboral
    {
        public int Id { get; set; }
        public string NameTrabajo { get; set; }
        public DateTime InicioTrabajo { get; set; }
        public DateTime FinTrabajo { get; set; }
        public string NameEmpresa { get; set; }
        public string PuestoTrabajo { get; set; }

    }
}
