using BO;
using Do;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Product : Form
    {
        private BO.Product? selectedProduct = null;

        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();

        public Product()
        {
            InitializeComponent();

            dataGridViewProduct.DataSource = s_bl.Product.ReadAll();
            panelProduct.Visible = false;
        }

        private void Product_Load(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            panelProduct.Visible = true;
        }

        private void buttonSaveProduct_Click(object sender, EventArgs e)
        {

            var updatedProduct = new BO.Product(
    int.Parse(TextBoxId.Text),
    textBoxName.Text,
    (BO.Category)comboBoxCategory.SelectedIndex,
    (double)numericUpDownPrice.Value,
    (int)numericUpDownCountStock.Value
);


            if (selectedProduct != null)
            {
                s_bl.Product.Update(updatedProduct);
                selectedProduct = null;
            }
            else
            {
                s_bl.Product.Create(updatedProduct);
            }

            dataGridViewProduct.DataSource = s_bl.Product.ReadAll();
            panelProduct.Visible = false;
            TextBoxId.Enabled = true;
        }


        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.CurrentRow == null)
            {
                MessageBox.Show("אנא בחר מוצר למחיקה");
                return;
            }

            selectedProduct = (BO.Product)dataGridViewProduct.CurrentRow.DataBoundItem;

            var confirmResult = MessageBox.Show("האם אתה בטוח שברצונך למחוק את המוצר?",
                                                 "אישור מחיקה",
                                                 MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                s_bl.Product.Delete(selectedProduct.Id);

                dataGridViewProduct.DataSource = s_bl.Product.ReadAll();
            }
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.CurrentRow == null)
            {
                MessageBox.Show("אנא בחר מוצר לעדכון");
                return;
            }

            selectedProduct = (BO.Product)dataGridViewProduct.CurrentRow.DataBoundItem;

            TextBoxId.Text = selectedProduct.Id.ToString();
            textBoxName.Text = selectedProduct.Name;
            comboBoxCategory.SelectedItem = selectedProduct.Category.ToString();
            numericUpDownPrice.Value = (decimal)selectedProduct.Price;
            numericUpDownCountStock.Value = selectedProduct.CountStock;

            TextBoxId.Enabled = false;

            panelProduct.Visible = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            this.Hide();
            manager.Show();
        }
    }
}
