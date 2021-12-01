using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using RestaurantApplicationClassLibrary.Abstraction;
using RestaurantApplicationClassLibrary.Helpers.Validation;

namespace RestaurantApplicationClassLibrary
{
 
    public interface IValidationBuilder<T>
    {
        public IValidationBuilder<T> IsNotEmptyOrNull(Expression<Func<T, object>> expression, string message);
    }

    //public abstract class ValidationBuilder<T> : IValidationBuilder<T>
    //{
    //    protected readonly T _entity;
    //    private readonly ValidationResult _result = new ValidationResult();
    //    public ValidationBuilder(T entity) => this._entity = entity;
    //    public IValidationBuilder<T> IsNotEmptyOrNull
    //        (Expression<Func<T , object>> expression, string message)
    //    {
    //        if (!(new IsNotEmptyOrNullSpecification<T>(expression)
    //            .IsSatisfied(_entity)))
    //                this._result.AddValidationError(new ValidationError(message));
    //        return this;
    //    }
    //    public IValidationBuilder<T> IsValidEmail(Expression<Func<T, object>> expression, string  message)
    //    {
    //        //if (!(new IsValidEmailSpecification<T>(expression).IsSatisfied(_entity)))
    //        //    this._result.AddValidationError(new ValidationError(message));
    //        return this;
    //    }
    //}

   

   

   
   
   
}
