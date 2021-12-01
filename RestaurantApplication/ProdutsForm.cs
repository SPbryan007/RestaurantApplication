using RestaurantApplicationClassLibrary;
using RestaurantApplicationClassLibrary.Helpers.Validation;
using RestaurantApplicationClassLibrary.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApplication
{
    public partial class ProdutsForm : Form
    {
        private List<Category> _categories;
        private ProductRepository repository;
        public ProdutsForm(ProductRepository repository)
        {
            InitializeComponent();
            this.repository = repository;
            _categories = new List<Category>()
            {
                new Category("Dishes"),
                new Category("Drinks"),
            };
            cbx_category.DataSource = _categories;
            cbx_category.DisplayMember = "name";
            cbx_category.ValueMember = "name";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = _categories.Find(i => i.Name == cbx_category.SelectedItem.ToString());
            double price = Convert.ToDouble(txt_price.Text);
            Product product = new Product(txt_name.Text, price, rtxt_description.Text,item);

            ProductValidation validation = new ProductValidation(new ClassValidator<Product>(product));
            ValidationResult isValid = validation.Validate();
            if (isValid.Errors.Count >= 1)
            {
                MessageBox.Show(isValid.Errors.First().message);
            }
            else
            {
                this.repository.Save(product);
                this.ResetFields();
                Refresh();
            }

        }

        private void ResetFields()
        {
            txt_name.Clear();
            txt_price.Clear();
            rtxt_description.Clear();
        }
        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProdutsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
