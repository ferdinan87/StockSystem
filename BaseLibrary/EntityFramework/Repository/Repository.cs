using BaseLibrary.EntityFramework.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.EntityFramework.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly PlantLogsheetsContext _context;
        private readonly DbSet<T> _entities;

        public Repository(PlantLogsheetsContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
            _entities = _context.Set<T>();  
        }

        public void Add(T entity)
        {
            _entities.Add(entity);

        }

        public void Update(T entity)
        {
            _entities.Attach(entity);
            var entry = _context.Entry(entity);
            entry.State = EntityState.Modified;

        }

        public void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _entities.Attach(entity);
            }
            _entities.Remove(entity);
            
        }

        public async Task<T> FindByConditionAsync(Expression<Func<T, bool>> predicate)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public Task<T> GetByIdAsync(int id)
        {
            
            throw new NotImplementedException();
            //return await _entities.SingleOrDefaultAsync(s => s.id == id);
        }

        public async Task<bool> SaveChangesAsync()
        {
            
            return await _context.SaveChangesAsync().ConfigureAwait(false) > 0;
        }
    }
}
