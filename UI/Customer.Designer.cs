namespace UI
{
    partial class Customer
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
            buttonAddCustomer = new Button();
            buttonUpdateCustomer = new Button();
            buttonDeleteCustomer = new Button();
            dataGridView1 = new DataGridView();
            NameCustomers = new DataGridViewTextBoxColumn();
            Tz = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            panelCustomer = new Panel();
            buttonSaveCustomer = new Button();
            textBoxPhone = new TextBox();
            textBoxAddress = new TextBox();
            textBoxNameCustomers = new TextBox();
            TextBoxTz = new TextBox();
            labelPhone = new Label();
            labelAddress = new Label();
            labelNameCustomers = new Label();
            labelTz = new Label();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelCustomer.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Location = new Point(942, 105);
            buttonAddCustomer.Margin = new Padding(4, 5, 4, 5);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(188, 186);
            buttonAddCustomer.TabIndex = 0;
            buttonAddCustomer.Text = "הוספה";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // buttonUpdateCustomer
            // 
            buttonUpdateCustomer.Location = new Point(942, 301);
            buttonUpdateCustomer.Margin = new Padding(4, 5, 4, 5);
            buttonUpdateCustomer.Name = "buttonUpdateCustomer";
            buttonUpdateCustomer.Size = new Size(188, 165);
            buttonUpdateCustomer.TabIndex = 1;
            buttonUpdateCustomer.Text = "עדכון";
            buttonUpdateCustomer.UseVisualStyleBackColor = true;
            buttonUpdateCustomer.Click += buttonUpdateCustomer_Click;
            // 
            // buttonDeleteCustomer
            // 
            buttonDeleteCustomer.Location = new Point(942, 496);
            buttonDeleteCustomer.Margin = new Padding(4, 5, 4, 5);
            buttonDeleteCustomer.Name = "buttonDeleteCustomer";
            buttonDeleteCustomer.Size = new Size(188, 161);
            buttonDeleteCustomer.TabIndex = 2;
            buttonDeleteCustomer.Text = "מחיקה";
            buttonDeleteCustomer.UseVisualStyleBackColor = true;
            buttonDeleteCustomer.Click += buttonDeleteCustomer_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameCustomers, Tz, Address, Phone });
            dataGridView1.Location = new Point(171, 370);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(555, 317);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NameCustomers
            // 
            NameCustomers.DataPropertyName = "NameCustomers";
            NameCustomers.HeaderText = "שם";
            NameCustomers.MinimumWidth = 6;
            NameCustomers.Name = "NameCustomers";
            NameCustomers.Width = 125;
            // 
            // Tz
            // 
            Tz.DataPropertyName = "Tz";
            Tz.HeaderText = "ת\"ז";
            Tz.MinimumWidth = 6;
            Tz.Name = "Tz";
            Tz.Width = 125;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "כתובת";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 125;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "טלפון";
            Phone.MinimumWidth = 6;
            Phone.Name = "Phone";
            Phone.Width = 125;
            // 
            // panelCustomer
            // 
            panelCustomer.Controls.Add(buttonSaveCustomer);
            panelCustomer.Controls.Add(textBoxPhone);
            panelCustomer.Controls.Add(textBoxAddress);
            panelCustomer.Controls.Add(textBoxNameCustomers);
            panelCustomer.Controls.Add(TextBoxTz);
            panelCustomer.Controls.Add(labelPhone);
            panelCustomer.Controls.Add(labelAddress);
            panelCustomer.Controls.Add(labelNameCustomers);
            panelCustomer.Controls.Add(labelTz);
            panelCustomer.Location = new Point(34, 13);
            panelCustomer.Margin = new Padding(4);
            panelCustomer.Name = "panelCustomer";
            panelCustomer.Size = new Size(868, 348);
            panelCustomer.TabIndex = 4;
            // 
            // buttonSaveCustomer
            // 
            buttonSaveCustomer.Location = new Point(42, 79);
            buttonSaveCustomer.Margin = new Padding(4);
            buttonSaveCustomer.Name = "buttonSaveCustomer";
            buttonSaveCustomer.Size = new Size(174, 157);
            buttonSaveCustomer.TabIndex = 8;
            buttonSaveCustomer.Text = "אישור";
            buttonSaveCustomer.UseVisualStyleBackColor = true;
            buttonSaveCustomer.Click += buttonSaveCustomer_Click;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(288, 236);
            textBoxPhone.Margin = new Padding(4);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(273, 31);
            textBoxPhone.TabIndex = 7;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(288, 156);
            textBoxAddress.Margin = new Padding(4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(273, 31);
            textBoxAddress.TabIndex = 6;
            // 
            // textBoxNameCustomers
            // 
            textBoxNameCustomers.Location = new Point(288, 100);
            textBoxNameCustomers.Margin = new Padding(4);
            textBoxNameCustomers.Name = "textBoxNameCustomers";
            textBoxNameCustomers.Size = new Size(273, 31);
            textBoxNameCustomers.TabIndex = 5;
            // 
            // TextBoxTz
            // 
            TextBoxTz.Location = new Point(288, 42);
            TextBoxTz.Margin = new Padding(4);
            TextBoxTz.Name = "TextBoxTz";
            TextBoxTz.Size = new Size(273, 31);
            TextBoxTz.TabIndex = 4;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPhone.Location = new Point(680, 242);
            labelPhone.Margin = new Padding(4, 0, 4, 0);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(97, 45);
            labelPhone.TabIndex = 3;
            labelPhone.Text = "טלפון";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelAddress.Location = new Point(667, 170);
            labelAddress.Margin = new Padding(4, 0, 4, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(110, 45);
            labelAddress.TabIndex = 2;
            labelAddress.Text = "כתובת";
            // 
            // labelNameCustomers
            // 
            labelNameCustomers.AutoSize = true;
            labelNameCustomers.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNameCustomers.Location = new Point(631, 100);
            labelNameCustomers.Margin = new Padding(4, 0, 4, 0);
            labelNameCustomers.Name = "labelNameCustomers";
            labelNameCustomers.Size = new Size(146, 45);
            labelNameCustomers.TabIndex = 1;
            labelNameCustomers.Text = "שם לקוח";
            // 
            // labelTz
            // 
            labelTz.AutoSize = true;
            labelTz.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTz.Location = new Point(710, 28);
            labelTz.Margin = new Padding(4, 0, 4, 0);
            labelTz.Name = "labelTz";
            labelTz.Size = new Size(67, 45);
            labelTz.TabIndex = 0;
            labelTz.Text = "ת\"ז";
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(971, 15);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(159, 71);
            buttonBack.TabIndex = 5;
            buttonBack.Text = "חזרה לעמוד הקודם";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 750);
            Controls.Add(buttonBack);
            Controls.Add(panelCustomer);
            Controls.Add(dataGridView1);
            Controls.Add(buttonDeleteCustomer);
            Controls.Add(buttonUpdateCustomer);
            Controls.Add(buttonAddCustomer);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelCustomer.ResumeLayout(false);
            panelCustomer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddCustomer;
        private Button buttonUpdateCustomer;
        private Button buttonDeleteCustomer;
        private DataGridView dataGridView1;
        private Panel panelCustomer;
        private Label labelNameCustomers;
        private Label labelTz;
        private TextBox textBoxPhone;
        private TextBox textBoxAddress;
        private TextBox textBoxNameCustomers;
        private TextBox TextBoxTz;
        private Label labelPhone;
        private Label labelAddress;
        private Button buttonSaveCustomer;
        private DataGridViewTextBoxColumn NameCustomers;
        private DataGridViewTextBoxColumn Tz;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Phone;
        private Button buttonBack;
    }
}