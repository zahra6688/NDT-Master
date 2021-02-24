using Microsoft.EntityFrameworkCore;
using NDT.Domain.Interfaces;
using NDT.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDT.Infra.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly NdtDbContext _context;
        public GenericRepository(NdtDbContext context)
        {
            _context = context;
        }

        public async Task Create(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(object id)
        {
            var entity = GetById(id);
            await Delete(entity);
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                //_context = null;
            }
        }

        public IQueryable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking();
        }

        public TEntity GetById(object id)
        {
            return  _context.Set<TEntity>()
                .Find(id);
        }

        public async Task Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
