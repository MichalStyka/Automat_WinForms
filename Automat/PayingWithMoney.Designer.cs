namespace Automat
{
    partial class PayingWithMoney
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
            this.textBoxToPay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxItemName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Pln20gr = new System.Windows.Forms.CheckBox();
            this.Pln5zl = new System.Windows.Forms.CheckBox();
            this.Pln2zl = new System.Windows.Forms.CheckBox();
            this.Pln1zl = new System.Windows.Forms.CheckBox();
            this.Pln50gr = new System.Windows.Forms.CheckBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.Anuluj = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.textBoxToPay);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxPrice);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBoxItemName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Pln20gr);
            this.panel1.Controls.Add(this.Pln5zl);
            this.panel1.Controls.Add(this.Pln2zl);
            this.panel1.Controls.Add(this.Pln1zl);
            this.panel1.Controls.Add(this.Pln50gr);
            this.panel1.Location = new System.Drawing.Point(30, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(736, 310);
            this.panel1.TabIndex = 0;
            // 
            // textBoxToPay
            // 
            this.textBoxToPay.Location = new System.Drawing.Point(287, 178);
            this.textBoxToPay.Name = "textBoxToPay";
            this.textBoxToPay.Size = new System.Drawing.Size(191, 23);
            this.textBoxToPay.TabIndex = 15;
            this.textBoxToPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(312, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Zostało do zapłaty :";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(287, 97);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(191, 23);
            this.textBoxPrice.TabIndex = 13;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(312, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cena do zapłaty :";
            // 
            // TextBoxItemName
            // 
            this.TextBoxItemName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBoxItemName.Location = new System.Drawing.Point(287, 36);
            this.TextBoxItemName.Name = "TextBoxItemName";
            this.TextBoxItemName.Size = new System.Drawing.Size(191, 25);
            this.TextBoxItemName.TabIndex = 11;
            this.TextBoxItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(332, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Przedmiot :";
            // 
            // Pln20gr
            // 
            this.Pln20gr.AutoSize = true;
            this.Pln20gr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pln20gr.Location = new System.Drawing.Point(83, 225);
            this.Pln20gr.Name = "Pln20gr";
            this.Pln20gr.Size = new System.Drawing.Size(67, 25);
            this.Pln20gr.TabIndex = 9;
            this.Pln20gr.Text = "20 gr";
            this.Pln20gr.UseVisualStyleBackColor = true;
            this.Pln20gr.CheckedChanged += new System.EventHandler(this.Pln20gr_CheckedChanged);
            // 
            // Pln5zl
            // 
            this.Pln5zl.AutoSize = true;
            this.Pln5zl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pln5zl.Location = new System.Drawing.Point(583, 225);
            this.Pln5zl.Name = "Pln5zl";
            this.Pln5zl.Size = new System.Drawing.Size(54, 25);
            this.Pln5zl.TabIndex = 8;
            this.Pln5zl.Text = "5 zł";
            this.Pln5zl.UseVisualStyleBackColor = true;
            this.Pln5zl.CheckedChanged += new System.EventHandler(this.Pln5zl_CheckedChanged);
            // 
            // Pln2zl
            // 
            this.Pln2zl.AutoSize = true;
            this.Pln2zl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pln2zl.Location = new System.Drawing.Point(461, 225);
            this.Pln2zl.Name = "Pln2zl";
            this.Pln2zl.Size = new System.Drawing.Size(54, 25);
            this.Pln2zl.TabIndex = 7;
            this.Pln2zl.Text = "2 zł";
            this.Pln2zl.UseVisualStyleBackColor = true;
            this.Pln2zl.CheckedChanged += new System.EventHandler(this.Pln2zl_CheckedChanged);
            // 
            // Pln1zl
            // 
            this.Pln1zl.AutoSize = true;
            this.Pln1zl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pln1zl.Location = new System.Drawing.Point(351, 225);
            this.Pln1zl.Name = "Pln1zl";
            this.Pln1zl.Size = new System.Drawing.Size(51, 25);
            this.Pln1zl.TabIndex = 6;
            this.Pln1zl.Text = "1 zł";
            this.Pln1zl.UseVisualStyleBackColor = true;
            this.Pln1zl.CheckedChanged += new System.EventHandler(this.Pln1zl_CheckedChanged);
            // 
            // Pln50gr
            // 
            this.Pln50gr.AutoSize = true;
            this.Pln50gr.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pln50gr.Location = new System.Drawing.Point(218, 225);
            this.Pln50gr.Name = "Pln50gr";
            this.Pln50gr.Size = new System.Drawing.Size(67, 25);
            this.Pln50gr.TabIndex = 5;
            this.Pln50gr.Text = "50 gr";
            this.Pln50gr.UseVisualStyleBackColor = true;
            this.Pln50gr.CheckedChanged += new System.EventHandler(this.Pln50gr_CheckedChanged);
            // 
            // PayButton
            // 
            this.PayButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PayButton.Location = new System.Drawing.Point(342, 388);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(107, 40);
            this.PayButton.TabIndex = 1;
            this.PayButton.Text = "Wpłać";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(12, 12);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(75, 23);
            this.Anuluj.TabIndex = 4;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // PayingWithMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.PayButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PayingWithMoney";
            this.Text = "PayingWithMoney";
            this.Activated += new System.EventHandler(this.PayingWithMoney_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PayingWithMoney_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private CheckBox Pln5zl;
        private CheckBox Pln2zl;
        private CheckBox Pln1zl;
        private CheckBox Pln50gr;
        private Label label1;
        private CheckBox Pln20gr;
        private Button PayButton;
        private TextBox textBoxPrice;
        private Label label2;
        private TextBox TextBoxItemName;
        private TextBox textBoxToPay;
        private Label label3;
        private Button Anuluj;
    }
}