using System;
using System.Collections.Generic;
using System.Text;

namespace PFG_BlazorServer.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public List<Empresa> Empresas { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public List<Oferta> Ofertas { get; set; }
    }
}
