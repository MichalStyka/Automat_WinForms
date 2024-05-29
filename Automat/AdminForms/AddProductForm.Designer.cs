namespace Automat.AdminForms
{
    partial class AddProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelID = new System.Windows.Forms.Label();
            this.WybIDComboBox = new System.Windows.Forms.ComboBox();
            this.LbCenaProduktu = new System.Windows.Forms.Label();
            this.LbNazwaProduktu = new System.Windows.Forms.Label();
            this.TBCenaProduktu = new System.Windows.Forms.TextBox();
            this.TBNazwaProduktu = new System.Windows.Forms.TextBox();
            this.Anuluj = new System.Windows.Forms.Button();
            this.LbAddProduct = new System.Windows.Forms.Label();
            this.DodajButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LabelID);
            this.panel1.Controls.Add(this.WybIDComboBox);
            this.panel1.Controls.Add(this.LbCenaProduktu);
            this.panel1.Controls.Add(this.LbNazwaProduktu);
            this.panel1.Controls.Add(this.TBCenaProduktu);
            this.panel1.Controls.Add(this.TBNazwaProduktu);
            this.panel1.Location = new System.Drawing.Point(46, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 282);
            this.panel1.TabIndex = 2;
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelID.Location = new System.Drawing.Point(223, 24);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(257, 20);
            this.LabelID.TabIndex = 59;
            this.LabelID.Text = "Dostępne ID (pozycja w automacie) :";
            // 
            // WybIDComboBox
            // 
            this.WybIDComboBox.FormattingEnabled = true;
            this.WybIDComboBox.Location = new System.Drawing.Point(214, 58);
            this.WybIDComboBox.Name = "WybIDComboBox";
            this.WybIDComboBox.Size = new System.Drawing.Size(281, 23);
            this.WybIDComboBox.TabIndex = 58;
            // 
            // LbCenaProduktu
            // 
            this.LbCenaProduktu.AutoSize = true;
            this.LbCenaProduktu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbCenaProduktu.Location = new System.Drawing.Point(283, 182);
            this.LbCenaProduktu.Name = "LbCenaProduktu";
            this.LbCenaProduktu.Size = new System.Drawing.Size(119, 20);
            this.LbCenaProduktu.TabIndex = 57;
            this.LbCenaProduktu.Text = "Cena produktu :";
            // 
            // LbNazwaProduktu
            // 
            this.LbNazwaProduktu.AutoSize = true;
            this.LbNazwaProduktu.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbNazwaProduktu.Location = new System.Drawing.Point(283, 101);
            this.LbNazwaProduktu.Name = "LbNazwaProduktu";
            this.LbNazwaProduktu.Size = new System.Drawing.Size(131, 20);
            this.LbNazwaProduktu.TabIndex = 56;
            this.LbNazwaProduktu.Text = "Nazwa produktu :";
            // 
            // TBCenaProduktu
            // 
            this.TBCenaProduktu.Location = new System.Drawing.Point(214, 219);
            this.TBCenaProduktu.Name = "TBCenaProduktu";
            this.TBCenaProduktu.Size = new System.Drawing.Size(281, 23);
            this.TBCenaProduktu.TabIndex = 55;
            this.TBCenaProduktu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBNazwaProduktu
            // 
            this.TBNazwaProduktu.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBNazwaProduktu.Location = new System.Drawing.Point(214, 135);
            this.TBNazwaProduktu.Name = "TBNazwaProduktu";
            this.TBNazwaProduktu.Size = new System.Drawing.Size(281, 25);
            this.TBNazwaProduktu.TabIndex = 54;
            this.TBNazwaProduktu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(12, 12);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(75, 23);
            this.Anuluj.TabIndex = 6;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // LbAddProduct
            // 
            this.LbAddProduct.AutoSize = true;
            this.LbAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbAddProduct.Location = new System.Drawing.Point(236, 37);
            this.LbAddProduct.Name = "LbAddProduct";
            this.LbAddProduct.Size = new System.Drawing.Size(322, 25);
            this.LbAddProduct.TabIndex = 55;
            this.LbAddProduct.Text = "W celu dodania produktu uzupełnij :";
            // 
            // DodajButton
            // 
            this.DodajButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DodajButton.Location = new System.Drawing.Point(353, 380);
            this.DodajButton.Name = "DodajButton";
            this.DodajButton.Size = new System.Drawing.Size(107, 40);
            this.DodajButton.TabIndex = 56;
            this.DodajButton.Text = "Dodaj";
            this.DodajButton.UseVisualStyleBackColor = true;
            this.DodajButton.Click += new System.EventHandler(this.DodajButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DodajButton);
            this.Controls.Add(this.LbAddProduct);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddProductForm";
            this.Text = "Dodawanie Produktu";
            this.Activated += new System.EventHandler(this.AddProductForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddProductForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button Anuluj;
        private Label LbAddProduct;
        private Label LbCenaProduktu;
        private Label LbNazwaProduktu;
        private TextBox TBCenaProduktu;
        private TextBox TBNazwaProduktu;
        private Button DodajButton;
        private Label LabelID;
        private ComboBox WybIDComboBox;
    }
}