﻿using System.Linq.Expressions;
using Mate.DAL.DbContexts;
using Mate.DAL.GenericRepository.Abstract;
using Mate.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Mate.DAL.GenericRepository.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        public SqlDbContext _dbContext { get; set; }
        public Repository()
        {
            _dbContext = new SqlDbContext();
        }



        #region CRUD Islemleri
        public int Create(T entity)
        {
            /*
             * Buradaki Set<T> metodu DbContext icerisindeki 
             * DbSet<T> property'sinine konumlanir
             */
            _dbContext.Set<T>().Add(entity);
            return _dbContext.SaveChanges();
        }

        public int Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            return _dbContext.SaveChanges();
        }
        public int Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            return _dbContext.SaveChanges();
        }
        #endregion



        public T? GetById(string id)
        {
            return _dbContext.Set<T>().Find(id);

        }

        public T? Get(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().FirstOrDefault(predicate);
        }
        public List<T>? GetAll(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate != null)
            {
                return _dbContext.Set<T>().Where(predicate).ToList();
            }

            return _dbContext.Set<T>().ToList();


            //  return predicate==null ? _dbContext.Set<T>().ToList(): _dbContext.Set<T>().Where(predicate).ToList();
        }

        public IQueryable<T>? GetAllInclude(Expression<Func<T, bool>> predicate = null,
            params Expression<Func<T, object>>[] include)
        {
            IQueryable<T> query = _dbContext.Set<T>();
            if (predicate != null)
            {
                query = _dbContext.Set<T>().Where(predicate);
            }
            return include.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

    }

}

