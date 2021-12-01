using RestaurantApplicationClassLibrary;
using RestaurantApplicationClassLibrary.Helpers.Validation;
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
    public partial class CustomersForm : Form
    {
        private readonly CustomerRepository _repository;

        public CustomersForm(CustomerRepository repository)
        {
            InitializeComponent();
            this._repository = repository;
            dg_show_customers.DataSource = this._repository.GetAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void onClick_btn_register(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            
            Customer customer = new Customer(txt_name.Text, txt_document.Text);
            CustomerValidation validation = new CustomerValidation(new ClassValidator<Customer>(customer));
            ValidationResult isValid = validation.Validate();
            if (isValid.Errors.Count >= 1)
            {
                MessageBox.Show(isValid.Errors.First().message);
            }
            else
            {
                this._repository.Save(customer);
                this.ResetFields();
                Refresh();
            }


        }

        private void ResetFields()
        {
            txt_document.Clear();
            txt_name.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
