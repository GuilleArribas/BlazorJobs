using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PFG_BlazorServer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PFG_BlazorServer.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Admin> ADMINISTRADOR { get; set; }
        public DbSet<Estudiante> ESTUDIANTE { get; set; }
        public DbSet<Empresa> EMPRESA { get; set; }
        public DbSet<Oferta> OFERTA { get; set; }
        public DbSet<EstudiosAcademicos> ESTUDIO { get; set; }
        public DbSet<ExperienciaLaboral> EXPERIENCIA { get; set; }
        public DbSet<Skill> SKILL { get; set; }
        public DbSet<Idioma> IDIOMA { get; set; }
        public DbSet<Inscripcion> INSCRIPCION { get; set; }
        public DbSet<Fichero> FICHERO { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }

}
