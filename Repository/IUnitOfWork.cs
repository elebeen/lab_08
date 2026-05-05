namespace lab_08.Repository;

public interface IUnitOfWork
{
    IRepository<TEntity> Repository<TEntity>() where TEntity : class;
    IClientRepository ClientRepository { get; }
    Task<int> SaveChanges();
}