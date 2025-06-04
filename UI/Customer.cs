using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Customer : Form
    {
        private BO.Customer? selectedCustomer = null;

        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        public Customer()
        {
            InitializeComponent();
            dataGridView1.DataSource = s_bl.Customers.ReadAll();
            panelCustomer.Visible = false;
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            panelCustomer.Visible = true;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("אנא בחר לקוח לעדכון");
                return;
            }

            selectedCustomer = (BO.Customer)dataGridView1.CurrentRow.DataBoundItem;

            TextBoxTz.Text = selectedCustomer.Tz.ToString();
            textBoxNameCustomers.Text = selectedCustomer.NameCustomers;
            textBoxAddress.Text = selectedCustomer.Address;
            textBoxPhone.Text = selectedCustomer.Phone.ToString();

            TextBoxTz.Enabled = false;

            panelCustomer.Visible = true;
        }



        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("אנא בחר לקוח למחיקה");
                return;
            }

            selectedCustomer = (BO.Customer)dataGridView1.CurrentRow.DataBoundItem;

            var confirmResult = MessageBox.Show("האם אתה בטוח שברצונך למחוק את הלקוח?",
                                                 "אישור מחיקה",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                s_bl.Customers.Delete(selectedCustomer.Tz);

                dataGridView1.DataSource = s_bl.Customers.ReadAll();
            }
        }


        private void buttonSaveCustomer_Click(object sender, EventArgs e)
        {
            var updatedCustomer = new BO.Customer(
                int.Parse(TextBoxTz.Text),
                textBoxNameCustomers.Text,
                textBoxAddress.Text,
                int.Parse(textBoxPhone.Text)
            );

            if (selectedCustomer != null)
            {
                s_bl.Customers.Update(updatedCustomer);
                selectedCustomer = null;
            }
            else
            {
                s_bl.Customers.Create(updatedCustomer);
            }

            dataGridView1.DataSource = s_bl.Customers.ReadAll();
            panelCustomer.Visible = false;
            TextBoxTz.Enabled = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            this.Hide();
            manager.Show();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
        }
    }
}
