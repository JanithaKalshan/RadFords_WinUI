namespace RadFordDataAccessLayer.Interfaces;

public interface IRepository<T> where T : class
{
    void Add(T obj);
    void Update(T obj);
    string Delete(int id);
    IEnumerable<T> GetAll();
    Task<T> GetById(int id);
    IEnumerable<T> GetAllWithPagination(int pageSize, int pageNo);
}
