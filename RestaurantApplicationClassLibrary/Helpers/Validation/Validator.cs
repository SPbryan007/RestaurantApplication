using FluentValidation;
using RestaurantApplicationClassLibrary.Helpers.Validation;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace RestaurantApplicationClassLibrary
{
    public class ClassValidator<T> : AbstractValidator<T>, IClassValidator<T> where T : class
    {
        private readonly ValidationResult _result = new ValidationResult();
        protected readonly T _entity;
        public ClassValidator(T entity) => this._entity = entity;
        public IClassValidator<T> IsNotEmptyOrNull(Expression<Func<T, object>> expression, string message)
        {
            RuleFor(expression).NotEmpty().WithMessage(message);
            return this;
        }
        public ValidationResult IsValid()
        {
            var validate = Validate(_entity);
            if (!validate.IsValid)
                _result.AddValidationError
                    (new ValidationError(validate.Errors.Select(i => i.ErrorMessage).ToString()));
            return this._result;
        }
        public IClassValidator<T> IsValidEmail(Expression<Func<T, object>> expression, string message)
        {
            return this;
        }
    }
}
