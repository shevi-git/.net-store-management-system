using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BO;
using Dal;

namespace UI
{
    public partial class Manager : Form
    {


        public Manager()
        {
            InitializeComponent();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            this.Hide();
            customer.Show();
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            Sales sale = new Sales();
            this.Hide();
            sale.Show();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            this.Hide();
            product.Show();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
        }
    }
}
