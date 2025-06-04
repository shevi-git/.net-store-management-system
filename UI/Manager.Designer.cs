namespace UI
{
    partial class Manager
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
            buttonCustomer = new Button();
            buttonSale = new Button();
            buttonProduct = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // buttonCustomer
            // 
            buttonCustomer.Location = new Point(940, 220);
            buttonCustomer.Margin = new Padding(4, 5, 4, 5);
            buttonCustomer.Name = "buttonCustomer";
            buttonCustomer.Size = new Size(189, 71);
            buttonCustomer.TabIndex = 0;
            buttonCustomer.Text = "לקוחות";
            buttonCustomer.UseVisualStyleBackColor = true;
            buttonCustomer.Click += buttonCustomer_Click;
            // 
            // buttonSale
            // 
            buttonSale.Location = new Point(498, 220);
            buttonSale.Margin = new Padding(4, 5, 4, 5);
            buttonSale.Name = "buttonSale";
            buttonSale.Size = new Size(189, 71);
            buttonSale.TabIndex = 1;
            buttonSale.Text = "מבצעים";
            buttonSale.UseVisualStyleBackColor = true;
            buttonSale.Click += buttonSale_Click;
            // 
            // buttonProduct
            // 
            buttonProduct.Location = new Point(46, 220);
            buttonProduct.Margin = new Padding(4, 5, 4, 5);
            buttonProduct.Name = "buttonProduct";
            buttonProduct.Size = new Size(189, 71);
            buttonProduct.TabIndex = 2;
            buttonProduct.Text = "מוצרים";
            buttonProduct.UseVisualStyleBackColor = true;
            buttonProduct.Click += buttonProduct_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(528, 468);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(159, 71);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "חזרה לעמוד הקודם";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 750);
            Controls.Add(buttonBack);
            Controls.Add(buttonProduct);
            Controls.Add(buttonSale);
            Controls.Add(buttonCustomer);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Manager";
            Text = "Manager";
            Load += Manager_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCustomer;
        private Button buttonSale;
        private Button buttonProduct;
        private Button buttonBack;
    }
}