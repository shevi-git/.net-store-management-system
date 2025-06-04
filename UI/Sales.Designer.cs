namespace UI
{
    partial class Sales
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
            buttonDeleteSale = new Button();
            buttonUpdateSale = new Button();
            buttonAddSale = new Button();
            panelSale = new Panel();
            dateTimePickerDateEndSale = new DateTimePicker();
            dateTimePickerDateStartSale = new DateTimePicker();
            labelDateEndSale = new Label();
            labelDateStartSale = new Label();
            checkBoxAllCustomers = new CheckBox();
            labelAllCustomers = new Label();
            buttonSaveSale = new Button();
            textBoxPriceInSale = new TextBox();
            textBoxCountForSale = new TextBox();
            textBoxNumIdentifyProduct = new TextBox();
            textBoxNumIdentify = new TextBox();
            labelPriceInSale = new Label();
            labelCountForSale = new Label();
            labelNumIdentifyProduct = new Label();
            labelNumIdentify = new Label();
            dataGridViewSale = new DataGridView();
            CountForSale = new DataGridViewTextBoxColumn();
            PriceInSale = new DataGridViewTextBoxColumn();
            AllCustomers = new DataGridViewTextBoxColumn();
            DateStartSale = new DataGridViewTextBoxColumn();
            DateEndSale = new DataGridViewTextBoxColumn();
            NumIdentifyProduct = new DataGridViewTextBoxColumn();
            NumIdentify = new DataGridViewTextBoxColumn();
            buttonBack = new Button();
            panelSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSale).BeginInit();
            SuspendLayout();
            // 
            // buttonDeleteSale
            // 
            buttonDeleteSale.Location = new Point(1186, 452);
            buttonDeleteSale.Margin = new Padding(4, 5, 4, 5);
            buttonDeleteSale.Name = "buttonDeleteSale";
            buttonDeleteSale.Size = new Size(188, 161);
            buttonDeleteSale.TabIndex = 7;
            buttonDeleteSale.Text = "מחיקה";
            buttonDeleteSale.UseVisualStyleBackColor = true;
            buttonDeleteSale.Click += buttonDeleteSale_Click;
            // 
            // buttonUpdateSale
            // 
            buttonUpdateSale.Location = new Point(1186, 258);
            buttonUpdateSale.Margin = new Padding(4, 5, 4, 5);
            buttonUpdateSale.Name = "buttonUpdateSale";
            buttonUpdateSale.Size = new Size(188, 165);
            buttonUpdateSale.TabIndex = 6;
            buttonUpdateSale.Text = "עדכון";
            buttonUpdateSale.UseVisualStyleBackColor = true;
            buttonUpdateSale.Click += buttonUpdateSale_Click;
            // 
            // buttonAddSale
            // 
            buttonAddSale.Location = new Point(1186, 41);
            buttonAddSale.Margin = new Padding(4, 5, 4, 5);
            buttonAddSale.Name = "buttonAddSale";
            buttonAddSale.Size = new Size(188, 186);
            buttonAddSale.TabIndex = 5;
            buttonAddSale.Text = "הוספה";
            buttonAddSale.UseVisualStyleBackColor = true;
            buttonAddSale.Click += buttonAddSale_Click;
            // 
            // panelSale
            // 
            panelSale.Controls.Add(dateTimePickerDateEndSale);
            panelSale.Controls.Add(dateTimePickerDateStartSale);
            panelSale.Controls.Add(labelDateEndSale);
            panelSale.Controls.Add(labelDateStartSale);
            panelSale.Controls.Add(checkBoxAllCustomers);
            panelSale.Controls.Add(labelAllCustomers);
            panelSale.Controls.Add(buttonSaveSale);
            panelSale.Controls.Add(textBoxPriceInSale);
            panelSale.Controls.Add(textBoxCountForSale);
            panelSale.Controls.Add(textBoxNumIdentifyProduct);
            panelSale.Controls.Add(textBoxNumIdentify);
            panelSale.Controls.Add(labelPriceInSale);
            panelSale.Controls.Add(labelCountForSale);
            panelSale.Controls.Add(labelNumIdentifyProduct);
            panelSale.Controls.Add(labelNumIdentify);
            panelSale.Location = new Point(292, 15);
            panelSale.Margin = new Padding(4);
            panelSale.Name = "panelSale";
            panelSale.Size = new Size(720, 365);
            panelSale.TabIndex = 10;
            // 
            // dateTimePickerDateEndSale
            // 
            dateTimePickerDateEndSale.Location = new Point(86, 316);
            dateTimePickerDateEndSale.Margin = new Padding(4);
            dateTimePickerDateEndSale.Name = "dateTimePickerDateEndSale";
            dateTimePickerDateEndSale.Size = new Size(312, 31);
            dateTimePickerDateEndSale.TabIndex = 14;
            // 
            // dateTimePickerDateStartSale
            // 
            dateTimePickerDateStartSale.Location = new Point(86, 275);
            dateTimePickerDateStartSale.Margin = new Padding(4);
            dateTimePickerDateStartSale.Name = "dateTimePickerDateStartSale";
            dateTimePickerDateStartSale.Size = new Size(312, 31);
            dateTimePickerDateStartSale.TabIndex = 13;
            // 
            // labelDateEndSale
            // 
            labelDateEndSale.AutoSize = true;
            labelDateEndSale.Location = new Point(418, 315);
            labelDateEndSale.Margin = new Padding(4, 0, 4, 0);
            labelDateEndSale.Name = "labelDateEndSale";
            labelDateEndSale.Size = new Size(161, 25);
            labelDateEndSale.TabIndex = 12;
            labelDateEndSale.Text = "תאריך סיום המבצע";
            // 
            // labelDateStartSale
            // 
            labelDateStartSale.AutoSize = true;
            labelDateStartSale.Location = new Point(418, 280);
            labelDateStartSale.Margin = new Padding(4, 0, 4, 0);
            labelDateStartSale.Name = "labelDateStartSale";
            labelDateStartSale.Size = new Size(187, 25);
            labelDateStartSale.TabIndex = 11;
            labelDateStartSale.Text = "תאריך התחלת המבצע";
            // 
            // checkBoxAllCustomers
            // 
            checkBoxAllCustomers.AutoSize = true;
            checkBoxAllCustomers.Location = new Point(359, 246);
            checkBoxAllCustomers.Margin = new Padding(4);
            checkBoxAllCustomers.Name = "checkBoxAllCustomers";
            checkBoxAllCustomers.Size = new Size(15, 14);
            checkBoxAllCustomers.TabIndex = 10;
            checkBoxAllCustomers.UseVisualStyleBackColor = true;
            // 
            // labelAllCustomers
            // 
            labelAllCustomers.AutoSize = true;
            labelAllCustomers.Location = new Point(418, 246);
            labelAllCustomers.Margin = new Padding(4, 0, 4, 0);
            labelAllCustomers.Name = "labelAllCustomers";
            labelAllCustomers.Size = new Size(151, 25);
            labelAllCustomers.TabIndex = 9;
            labelAllCustomers.Text = "משתתפים במבצע";
            // 
            // buttonSaveSale
            // 
            buttonSaveSale.Location = new Point(35, 151);
            buttonSaveSale.Margin = new Padding(4);
            buttonSaveSale.Name = "buttonSaveSale";
            buttonSaveSale.Size = new Size(118, 36);
            buttonSaveSale.TabIndex = 8;
            buttonSaveSale.Text = "אישור";
            buttonSaveSale.UseVisualStyleBackColor = true;
            buttonSaveSale.Click += buttonSaveSale_Click;
            // 
            // textBoxPriceInSale
            // 
            textBoxPriceInSale.Location = new Point(225, 195);
            textBoxPriceInSale.Margin = new Padding(4);
            textBoxPriceInSale.Name = "textBoxPriceInSale";
            textBoxPriceInSale.Size = new Size(155, 31);
            textBoxPriceInSale.TabIndex = 7;
            // 
            // textBoxCountForSale
            // 
            textBoxCountForSale.Location = new Point(225, 154);
            textBoxCountForSale.Margin = new Padding(4);
            textBoxCountForSale.Name = "textBoxCountForSale";
            textBoxCountForSale.Size = new Size(155, 31);
            textBoxCountForSale.TabIndex = 6;
            // 
            // textBoxNumIdentifyProduct
            // 
            textBoxNumIdentifyProduct.Location = new Point(225, 114);
            textBoxNumIdentifyProduct.Margin = new Padding(4);
            textBoxNumIdentifyProduct.Name = "textBoxNumIdentifyProduct";
            textBoxNumIdentifyProduct.Size = new Size(155, 31);
            textBoxNumIdentifyProduct.TabIndex = 5;
            // 
            // textBoxNumIdentify
            // 
            textBoxNumIdentify.Location = new Point(225, 72);
            textBoxNumIdentify.Margin = new Padding(4);
            textBoxNumIdentify.Name = "textBoxNumIdentify";
            textBoxNumIdentify.Size = new Size(155, 31);
            textBoxNumIdentify.TabIndex = 4;
            // 
            // labelPriceInSale
            // 
            labelPriceInSale.AutoSize = true;
            labelPriceInSale.Location = new Point(472, 204);
            labelPriceInSale.Margin = new Padding(4, 0, 4, 0);
            labelPriceInSale.Name = "labelPriceInSale";
            labelPriceInSale.Size = new Size(100, 25);
            labelPriceInSale.TabIndex = 3;
            labelPriceInSale.Text = "מחיר מבצע";
            // 
            // labelCountForSale
            // 
            labelCountForSale.AutoSize = true;
            labelCountForSale.Location = new Point(461, 162);
            labelCountForSale.Margin = new Padding(4, 0, 4, 0);
            labelCountForSale.Name = "labelCountForSale";
            labelCountForSale.Size = new Size(111, 25);
            labelCountForSale.TabIndex = 2;
            labelCountForSale.Text = "כמות למבצע";
            // 
            // labelNumIdentifyProduct
            // 
            labelNumIdentifyProduct.AutoSize = true;
            labelNumIdentifyProduct.Location = new Point(476, 118);
            labelNumIdentifyProduct.Margin = new Padding(4, 0, 4, 0);
            labelNumIdentifyProduct.Name = "labelNumIdentifyProduct";
            labelNumIdentifyProduct.Size = new Size(97, 25);
            labelNumIdentifyProduct.TabIndex = 1;
            labelNumIdentifyProduct.Text = "מזהה מוצר";
            // 
            // labelNumIdentify
            // 
            labelNumIdentify.AutoSize = true;
            labelNumIdentify.Location = new Point(479, 72);
            labelNumIdentify.Margin = new Padding(4, 0, 4, 0);
            labelNumIdentify.Name = "labelNumIdentify";
            labelNumIdentify.Size = new Size(95, 25);
            labelNumIdentify.TabIndex = 0;
            labelNumIdentify.Text = "מזהה יחודי";
            // 
            // dataGridViewSale
            // 
            dataGridViewSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSale.Columns.AddRange(new DataGridViewColumn[] { CountForSale, PriceInSale, AllCustomers, DateStartSale, DateEndSale, NumIdentifyProduct, NumIdentify });
            dataGridViewSale.Location = new Point(98, 388);
            dataGridViewSale.Margin = new Padding(4);
            dataGridViewSale.Name = "dataGridViewSale";
            dataGridViewSale.RowHeadersWidth = 51;
            dataGridViewSale.Size = new Size(925, 235);
            dataGridViewSale.TabIndex = 15;
            dataGridViewSale.CellContentClick += dataGridViewSale_CellContentClick_1;
            // 
            // CountForSale
            // 
            CountForSale.DataPropertyName = "CountForSale";
            CountForSale.HeaderText = "כמות למוצר";
            CountForSale.MinimumWidth = 6;
            CountForSale.Name = "CountForSale";
            CountForSale.Width = 125;
            // 
            // PriceInSale
            // 
            PriceInSale.DataPropertyName = "PriceInSale";
            PriceInSale.HeaderText = "מחיר למבצע";
            PriceInSale.MinimumWidth = 6;
            PriceInSale.Name = "PriceInSale";
            PriceInSale.Width = 125;
            // 
            // AllCustomers
            // 
            AllCustomers.DataPropertyName = "AllCustomers";
            AllCustomers.HeaderText = "משתתפים במבצע";
            AllCustomers.MinimumWidth = 6;
            AllCustomers.Name = "AllCustomers";
            AllCustomers.Width = 125;
            // 
            // DateStartSale
            // 
            DateStartSale.DataPropertyName = "DateStartSale";
            DateStartSale.HeaderText = "תאריך התחלת המבצע";
            DateStartSale.MinimumWidth = 6;
            DateStartSale.Name = "DateStartSale";
            DateStartSale.Width = 125;
            // 
            // DateEndSale
            // 
            DateEndSale.DataPropertyName = "DateEndSale";
            DateEndSale.HeaderText = "תאריך סיום המבצע";
            DateEndSale.MinimumWidth = 6;
            DateEndSale.Name = "DateEndSale";
            DateEndSale.Width = 125;
            // 
            // NumIdentifyProduct
            // 
            NumIdentifyProduct.DataPropertyName = "NumIdentifyProduct";
            NumIdentifyProduct.HeaderText = "מזהה מוצר";
            NumIdentifyProduct.MinimumWidth = 6;
            NumIdentifyProduct.Name = "NumIdentifyProduct";
            NumIdentifyProduct.Width = 125;
            // 
            // NumIdentify
            // 
            NumIdentify.DataPropertyName = "NumIdentify";
            NumIdentify.HeaderText = "מזהה ייחודי";
            NumIdentify.MinimumWidth = 6;
            NumIdentify.Name = "NumIdentify";
            NumIdentify.Width = 125;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(1019, 41);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(159, 71);
            buttonBack.TabIndex = 16;
            buttonBack.Text = "חזרה לעמוד הקודם";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // Sales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1436, 655);
            Controls.Add(buttonBack);
            Controls.Add(dataGridViewSale);
            Controls.Add(panelSale);
            Controls.Add(buttonDeleteSale);
            Controls.Add(buttonUpdateSale);
            Controls.Add(buttonAddSale);
            Margin = new Padding(4);
            Name = "Sales";
            Load += Sales_Load;
            panelSale.ResumeLayout(false);
            panelSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSale).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button buttonDeleteSale;
        private Button buttonUpdateSale;
        private Button buttonAddSale;
        private Panel panelSale;
        private DateTimePicker dateTimePickerDateEndSale;
        private DateTimePicker dateTimePickerDateStartSale;
        private Label labelDateEndSale;
        private Label labelDateStartSale;
        private CheckBox checkBoxAllCustomers;
        private Label labelAllCustomers;
        private Button buttonSaveSale;
        private TextBox textBoxPriceInSale;
        private TextBox textBoxCountForSale;
        private TextBox textBoxNumIdentifyProduct;
        private TextBox textBoxNumIdentify;
        private Label labelPriceInSale;
        private Label labelCountForSale;
        private Label labelNumIdentifyProduct;
        private Label labelNumIdentify;
        private DataGridView dataGridViewSale;
        private DataGridViewTextBoxColumn CountForSale;
        private DataGridViewTextBoxColumn PriceInSale;
        private DataGridViewTextBoxColumn AllCustomers;
        private DataGridViewTextBoxColumn DateStartSale;
        private DataGridViewTextBoxColumn DateEndSale;
        private DataGridViewTextBoxColumn NumIdentifyProduct;
        private DataGridViewTextBoxColumn NumIdentify;
        private Button buttonBack;
    }
}