namespace Automat
{
    partial class AdminLog
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.AdminLogBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TBPassword);
            this.panel1.Controls.Add(this.TBLogin);
            this.panel1.Location = new System.Drawing.Point(45, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 215);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(139, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hasło :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(139, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login :";
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(198, 119);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(239, 23);
            this.TBPassword.TabIndex = 1;
            // 
            // TBLogin
            // 
            this.TBLogin.Location = new System.Drawing.Point(198, 60);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(239, 23);
            this.TBLogin.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(591, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Wprowadz dane logowania do konta Administratora:";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(268, 334);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(173, 40);
            this.ButtonLogin.TabIndex = 2;
            this.ButtonLogin.Text = "Zaloguj się";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // AdminLogBack
            // 
            this.AdminLogBack.Location = new System.Drawing.Point(12, 12);
            this.AdminLogBack.Name = "AdminLogBack";
            this.AdminLogBack.Size = new System.Drawing.Size(75, 23);
            this.AdminLogBack.TabIndex = 3;
            this.AdminLogBack.Text = "Powrót";
            this.AdminLogBack.UseVisualStyleBackColor = true;
            this.AdminLogBack.Click += new System.EventHandler(this.AdminLogBack_Click);
            // 
            // AdminLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 418);
            this.Controls.Add(this.AdminLogBack);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminLog";
            this.Text = "Logowanie Administrator";
            this.Activated += new System.EventHandler(this.AdminLog_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminLog_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox TBPassword;
        private TextBox TBLogin;
        private Label label3;
        private Label label2;
        private Button ButtonLogin;
        private Button AdminLogBack;
    }
}