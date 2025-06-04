using BlApi;
using BO;
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
    public partial class Orders : Form
    {
        int idProduct = 0;
        private BO.Order? selectedOrder = null;

        private BO.Order currentOrder = new BO.Order() { productlist = new List<BO.PrductInOrder>() };

        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        public Orders()
        {
            InitializeComponent();

        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {


        }


        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {

        }

        //private void buttonDeleteOrder_Click(object sender, EventArgs e)
        //{
        //    if (listBoxProduct.SelectedItem == null)
        //    {
        //        MessageBox.Show("אנא בחר מוצר למחיקה");
        //        return;
        //    }
        //    listBoxProduct.Items.Remove(listBoxProduct.SelectedItem);

        //}
        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (listBoxProduct.SelectedItem == null)
            {
                MessageBox.Show("אנא בחר מוצר למחיקה");
                return;
            }

            string selectedLine = listBoxProduct.SelectedItem.ToString();

            // חילוץ שם המוצר מהשורה הנבחרת
            string productName = selectedLine.Split('|')[0].Replace("שם:", "").Trim();

            // מחיקת המוצר מהרשימה הפנימית של ההזמנה
            var productToRemove = currentOrder.productlist
                .FirstOrDefault(p => p.name == productName);

            if (productToRemove != null)
            {
                currentOrder.productlist.Remove(productToRemove);
            }

            // מחיקת התצוגה מה-ListBox
            listBoxProduct.Items.Remove(listBoxProduct.SelectedItem);

            // עדכון מחיר כולל
            currentOrder.price = currentOrder.productlist.Sum(p => p.price);
            UpdateTotalPrice();
        }


        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewListProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewListSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
        private void Orders_Load(object sender, EventArgs e)
        {
            var listProduct = s_bl.Product.ReadAll();

            var productDisplayList = listProduct
                .Select(p => new
                {
                    Id = p.Id,
                    Display = $"{p.Id} - ₪{p.Price:F2} - {p.Name}"
                })
                .ToList();

            comboBoxProduct.DataSource = productDisplayList;
            comboBoxProduct.DisplayMember = "Display";
            comboBoxProduct.ValueMember = "Id";
        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
 
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedValue is int selectedProductId)
            {
                try
                {
                    var salesList = s_bl.Order.AddProductToOrder(currentOrder, selectedProductId, (int)numericUpDownAmount.Value);

                    var addedProduct = currentOrder.productlist.FirstOrDefault(p => p.id == selectedProductId);
                    if (addedProduct != null)
                    {
                        for (int i = 0; i < listBoxProduct.Items.Count; i++)
                        {
                            if (listBoxProduct.Items[i].ToString().Contains($"שם: {addedProduct.name}"))
                            {
                                listBoxProduct.Items.RemoveAt(i);
                                break;
                            }
                        }

                        string line = $"שם: {addedProduct.name} | כמות: {addedProduct.count} | מחיר ליחידה: ₪{(addedProduct.price / addedProduct.count):F2} | מחיר כולל: ₪{addedProduct.price:F2}";
                        listBoxProduct.Items.Add(line);
                    }

                    UpdateTotalPrice();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"שגיאה בהוספת מוצר: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("לא נבחר מוצר תקין.");
            }
        }

        private void RefreshProductList()
        {
            listBoxProduct.Items.Clear();

            foreach (var item in currentOrder.productlist)
            {
                string line = $"שם: {item.name} | כמות: {item.count} | מחיר ליחידה: ₪{(item.price / item.count):F2} | מחיר כולל: ₪{item.price:F2}";
                listBoxProduct.Items.Add(line);
            }
        }


        private void UpdateTotalPrice()
        {
            labelTotalPrice.Text = currentOrder.price.ToString("0.00") + " ₪";
        }

        private void buttonSaveOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                s_bl.Order.DoOrder(currentOrder);
                MessageBox.Show("ההזמנה בוצעה בהצלחה!");
                currentOrder = new BO.Order() { productlist = new List<BO.PrductInOrder>() };
                RefreshProductList();
                UpdateTotalPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"אירעה שגיאה באישור ההזמנה: {ex.Message}");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
