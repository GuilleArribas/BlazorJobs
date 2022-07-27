using PFG_BlazorServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PFG_BlazorServer.Services
{
    public interface IEstudianteService
    {
        Task<IEnumerable<Estudiante>> GetEstudiantes();
        Task<Estudiante> GetEstudiante(int id);
        Task<bool> InsertEstudiante(Estudiante Estudiante);
        Task<bool> UpdateEstudiante(Estudiante Estudiante);
        Task<bool> DeleteEstudiante(int id);
    }
}
