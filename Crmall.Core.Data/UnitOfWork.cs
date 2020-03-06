using Crmall.Core.Domain.Repository;

namespace Crmall.Core.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _clienteDataContext;

        public UnitOfWork(DataContext clienteDataContext)
        {
            _clienteDataContext = clienteDataContext;
        }

        public int Commit()
        {
            return _clienteDataContext.SaveChanges();
        }
    }
}
