using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplicationClassLibrary
{
    public class CustomerRepository : Repository<Customer>
    {
        public CustomerRepository(IDbContext<Customer> customer) : base(customer) { }
        public CustomerRepository() { }
    }
}
