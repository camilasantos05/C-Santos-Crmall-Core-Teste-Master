namespace Crmall.Core.Domain.Repository
{
    public interface IUnitOfWork
    {
        int Commit();
    }
}
