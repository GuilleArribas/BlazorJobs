using PFG_BlazorServer.Data;
using PFG_BlazorServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PFG_BlazorServer.Services
{
    public class EstudianteService : IEstudianteService
    {
        private readonly ApplicationDbContext _context;

        public EstudianteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<bool> DeleteEstudiante(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Estudiante> GetEstudiante(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Estudiante>> GetEstudiantes()
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> InsertEstudiante(Estudiante Estudiante)
        {
            _context.ESTUDIANTE.Add(Estudiante);

            return await _context.SaveChangesAsync() > 0;
        }

        public Task<bool> UpdateEstudiante(Estudiante Estudiante)
        {
            throw new System.NotImplementedException();
        }
    }
}
