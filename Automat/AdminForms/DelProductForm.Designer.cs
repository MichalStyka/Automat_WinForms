namespace Automat.AdminForms
{
    partial class DelProductForm
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
            this.BackButton = new System.Windows.Forms.Button();
            this.UsunButton = new System.Windows.Forms.Button();
            this.LbDelProduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbNazwa = new System.Windows.Forms.Label();
            this.TbNazwa = new System.Windows.Forms.TextBox();
            this.LabelIds = new System.Windows.Forms.Label();
            this.WybProdComboBox = new System.Windows.Forms.ComboBox();
            this.LbCenaProduktu = new System.Windows.Forms.Label();
            this.TBCenaProduktu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Powrót";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // UsunButton
            // 
            this.UsunButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UsunButton.Location = new System.Drawing.Point(353, 377);
            this.UsunButton.Name = "UsunButton";
            this.UsunButton.Size = new System.Drawing.Size(107, 40);
            this.UsunButton.TabIndex = 59;
            this.UsunButton.Text = "Usuń";
            this.UsunButton.UseVisualStyleBackColor = true;
            this.UsunButton.Click += new System.EventHandler(this.UsunButton_Click);
            // 
            // LbDelProduct
            // 
            this.LbDelProduct.AutoSize = true;
            this.LbDelProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbDelProduct.Location = new System.Drawing.Point(236, 34);
            this.LbDelProduct.Name = "LbDelProduct";
            this.LbDelProduct.Size = new System.Drawing.Size(333, 25);
            this.LbDelProduct.TabIndex = 58;
            this.LbDelProduct.Text = "W celu usunięcia produktu uzupełnij :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LbNazwa);
            this.panel1.Controls.Add(this.TbNazwa);
            this.panel1.Controls.Add(this.LabelIds);
            this.panel1.Controls.Add(this.WybProdComboBox);
            this.panel1.Controls.Add(this.LbCenaProduktu);
            this.panel1.Controls.Add(this.TBCenaProduktu);
            this.panel1.Location = new System.Drawing.Point(46, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 282);
            this.panel1.TabIndex = 57;
            // 
            // LbNazwa
            // 
            this.LbNazwa.AutoSize = true;
            this.LbNazwa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbNazwa.Location = new System.Drawing.Point(278, 112);
            this.LbNazwa.Name = "LbNazwa";
            this.LbNazwa.Size = new System.Drawing.Size(131, 20);
            this.LbNazwa.TabIndex = 61;
            this.LbNazwa.Text = "Nazwa produktu :";
            // 
            // TbNazwa
            // 
            this.TbNazwa.Location = new System.Drawing.Point(227, 135);
            this.TbNazwa.Name = "TbNazwa";
            this.TbNazwa.Size = new System.Drawing.Size(247, 23);
            this.TbNazwa.TabIndex = 60;
            this.TbNazwa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelIds
            // 
            this.LabelIds.AutoSize = true;
            this.LabelIds.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelIds.Location = new System.Drawing.Point(268, 30);
            this.LabelIds.Name = "LabelIds";
            this.LabelIds.Size = new System.Drawing.Size(153, 20);
            this.LabelIds.TabIndex = 59;
            this.LabelIds.Text = "Dostępne produkty  :";
            // 
            // WybProdComboBox
            // 
            this.WybProdComboBox.FormattingEnabled = true;
            this.WybProdComboBox.Location = new System.Drawing.Point(227, 62);
            this.WybProdComboBox.Name = "WybProdComboBox";
            this.WybProdComboBox.Size = new System.Drawing.Size(247, 23);
            this.WybProdComboBox.TabIndex = 58;
            this.WybProdComboBox.SelectedIndexChanged += new System.EventHandler(this.WybProdComboBox_SelectedIndexChanged);
            // 
            // LbCenaProduktu
            // 
            this.LbCenaProduktu.AutoSize = true;
            this.LbCenaProduktu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbCenaProduktu.Location = new System.Drawing.Point(278, 192);
            this.LbCenaProduktu.Name = "LbCenaProduktu";
            this.LbCenaProduktu.Size = new System.Drawing.Size(119, 20);
            this.LbCenaProduktu.TabIndex = 57;
            this.LbCenaProduktu.Text = "Cena produktu :";
            // 
            // TBCenaProduktu
            // 
            this.TBCenaProduktu.Location = new System.Drawing.Point(227, 225);
            this.TBCenaProduktu.Name = "TBCenaProduktu";
            this.TBCenaProduktu.Size = new System.Drawing.Size(247, 23);
            this.TBCenaProduktu.TabIndex = 55;
            this.TBCenaProduktu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DelProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsunButton);
            this.Controls.Add(this.LbDelProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DelProductForm";
            this.Text = "Usuń produkt";
            this.Activated += new System.EventHandler(this.DelProductForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DelProductForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BackButton;
        private Button UsunButton;
        private Label LbDelProduct;
        private Panel panel1;
        private Label LabelIds;
        private ComboBox WybProdComboBox;
        private Label LbCenaProduktu;
        private TextBox TBCenaProduktu;
        private Label LbNazwa;
        private TextBox TbNazwa;
    }
}