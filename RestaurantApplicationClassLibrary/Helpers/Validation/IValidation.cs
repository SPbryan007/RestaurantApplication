using RestaurantApplicationClassLibrary.Helpers.Validation;

namespace RestaurantApplicationClassLibrary
{
    public interface IValidation
    { 
        public ValidationResult Validate();
    }
}