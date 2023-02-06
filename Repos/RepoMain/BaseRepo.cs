using Domain.Models;
using Domain.InterGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace Repos.RepoMain
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        protected StoreContext _context;
        public BaseRepo(StoreContext context)
        {
            _context = context;
        }

        public T Get(int OrdId)
        {
            throw new NotImplementedException();
        }
        public T Add(T ord)
        {
            _context.Set<T>().Add(ord);
            _context.SaveChanges();
            return ord;
        }

        public T Edit (T ord)
        {
            _context.Set<T>().Update(ord);
            _context.SaveChanges();
            return ord;
        }


        public T Delete(T ord)
        {
            _context.Set<T>().Remove(ord);
            _context.SaveChanges();
            return ord;
        }
        public IEnumerable<T> findAll() => _context.Set<T>();

    }
}

