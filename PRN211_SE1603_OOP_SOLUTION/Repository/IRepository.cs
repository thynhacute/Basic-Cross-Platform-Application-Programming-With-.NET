using ModelEntity.Entities;
namespace Repository;
public interface IRepository<T> where T: class
{
    /// <summary>
    /// Get all entities...
    /// </summary>
    /// <returns>Lists of entities</returns>
    List<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    void Delete(int id);

}
