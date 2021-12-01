using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplicationClassLibrary
{
    /// <summary>
    ///     Represents the data access.
    ///     This class allows decople depedencies between Data Providers and our domain (core of application)
    ///     By passing a T class genereic that represents the models that will be.
    ///     All classees that inherits from this class should pass a model class.
    /// </summary>
    /// <typeparam name="T"> The type T stands for an Model class  which </typeparam>
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly IDbContext<T> _context;
        public Repository(IDbContext<T> context)
        {
            this._context = context;
        }
        public Repository()
        {
            this._context = new InMemoryDataAccess<T>();        
        }
        public void Delete(string id)
        {
            this._context.Delete(id);
        }
        public IEnumerable<T> GetAll()
        {
            return this._context.GetAll();
        }
        public T GetById(string id)
        {
            throw new NotImplementedException();
        }
        public T Save(T obj)
        {
            return this._context.Save(obj);
        }
        public void Update(string id, T obj)
        {
            throw new NotImplementedException();
        }
    }
}
