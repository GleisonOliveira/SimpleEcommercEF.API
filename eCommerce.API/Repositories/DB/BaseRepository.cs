using eCommerce.API.Database;
using eCommerce.API.Repositories.Interfaces;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.Repositories.DB
{
    public abstract class BaseRepository<TModel> : IRepository<TModel> where TModel : ModelBase<int>
    {
        protected readonly eCommerceContext _db;
        protected readonly DbSet<TModel> _dbSet;
        protected IQueryable<TModel> _query;

        /// <summary>
        /// Instantiate a base repository to common actions
        /// </summary>
        /// <param name="dbContext"></param>
        public BaseRepository(eCommerceContext dbContext)
        {
            _db = dbContext;
            _dbSet = dbContext.Set<TModel>();
            _query = _dbSet;
        }

        /// <summary>
        /// Add a model to a database
        /// </summary>
        /// <param name="obj"></param>
        public virtual void Add(TModel obj)
        {
            _dbSet.Add(obj);
            _db.SaveChanges();
        }

        /// <summary>
        /// Delete a model from database
        /// </summary>
        /// <param name="obj"></param>
        public virtual void Delete(TModel obj)
        {
            _dbSet.Remove(obj);
            _db.SaveChanges();
        }

        /// <summary>
        /// List all entries
        /// </summary>
        /// <returns></returns>
        public virtual List<TModel> Get()
        {
            return _dbSet.ToList();
        }

        /// <summary>
        /// Get a model by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual TModel? GetById(int id)
        {
            return _dbSet.Find(id);
        }

        /// <summary>
        /// Update a model
        /// </summary>
        /// <param name="obj"></param>
        public virtual void Update(TModel obj)
        {
            _dbSet.Update(obj);
            _db.SaveChanges();
        }
    }
}
