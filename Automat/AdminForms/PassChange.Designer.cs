namespace Automat.AdminForms
{
    partial class PassChange
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
            this.LbNewPass = new System.Windows.Forms.Label();
            this.LbOldPass = new System.Windows.Forms.Label();
            this.TBNewPass = new System.Windows.Forms.TextBox();
            this.TBOldPass = new System.Windows.Forms.TextBox();
            this.Anuluj = new System.Windows.Forms.Button();
            this.ZatwierdzButton = new System.Windows.Forms.Button();
            this.LbPassChange = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.LbNewPass);
            this.panel1.Controls.Add(this.LbOldPass);
            this.panel1.Controls.Add(this.TBNewPass);
            this.panel1.Controls.Add(this.TBOldPass);
            this.panel1.Location = new System.Drawing.Point(46, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 211);
            this.panel1.TabIndex = 2;
            // 
            // LbNewPass
            // 
            this.LbNewPass.AutoSize = true;
            this.LbNewPass.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbNewPass.Location = new System.Drawing.Point(316, 113);
            this.LbNewPass.Name = "LbNewPass";
            this.LbNewPass.Size = new System.Drawing.Size(97, 20);
            this.LbNewPass.TabIndex = 53;
            this.LbNewPass.Text = "Nowe hasło :";
            // 
            // LbOldPass
            // 
            this.LbOldPass.AutoSize = true;
            this.LbOldPass.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbOldPass.Location = new System.Drawing.Point(316, 30);
            this.LbOldPass.Name = "LbOldPass";
            this.LbOldPass.Size = new System.Drawing.Size(92, 20);
            this.LbOldPass.TabIndex = 52;
            this.LbOldPass.Text = "Stare hasło :";
            // 
            // TBNewPass
            // 
            this.TBNewPass.Location = new System.Drawing.Point(223, 145);
            this.TBNewPass.Name = "TBNewPass";
            this.TBNewPass.PasswordChar = '*';
            this.TBNewPass.Size = new System.Drawing.Size(281, 23);
            this.TBNewPass.TabIndex = 17;
            this.TBNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TBOldPass
            // 
            this.TBOldPass.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TBOldPass.Location = new System.Drawing.Point(223, 53);
            this.TBOldPass.Name = "TBOldPass";
            this.TBOldPass.PasswordChar = '*';
            this.TBOldPass.Size = new System.Drawing.Size(281, 25);
            this.TBOldPass.TabIndex = 15;
            this.TBOldPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Anuluj
            // 
            this.Anuluj.Location = new System.Drawing.Point(12, 12);
            this.Anuluj.Name = "Anuluj";
            this.Anuluj.Size = new System.Drawing.Size(75, 23);
            this.Anuluj.TabIndex = 5;
            this.Anuluj.Text = "Anuluj";
            this.Anuluj.UseVisualStyleBackColor = true;
            this.Anuluj.Click += new System.EventHandler(this.Anuluj_Click);
            // 
            // ZatwierdzButton
            // 
            this.ZatwierdzButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ZatwierdzButton.Location = new System.Drawing.Point(352, 324);
            this.ZatwierdzButton.Name = "ZatwierdzButton";
            this.ZatwierdzButton.Size = new System.Drawing.Size(107, 40);
            this.ZatwierdzButton.TabIndex = 6;
            this.ZatwierdzButton.Text = "Zmień";
            this.ZatwierdzButton.UseVisualStyleBackColor = true;
            this.ZatwierdzButton.Click += new System.EventHandler(this.ZatwierdzButton_Click);
            // 
            // LbPassChange
            // 
            this.LbPassChange.AutoSize = true;
            this.LbPassChange.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbPassChange.Location = new System.Drawing.Point(256, 49);
            this.LbPassChange.Name = "LbPassChange";
            this.LbPassChange.Size = new System.Drawing.Size(294, 25);
            this.LbPassChange.TabIndex = 54;
            this.LbPassChange.Text = "W celu zmiany hasła wprowadz : ";
            // 
            // PassChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.LbPassChange);
            this.Controls.Add(this.ZatwierdzButton);
            this.Controls.Add(this.Anuluj);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PassChange";
            this.Text = "Zmiana hasła";
            this.Activated += new System.EventHandler(this.PassChange_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PassChange_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button Anuluj;
        private Button ZatwierdzButton;
        private TextBox TBNewPass;
        private TextBox TBOldPass;
        private Label LbNewPass;
        private Label LbOldPass;
        private Label LbPassChange;
    }
}