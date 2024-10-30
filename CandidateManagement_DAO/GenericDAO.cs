using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateManagement_DAO
{
    public class GenericDAO<T> where T: class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericDAO(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetById(string id)
        {
            return _dbSet.Find(id);
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            var entity = GetById(id);
            if (entity != null) 
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
