using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplicationClassLibrary.Helpers.Validation
{
    public interface IValidationError
    {
        public string message { get; set; }
    }
    public class ValidationError : IValidationError
    {
        public string message { get; set; }
        public ValidationError(string message)
        {
            this.message = message;
        }
    }
}
