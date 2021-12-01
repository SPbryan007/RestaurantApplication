using System;

namespace RestaurantApplicationClassLibrary
{
    public class Customer
    {
        private string _name;
        private string _document;
        /// <summary>
        ///     private fileds initialization
        /// </summary>
        /// <param name="name">Client's full name</param>
        /// <param name="document">type of identification document: Nit or CI</param>
        public Customer(string name, string document)
        {
            _name = name;
            _document = document;
        }
        /// <summary>
        ///     Setters and Getters of the private fields
        /// </summary>
        public string Name { get => _name; set => _name = value; }
        public string Document { get => _document; set => _document = value; }
    }
}
