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
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.btnSiparisOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstCustomers.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 19;
            this.lstCustomers.Location = new System.Drawing.Point(10, 10);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(279, 380);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            this.lstCustomers.SelectedValueChanged += new System.EventHandler(this.lstCustomers_SelectedValueChanged);
            // 
            // lstProducts
            // 
            this.lstProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstProducts.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 19;
            this.lstProducts.Location = new System.Drawing.Point(289, 10);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(200, 380);
            this.lstProducts.TabIndex = 1;
            this.lstProducts.DoubleClick += new System.EventHandler(this.lstProducts_DoubleClick);
            // 
            // lstSepet
            // 
            this.lstSepet.BackColor = System.Drawing.Color.Khaki;
            this.lstSepet.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstSepet.Font = new System.Drawing.Font("Segoe UI", 10.25F);
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 19;
            this.lstSepet.Location = new System.Drawing.Point(489, 10);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(272, 380);
            this.lstSepet.TabIndex = 2;
            // 
            // btnSiparisOlustur
            // 
            this.btnSiparisOlustur.BackColor = System.Drawing.Color.LightGreen;
            this.btnSiparisOlustur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparisOlustur.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnSiparisOlustur.Location = new System.Drawing.Point(767, 13);
            this.btnSiparisOlustur.Name = "btnSiparisOlustur";
            this.btnSiparisOlustur.Size = new System.Drawing.Size(128, 68);
            this.btnSiparisOlustur.TabIndex = 3;
            this.btnSiparisOlustur.Text = "Sipariş Oluştur";
            this.btnSiparisOlustur.UseVisualStyleBackColor = false;
            this.btnSiparisOlustur.Click += new System.EventHandler(this.btnSiparisOlustur_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label1.Location = new System.Drawing.Point(768, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 231);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnVazgec
            // 
            this.btnVazgec.BackColor = System.Drawing.Color.Crimson;
            this.btnVazgec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVazgec.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.btnVazgec.Location = new System.Drawing.Point(768, 88);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(128, 68);
            this.btnVazgec.TabIndex = 5;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseVisualStyleBackColor = false;
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 400);
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSiparisOlustur);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.lstProducts);
            this.Controls.Add(this.lstCustomers);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GUI";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = ":: Sepet Sepet Yumurta ::";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Button btnSiparisOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVazgec;
    }
}

