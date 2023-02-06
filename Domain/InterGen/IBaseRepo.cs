using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.InterGen
{
    public interface IBaseRepo<T> where T : class 
    {
        public T Get(int ordId);
        public T Add(T ord);
        public T Delete(T ord);
        public T Edit(T ord);
        public IEnumerable<T> findAll();
    }
}
