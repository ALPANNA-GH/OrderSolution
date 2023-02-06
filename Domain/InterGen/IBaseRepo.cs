using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InterGen
{
    public interface IBaseRepo<T> where T : class 
    {
        public T Get(int id);
        public IEnumerable<T> GetAllOrder();
        public T Add(T item);
        public T Delete(T item) ;
        public T update(int id);
        public T find(int id);
    }
}
