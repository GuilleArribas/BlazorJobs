using PFG_BlazorServer.Data;
using PFG_BlazorServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFG_BlazorServer.Services
{
    public class EmpresaService : IEmpresaService
    {

        private readonly ApplicationDbContext _context;

        public EmpresaService (ApplicationDbContext context)
        {
            _context = context;
        }
        public Task<bool> DeleteEmpresa(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Empresa> GetEmpresa(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Empresa>> GetEmpresas()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertEmpresa(Empresa empresa)
        {
            _context.EMPRESA.Add(empresa);

            return await _context.SaveChangesAsync() > 0;
        }

        public Task<bool> UpdateEmpresa(Empresa empresa)
        {
            throw new NotImplementedException();
        }
    }
}
