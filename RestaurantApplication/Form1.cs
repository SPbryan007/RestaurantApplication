using RestaurantApplicationClassLibrary;
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
    public partial class Form1 : Form
    {
        private CustomerRepository _customerRepository;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this._customerRepository = new CustomerRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdersForm order_form = new OrdersForm();
            order_form.ShowDialog();
            Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomersForm form = new CustomersForm(new CustomerRepository());
            form.ShowDialog();
            Refresh();
        }
    }
}
