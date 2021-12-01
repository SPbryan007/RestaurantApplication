using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplicationClassLibrary.Helpers.Validation
{
    public interface IValidationResult
    {
        public void AddValidationError(ValidationError error);
    }
    public class ValidationResult : IValidationResult
    {
        public readonly List<ValidationError> _errors = new List<ValidationError>();
        public ValidationResult() { }

        public List<ValidationError> Errors => _errors;
        public void AddValidationError(ValidationError error) => this._errors.Add(error);

    }
}
