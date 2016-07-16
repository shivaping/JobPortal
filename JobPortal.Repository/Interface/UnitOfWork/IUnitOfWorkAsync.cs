using System.Threading;
using System.Threading.Tasks;
using JobPortal.Repository.Interface.Infrastructure;
using JobPortal.Repository.Interface.Repositories;

namespace JobPortal.Repository.Interface.UnitOfWork
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class, IObjectState;
    }
}