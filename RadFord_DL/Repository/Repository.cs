using RadFordDataAccessLayer.Interfaces;

namespace RadFordDataAccessLayer.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    #region >> Local Variable
    #endregion

    #region >> System Methods
    #endregion

    #region >> Local Methods

    public void Add(T obj)
    {
        using (var _context = new RDbContext())
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }
    }

    public string Delete(int id)
    {
        try
        {
            using (var _context = new RDbContext())
            {
                var obj = _context.Set<T>().Find(id);
                _context.Set<T>().Remove(obj);
                _context.SaveChanges();
                return String.Empty;
            }
        }
        catch (Exception ex)
        {

            return ex.InnerException.Message;
        }
    }

    public IEnumerable<T> GetAll()
    {
        using (var _context = new RDbContext())
        {
            return  _context.Set<T>().ToList();
        }
    }

    public IEnumerable<T> GetAllWithPagination(int pageSize, int pageNo)
    {
        using (var _context = new RDbContext())
        {
            return _context.Set<T>().Skip((pageNo - 1) * pageSize).Take(pageSize).ToList();;
        }
    }

    public async Task<T> GetById(int id)
    {
        using (var _context = new RDbContext())
        {
            return await _context.Set<T>().FindAsync(id);
        }
    }

    public void Update(T obj)
    {
        using (var _context = new RDbContext())
        {
            _context.Set<T>().Update(obj);
            _context.SaveChanges();
        }
    }

    #endregion
}
