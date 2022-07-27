using PFG_BlazorServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFG_BlazorServer.Services
{
    public interface IEmpresaService
    {
        Task<IEnumerable<Empresa>> GetEmpresas();
        Task<Empresa> GetEmpresa(int id);
        Task<bool> InsertEmpresa (Empresa empresa);
        Task<bool> UpdateEmpresa (Empresa empresa);
        Task<bool> DeleteEmpresa(int id);
    }
}
