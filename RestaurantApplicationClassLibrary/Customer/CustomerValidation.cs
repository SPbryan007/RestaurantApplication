using RestaurantApplicationClassLibrary.Helpers.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplicationClassLibrary
{
    public class CustomerValidation : IValidation
    {
        private readonly IClassValidator<Customer> _validator;
        public CustomerValidation(IClassValidator<Customer> validator)
        {
            this._validator = validator;
        }
        public ValidationResult Validate()
        {
            _validator.IsNotEmptyOrNull((x => x.Name), "Please introduce a name");
            _validator.IsNotEmptyOrNull(x => x.Document,"Please introduce a Nit/CI");
            return _validator.IsValid();
        }
    }
}
