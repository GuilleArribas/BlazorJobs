using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PFG_BlazorWS.Models;
using PFG_BlazorWS.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFG_BlazorWS.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
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

        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
    }
}
