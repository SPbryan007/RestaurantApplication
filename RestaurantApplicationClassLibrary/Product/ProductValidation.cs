using RestaurantApplicationClassLibrary.Helpers.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplicationClassLibrary.Product
{
    public class ProductValidation : IValidation
    {
        private readonly IClassValidator<Product> _validator;
        public ProductValidation(IClassValidator<Product> validator)
        {
            this._validator = validator;
        }
        public ValidationResult Validate()
        {
            _validator.IsNotEmptyOrNull((x => x.Name), "Please introduce a name");
            _validator.IsNotEmptyOrNull(x => x.Price, "Please introduce a price");
            return _validator.IsValid();
        }
    }
 
}
