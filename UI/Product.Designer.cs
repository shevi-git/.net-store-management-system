namespace UI
{
    partial class Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelProduct = new Panel();
            numericUpDownCountStock = new NumericUpDown();
            CountStock = new Label();
            numericUpDownPrice = new NumericUpDown();
            comboBoxCategory = new ComboBox();
            buttonSaveProduct = new Button();
            textBoxName = new TextBox();
            TextBoxId = new TextBox();
            labelPrice = new Label();
            labelCategory = new Label();
            labelNameName = new Label();
            labelId = new Label();
            dataGridViewProduct = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            CountStock1 = new DataGridViewTextBoxColumn();
            buttonDeleteProduct = new Button();
            buttonUpdateProduct = new Button();
            buttonAddProduct = new Button();
            buttonBack = new Button();
            panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // panelProduct
            // 
            panelProduct.Controls.Add(numericUpDownCountStock);
            panelProduct.Controls.Add(CountStock);
            panelProduct.Controls.Add(numericUpDownPrice);
            panelProduct.Controls.Add(comboBoxCategory);
            panelProduct.Controls.Add(buttonSaveProduct);
            panelProduct.Controls.Add(textBoxName);
            panelProduct.Controls.Add(TextBoxId);
            panelProduct.Controls.Add(labelPrice);
            panelProduct.Controls.Add(labelCategory);
            panelProduct.Controls.Add(labelNameName);
            panelProduct.Controls.Add(labelId);
            panelProduct.Location = new Point(1, -44);
            panelProduct.Margin = new Padding(4, 4, 4, 4);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(650, 329);
            panelProduct.TabIndex = 9;
            // 
            // numericUpDownCountStock
            // 
            numericUpDownCountStock.Location = new Point(194, 240);
            numericUpDownCountStock.Margin = new Padding(4, 4, 4, 4);
            numericUpDownCountStock.Name = "numericUpDownCountStock";
            numericUpDownCountStock.Size = new Size(188, 31);
            numericUpDownCountStock.TabIndex = 12;
            // 
            // CountStock
            // 
            CountStock.AutoSize = true;
            CountStock.Location = new Point(408, 246);
            CountStock.Margin = new Padding(4, 0, 4, 0);
            CountStock.Name = "CountStock";
            CountStock.Size = new Size(105, 25);
            CountStock.TabIndex = 11;
            CountStock.Text = "כמות במלאי";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(194, 199);
            numericUpDownPrice.Margin = new Padding(4, 4, 4, 4);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(188, 31);
            numericUpDownPrice.TabIndex = 10;
            numericUpDownPrice.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "מוצרי_חלב", "ירקות", "פירות", "שימורים" });
            comboBoxCategory.Location = new Point(192, 155);
            comboBoxCategory.Margin = new Padding(4, 4, 4, 4);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(188, 33);
            comboBoxCategory.TabIndex = 9;
            // 
            // buttonSaveProduct
            // 
            buttonSaveProduct.Location = new Point(238, 292);
            buttonSaveProduct.Margin = new Padding(4, 4, 4, 4);
            buttonSaveProduct.Name = "buttonSaveProduct";
            buttonSaveProduct.Size = new Size(118, 36);
            buttonSaveProduct.TabIndex = 8;
            buttonSaveProduct.Text = "אישור";
            buttonSaveProduct.UseVisualStyleBackColor = true;
            buttonSaveProduct.Click += buttonSaveProduct_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(225, 114);
            textBoxName.Margin = new Padding(4, 4, 4, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(155, 31);
            textBoxName.TabIndex = 5;
            // 
            // TextBoxId
            // 
            TextBoxId.Location = new Point(225, 72);
            TextBoxId.Margin = new Padding(4, 4, 4, 4);
            TextBoxId.Name = "TextBoxId";
            TextBoxId.Size = new Size(155, 31);
            TextBoxId.TabIndex = 4;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(418, 199);
            labelPrice.Margin = new Padding(4, 0, 4, 0);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(51, 25);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "מחיר";
            // 
            // labelCategory
            // 
            labelCategory.AutoSize = true;
            labelCategory.Location = new Point(408, 162);
            labelCategory.Margin = new Padding(4, 0, 4, 0);
            labelCategory.Name = "labelCategory";
            labelCategory.Size = new Size(76, 25);
            labelCategory.TabIndex = 2;
            labelCategory.Text = "קטגוריה";
            // 
            // labelNameName
            // 
            labelNameName.AutoSize = true;
            labelNameName.Location = new Point(389, 112);
            labelNameName.Margin = new Padding(4, 0, 4, 0);
            labelNameName.Name = "labelNameName";
            labelNameName.Size = new Size(81, 25);
            labelNameName.TabIndex = 1;
            labelNameName.Text = "שם מוצר";
            // 
            // labelId
            // 
            labelId.AutoSize = true;
            labelId.Location = new Point(434, 72);
            labelId.Margin = new Padding(4, 0, 4, 0);
            labelId.Name = "labelId";
            labelId.Size = new Size(97, 25);
            labelId.TabIndex = 0;
            labelId.Text = "מזהה מוצר";
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Columns.AddRange(new DataGridViewColumn[] { Id, Name, Category, Price, CountStock1 });
            dataGridViewProduct.Location = new Point(18, 311);
            dataGridViewProduct.Margin = new Padding(4, 5, 4, 5);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowHeadersWidth = 51;
            dataGridViewProduct.Size = new Size(634, 250);
            dataGridViewProduct.TabIndex = 8;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "מזהה מוצר";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Name
            // 
            Name.DataPropertyName = "Name";
            Name.HeaderText = "שם מוצר";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // Category
            // 
            Category.DataPropertyName = "Category";
            Category.HeaderText = "קטגוריה";
            Category.MinimumWidth = 6;
            Category.Name = "Category";
            Category.Width = 125;
            // 
            // Price
            // 
            Price.DataPropertyName = "Price";
            Price.HeaderText = "מחיר";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.Width = 125;
            // 
            // CountStock1
            // 
            CountStock1.DataPropertyName = "CountStock";
            CountStock1.HeaderText = "כמות במלאי";
            CountStock1.MinimumWidth = 6;
            CountStock1.Name = "CountStock1";
            CountStock1.Width = 125;
            // 
            // buttonDeleteProduct
            // 
            buttonDeleteProduct.Location = new Point(948, 436);
            buttonDeleteProduct.Margin = new Padding(4, 5, 4, 5);
            buttonDeleteProduct.Name = "buttonDeleteProduct";
            buttonDeleteProduct.Size = new Size(188, 161);
            buttonDeleteProduct.TabIndex = 7;
            buttonDeleteProduct.Text = "מחיקה";
            buttonDeleteProduct.UseVisualStyleBackColor = true;
            buttonDeleteProduct.Click += buttonDeleteProduct_Click;
            // 
            // buttonUpdateProduct
            // 
            buttonUpdateProduct.Location = new Point(948, 249);
            buttonUpdateProduct.Margin = new Padding(4, 5, 4, 5);
            buttonUpdateProduct.Name = "buttonUpdateProduct";
            buttonUpdateProduct.Size = new Size(188, 165);
            buttonUpdateProduct.TabIndex = 6;
            buttonUpdateProduct.Text = "עדכון";
            buttonUpdateProduct.UseVisualStyleBackColor = true;
            buttonUpdateProduct.Click += buttonUpdateProduct_Click;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(948, 39);
            buttonAddProduct.Margin = new Padding(4, 5, 4, 5);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(188, 186);
            buttonAddProduct.TabIndex = 5;
            buttonAddProduct.Text = "הוספה";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(728, 70);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(159, 71);
            buttonBack.TabIndex = 10;
            buttonBack.Text = "חזרה לעמוד הקודם";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1268, 672);
            Controls.Add(buttonBack);
            Controls.Add(panelProduct);
            Controls.Add(dataGridViewProduct);
            Controls.Add(buttonDeleteProduct);
            Controls.Add(buttonUpdateProduct);
            Controls.Add(buttonAddProduct);
            Margin = new Padding(4, 4, 4, 4);
            //Name = "Product";
            Text = "Product";
            Load += Product_Load;
            panelProduct.ResumeLayout(false);
            panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelProduct;
        private Button buttonSaveProduct;
        private TextBox textBoxPhone;
        private TextBox textBoxName;
        private TextBox TextBoxId;
        private Label labelPrice;
        private Label labelCategory;
        private Label labelNameName;
        private Label labelId;
        private DataGridView dataGridViewProduct;
        private DataGridViewTextBoxColumn NameCustomers;
        private DataGridViewTextBoxColumn Tz;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private Button buttonDeleteProduct;
        private Button buttonUpdateProduct;
        private Button buttonAddProduct;
        private ComboBox comboBoxCategory;
        private NumericUpDown numericUpDownPrice;
        private NumericUpDown numericUpDownCountStock;
        private Label CountStock;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn CountStock1;
        private Button buttonBack;
    }
}