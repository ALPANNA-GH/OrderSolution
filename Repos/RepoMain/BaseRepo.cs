using Domain.Models;
using Domain.InterGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repos.RepoMain
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        protected StoreContext _context;
        public BaseRepo(StoreContext context)
        {
            _context = context;
        }

        public T Get(int ordid)
        {
            throw new NotImplementedException();
        }
        public AddOrd(int ordid)
        {
            _context.Add(ordid);
            _context.SaveChanges();
        }

        public void EditOrd(int ordid) => _context.Entry(id).Entity.;
        }

        public void Remove(int ordid)
        {
            _context.Remove(ordid);
            _context.SaveChanges();
        }


    public IEnumerable<T> GetAllOrder()
    {
        return _context.Set<T>();
    }

    public T FindById(int ID) => _context.Set<T>().Find(ID);
        
    }
}
