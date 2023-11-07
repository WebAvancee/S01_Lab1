using Jungle_DataAccess.Data;
using Jungle_Models;

namespace Services
{
    public class ServiceBaseEF<T> : IServiceBase<T> where T : class
    {
        protected readonly JungleDbContext _dbContext;

        public ServiceBaseEF(JungleDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public T Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}