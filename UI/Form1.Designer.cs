namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonManager = new Button();
            buttonBanker = new Button();
            SuspendLayout();
            // 
            // buttonManager
            // 
            buttonManager.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 177);
            buttonManager.Location = new Point(522, 168);
            buttonManager.Name = "buttonManager";
            buttonManager.Size = new Size(117, 55);
            buttonManager.TabIndex = 0;
            buttonManager.Text = "מנהל";
            buttonManager.UseVisualStyleBackColor = true;
            buttonManager.Click += button1_Click;
            // 
            // buttonBanker
            // 
            buttonBanker.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBanker.Location = new Point(197, 168);
            buttonBanker.Name = "buttonBanker";
            buttonBanker.Size = new Size(117, 55);
            buttonBanker.TabIndex = 1;
            buttonBanker.Text = "קופאי";
            buttonBanker.UseVisualStyleBackColor = true;
            buttonBanker.Click += buttonBanker_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBanker);
            Controls.Add(buttonManager);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonManager;
        private Button buttonBanker;
    }
}
