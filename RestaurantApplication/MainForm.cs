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
    public partial class MainForm : Form
    {
        private CustomerRepository _customerRepository;
        public MainForm()
        {
            this._customerRepository = new CustomerRepository();
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomersForm form = new CustomersForm(new CustomerRepository());
            form.ShowDialog();
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdersForm order_form = new OrdersForm();
            order_form.ShowDialog();
            Refresh();
        }
    }
}
