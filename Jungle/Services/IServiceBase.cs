using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IServiceBase<T> where T : class
    {
        T Add(T entity);
        void Delete(int id);
        IReadOnlyList<T> GetAll();
        T GetById(int id);
        void Update(T entity);

    }
}
