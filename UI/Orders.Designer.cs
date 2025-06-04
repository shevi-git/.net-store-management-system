namespace UI
{
    partial class Orders
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
            buttonDeleteOrder = new Button();
            numericUpDownAmount = new NumericUpDown();
            labelAmount = new Label();
            comboBoxProduct = new ComboBox();
            buttonAddProduct = new Button();
            listBoxProduct = new ListBox();
            buttonSaveOrder = new Button();
            labelTotalPrice = new Label();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteOrder
            // 
            buttonDeleteOrder.Location = new Point(261, 300);
            buttonDeleteOrder.Margin = new Padding(4, 5, 4, 5);
            buttonDeleteOrder.Name = "buttonDeleteOrder";
            buttonDeleteOrder.Size = new Size(303, 125);
            buttonDeleteOrder.TabIndex = 7;
            buttonDeleteOrder.Text = "מחיקה מוצר";
            buttonDeleteOrder.UseVisualStyleBackColor = true;
            buttonDeleteOrder.Click += buttonDeleteOrder_Click;
            // 
            // numericUpDownAmount
            // 
            numericUpDownAmount.Location = new Point(820, 224);
            numericUpDownAmount.Name = "numericUpDownAmount";
            numericUpDownAmount.Size = new Size(289, 31);
            numericUpDownAmount.TabIndex = 10;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(1057, 156);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(52, 25);
            labelAmount.TabIndex = 11;
            labelAmount.Text = "כמות";
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(820, 289);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(289, 33);
            comboBoxProduct.TabIndex = 12;
            comboBoxProduct.SelectedIndexChanged += comboBoxProduct_SelectedIndexChanged;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(820, 378);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(289, 47);
            buttonAddProduct.TabIndex = 13;
            buttonAddProduct.Text = "הוספת מוצר";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // listBoxProduct
            // 
            listBoxProduct.FormattingEnabled = true;
            listBoxProduct.ItemHeight = 25;
            listBoxProduct.Location = new Point(139, 48);
            listBoxProduct.Name = "listBoxProduct";
            listBoxProduct.Size = new Size(558, 229);
            listBoxProduct.TabIndex = 14;
            listBoxProduct.SelectedIndexChanged += listBoxProduct_SelectedIndexChanged;
            // 
            // buttonSaveOrder
            // 
            buttonSaveOrder.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveOrder.Location = new Point(298, 463);
            buttonSaveOrder.Name = "buttonSaveOrder";
            buttonSaveOrder.Size = new Size(608, 124);
            buttonSaveOrder.TabIndex = 15;
            buttonSaveOrder.Text = "אישור הזמנה";
            buttonSaveOrder.UseVisualStyleBackColor = true;
            buttonSaveOrder.Click += buttonSaveOrder_Click_1;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(118, 350);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(0, 25);
            labelTotalPrice.TabIndex = 16;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(985, 12);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(159, 71);
            buttonBack.TabIndex = 17;
            buttonBack.Text = "חזרה לעמוד הקודם";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // Orders
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 634);
            Controls.Add(buttonBack);
            Controls.Add(labelTotalPrice);
            Controls.Add(buttonSaveOrder);
            Controls.Add(listBoxProduct);
            Controls.Add(buttonAddProduct);
            Controls.Add(comboBoxProduct);
            Controls.Add(labelAmount);
            Controls.Add(numericUpDownAmount);
            Controls.Add(buttonDeleteOrder);
            Margin = new Padding(4);
            Name = "Orders";
            Text = "Orders";
            Load += Orders_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDeleteOrder;
        private NumericUpDown numericUpDownAmount;
        private Label labelAmount;
        private ComboBox comboBoxProduct;
        private Button buttonAddProduct;
        private ListBox listBoxProduct;
        private Button buttonSaveOrder;
        private Label labelTotalPrice;
        private Button buttonBack;
    }
}