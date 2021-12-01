using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplicationClassLibrary
{
    /// <summary>
    ///     Represets a data provider in memory which store T type of object models
    ///     When no data provider is passed, this is instanciated by default.
    /// </summary>
    /// <typeparam name="T"> Type of model which will be stored in Memory</typeparam>
    public class InMemoryDataAccess<T> : IDbContext<T> 
    {
        private  List<T> _data;
        /// <summary>
        ///     Initialize the _data if no list of T type is passed
        /// </summary>
        public InMemoryDataAccess()
        {
            this._data = new List<T>();
        }
        /// <summary>
        ///     Initialize the _data when a list of T type is passed
        /// </summary>
        /// <param name="data"> List of T types</param>
        public InMemoryDataAccess(List<T> data)
        {
            this._data = data;
        }
        /// <summary>
        ///     Deletes an element from _data 
        /// </summary>
        /// <param name="id"> the id of the element to be eliminated </param>
        public void Delete(string id)
        {
            this._data.Remove(this.GetById(id));
        }

        public IEnumerable<T> GetAll()
        {
            return this._data;
        }
        public T GetById(string id)
        {
            return this._data.First();
        }
        public T Save(T obj)
        {            //obj.Id = UUIDGenerator.generate();
            this._data.Add(obj);
            return obj;
        }

        public void Update(string id, T obj)
        {
            throw new NotImplementedException();
        }
    }
}
