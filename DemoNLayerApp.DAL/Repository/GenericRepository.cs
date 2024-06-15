using DemoNLayerApp.DAL.Context;
using DemoNLayerApp.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DemoNLayerApp.DAL.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DemoNLayerAppDbContext context;
        private readonly DbSet<T> table;

        public GenericRepository(DemoNLayerAppDbContext context)
        {
            this.context = context;
            table = context.Set<T>();
        }
        public async Task Add(T entity)
        {
            await table.AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
            await table.AddRangeAsync(entities);
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> expression)
        {
           return table.Where(expression).ToList();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await table.FindAsync(id);
        }

        public void Remove(T entity)
        {
            table.Remove(entity);
        }

    }
}
