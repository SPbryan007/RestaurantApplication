using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApplicationClassLibrary.Product
{
    public class Category
    {
        private string _name;
        public Category(string name)
        {
            _name = name;
        }
        public string Name { get => _name; set => _name = value; }
    }

    public class Product
    {
        private string _name;
        private double _price;
        private string _description;
        private Category _category;
        public Product(string name, double price, string description, Category category)
        {
            _name = name;
            _price = price;
            _description = description;
            _category = category;
        }
        public string Name { get => _name; set => _name = value; }
        public double Price { get => _price; set => _price = value; }
        public string Description { get => _description; set => _description = value; }
        internal Category Category { get => _category; set => _category = value; }
    }
}
