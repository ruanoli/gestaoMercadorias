using GestaoMercadoriasApp.Domain.Interfaces;
using GestaoMercadoriasApp.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoMercadoriasApp.Infra.Repositories
{
    public class BaseRepository<TEntity>  : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DataContext _context;

        public BaseRepository(DataContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public IList<TEntity> GetAll()
        {
           return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }
    }
}
