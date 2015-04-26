namespace NorthWind_Sepet_Uygulamasi
{
    partial class GUI
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
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(10, 10);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(200, 380);
            this.lstCustomers.TabIndex = 0;
            // 
            // lstProducts
            // 
            this.lstProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.Location = new System.Drawing.Point(210, 10);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(200, 380);
            this.lstProducts.TabIndex = 1;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 400);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lstCustomers);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "GUI";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = ":: Sepet Sepet Yumurta ::";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.ListBox lstProducts;
    }
}

