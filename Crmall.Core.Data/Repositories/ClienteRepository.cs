using Crmall.Core.Domain.Entities;
using Crmall.Core.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crmall.Core.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext _context;

        public ClienteRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(Cliente cliente)
        {
            _context.Add(cliente);
        }

        public void Update(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            _context.Entry(cliente.Endereco).State = EntityState.Modified;
        }

        public void Delete(Guid id)
        {
            var cliente = FindById(id);

            if (cliente == null)
                return;

            _context.Remove(cliente);
        }

        public Cliente FindById(Guid id)
        {
            return _context.Clientes.Where(w => w.Id == id).AsNoTracking().SingleOrDefault();
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _context.Set<Cliente>().AsNoTracking();
        }

        public async Task<Cliente> SaveAsync(Cliente entity)
        {
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
