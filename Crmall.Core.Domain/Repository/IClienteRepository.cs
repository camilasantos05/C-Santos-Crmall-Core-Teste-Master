using Crmall.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Crmall.Core.Domain.Repository
{
    public interface IClienteRepository
    {
        void Create(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(Guid id);
        Cliente FindById(Guid id);
        IEnumerable<Cliente> GetAll();
        Task<Cliente> SaveAsync(Cliente entity);
    }
}
