using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Sales : Form
    {

        private BO.Sale? selectedSale = null;

        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        public Sales()
        {
            InitializeComponent();
            dataGridViewSale.DataSource = s_bl.Sale.ReadAll();
            panelSale.Visible = false;
        }

        private void Sales_Load(object sender, EventArgs e)
        {
        }

        private void panelSale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSaveSale_Click(object sender, EventArgs e)
        {
            var updatedSale = new BO.Sale(
                  int.Parse(textBoxNumIdentify.Text),
                  int.Parse(textBoxNumIdentifyProduct.Text),
                  int.Parse(textBoxCountForSale.Text),
                  int.Parse(textBoxPriceInSale.Text),
                  checkBoxAllCustomers.Checked,
                  dateTimePickerDateStartSale.Value,
                  dateTimePickerDateEndSale.Value
              );

            if (selectedSale != null)
            {
                s_bl.Sale.Update(updatedSale); 
                selectedSale = null; 
            }
            else
            {
                s_bl.Sale.Create(updatedSale); 
            }

            dataGridViewSale.DataSource = s_bl.Sale.ReadAll();
            MessageBox.Show(s_bl.Sale.ReadAll().Count().ToString());

            panelSale.Visible = false;
            textBoxNumIdentify.Enabled = true;
            textBoxNumIdentifyProduct.Enabled = true;

        }
        private void dataGridViewSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonAddSale_Click(object sender, EventArgs e)
        {
            panelSale.Visible = true;
        }

        private void buttonUpdateSale_Click(object sender, EventArgs e)
        {
            if (dataGridViewSale.CurrentRow == null)
            {
                MessageBox.Show("אנא בחר מבצע");
                return;
            }

            selectedSale = (BO.Sale)dataGridViewSale.CurrentRow.DataBoundItem;

            textBoxNumIdentify.Text = selectedSale.NumIdentify.ToString();
            textBoxNumIdentifyProduct.Text = selectedSale.NumIdentifyProduct.ToString();
            textBoxCountForSale.Text = selectedSale.CountForSale.ToString();
            textBoxPriceInSale.Text = selectedSale.NumIdentifyProduct.ToString();
            checkBoxAllCustomers.Text = selectedSale.AllCustomers.ToString();
            dateTimePickerDateStartSale.Text = selectedSale.DateStartSale.ToString();
            dateTimePickerDateEndSale.Text = selectedSale.DateEndSale.ToString();
            textBoxNumIdentify.Enabled = false;

            panelSale.Visible = true;
        }

        private void buttonDeleteSale_Click(object sender, EventArgs e)
        {
            if (dataGridViewSale.CurrentRow == null)
            {
                MessageBox.Show("אנא בחר מבצע למחיקה");
                return;
            }

            selectedSale = (BO.Sale)dataGridViewSale.CurrentRow.DataBoundItem;

            var confirmResult = MessageBox.Show("האם אתה בטוח שברצונך למחוק את המבצע?",
                                                 "אישור מחיקה",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                s_bl.Sale.Delete(selectedSale.NumIdentify);

                dataGridViewSale.DataSource = s_bl.Sale.ReadAll();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            this.Hide();
            manager.Show();
        }

        private void dataGridViewSale_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
