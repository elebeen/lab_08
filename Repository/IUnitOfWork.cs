namespace lab_08.Repository;

public interface IUnitOfWork
{
    IRepository<TEntity> Repository<TEntity>() where TEntity : class;
    Task<int> SaveChanges();
}