using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplicationClassLibrary.Abstraction
{
    interface ISpecification<T>
    {
        public bool IsSatisfied(T obj);
    }

  

    //public class IsNotEmptyOrNullSpecification<T> : ExpressionSpecification<T>
    //{
    //    private readonly Expression<Func<T, object>> _expression;
    //    public IsNotEmptyOrNullSpecification(Expression<Func<T, object>> expression) 
    //        : base( expression.Compile()())
    //    {
    //        this._expression = expression;
    //    }
    //    public bool IsSatisfied(T entity)
    //    {
    //        var value = _expression.Compile()(entity);
    //        var type = typeof(T);
    //        if (type.Equals(typeof(string)))
    //            return !string.IsNullOrEmpty(value as string);
    //        if (type.Equals(typeof(int)))
    //            return ((int)value) > 0;
    //        if (type.Equals(typeof(DateTime)))
    //            return !((DateTime)value).Equals(DateTime.MinValue);
    //        return value != null;
    //    }
    //}

    //public class IsValidEmailSpecification<T> : ISpecification<T>
    //{
    //    private readonly string email;
    //    public IsValidEmailSpecification(string email)
    //    {
    //        this.email = email;
    //    }

    //    public bool IsSatisfied(T obj)
    //    {
    //        return true;
    //    }
    //}
}
