using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplicationClassLibrary
{
    public interface ICrud<T>
    {
        public T Save(T obj);
        public IEnumerable<T> GetAll();
        public T GetById(string id);
        public void Update(string id, T obj);
        public void Delete(string id);

    }

}
