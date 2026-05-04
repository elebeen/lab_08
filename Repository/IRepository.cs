namespace lab_08.Repository;

public interface IRepository<TEntity> where TEntity : class
{
    IEnumerable<TEntity> FindAll();
    TEntity FindById(int id);
    TEntity FindByName(string name);
    void Add(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
}