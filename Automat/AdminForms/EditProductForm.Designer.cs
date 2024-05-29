namespace Automat.AdminForms
{
    partial class EditProductForm
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
            this.EditButton = new System.Windows.Forms.Button();
            this.LbEditProduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LbNazwa = new System.Windows.Forms.Label();
            this.TbNazwa = new System.Windows.Forms.TextBox();
            this.LabelIds = new System.Windows.Forms.Label();
            this.WybProdComboBox = new System.Windows.Forms.ComboBox();
            this.LbCenaProduktu = new System.Windows.Forms.Label();
            this.TbCenaProduktu = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditButton.Location = new System.Drawing.Point(370, 388);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(107, 40);
            this.EditButton.TabIndex = 63;
            this.EditButton.Text = "Edytuj";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // LbEditProduct
            // 
            this.LbEditProduct.AutoSize = true;
            this.LbEditProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbEditProduct.Location = new System.Drawing.Point(253, 45);
            this.LbEditProduct.Name = "LbEditProduct";
            this.LbEditProduct.Size = new System.Drawing.Size(352, 25);
            this.LbEditProduct.TabIndex = 62;
            this.LbEditProduct.Text = "W celu edytowania produktu uzupełnij :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LbNazwa);
            this.panel1.Controls.Add(this.TbNazwa);
            this.panel1.Controls.Add(this.LabelIds);
            this.panel1.Controls.Add(this.WybProdComboBox);
            this.panel1.Controls.Add(this.LbCenaProduktu);
            this.panel1.Controls.Add(this.TbCenaProduktu);
            this.panel1.Location = new System.Drawing.Point(63, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 282);
            this.panel1.TabIndex = 61;
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
            this.LabelIds.Location = new System.Drawing.Point(244, 28);
            this.LabelIds.Name = "LabelIds";
            this.LabelIds.Size = new System.Drawing.Size(230, 20);
            this.LabelIds.TabIndex = 59;
            this.LabelIds.Text = "Wybierz ID (pozycje) produktu  :";
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
            // TbCenaProduktu
            // 
            this.TbCenaProduktu.Location = new System.Drawing.Point(227, 225);
            this.TbCenaProduktu.Name = "TbCenaProduktu";
            this.TbCenaProduktu.Size = new System.Drawing.Size(247, 23);
            this.TbCenaProduktu.TabIndex = 55;
            this.TbCenaProduktu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 60;
            this.BackButton.Text = "Powrót";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(495, 374);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 64;
            this.ResetButton.Text = "Resetuj";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.LbEditProduct);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BackButton);
            this.Name = "EditProductForm";
            this.Text = "Edytuj produkt";
            this.Activated += new System.EventHandler(this.EditProductForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditProductForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EditButton;
        private Label LbEditProduct;
        private Panel panel1;
        private Label LbNazwa;
        private TextBox TbNazwa;
        private Label LabelIds;
        private ComboBox WybProdComboBox;
        private Label LbCenaProduktu;
        private TextBox TbCenaProduktu;
        private Button BackButton;
        private Button ResetButton;
    }
}