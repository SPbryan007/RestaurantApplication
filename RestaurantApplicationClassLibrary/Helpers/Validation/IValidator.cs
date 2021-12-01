using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplicationClassLibrary.Helpers.Validation
{
    public interface IClassValidator<T>
    {
        public IClassValidator<T> IsNotEmptyOrNull(Expression<Func<T, object>> expression, string message);
        public IClassValidator<T> IsValidEmail(Expression<Func<T, object>> expression, string message);
        public ValidationResult IsValid();
    }
}
