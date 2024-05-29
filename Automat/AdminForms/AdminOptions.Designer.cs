namespace Automat.AdminForms
{
    partial class AdminOptions
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
            this.StatusChangeButton = new System.Windows.Forms.Button();
            this.PassChangeButton = new System.Windows.Forms.Button();
            this.EditProductButton = new System.Windows.Forms.Button();
            this.DelProductButton = new System.Windows.Forms.Button();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.AdminLogBack = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.StatusChangeButton);
            this.panel1.Controls.Add(this.PassChangeButton);
            this.panel1.Controls.Add(this.EditProductButton);
            this.panel1.Controls.Add(this.DelProductButton);
            this.panel1.Controls.Add(this.AddProductButton);
            this.panel1.Location = new System.Drawing.Point(44, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 346);
            this.panel1.TabIndex = 1;
            // 
            // StatusChangeButton
            // 
            this.StatusChangeButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.StatusChangeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusChangeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StatusChangeButton.Location = new System.Drawing.Point(106, 48);
            this.StatusChangeButton.Name = "StatusChangeButton";
            this.StatusChangeButton.Size = new System.Drawing.Size(474, 43);
            this.StatusChangeButton.TabIndex = 4;
            this.StatusChangeButton.Text = "Status";
            this.StatusChangeButton.UseVisualStyleBackColor = false;
            this.StatusChangeButton.Click += new System.EventHandler(this.StatusChangeButton_Click);
            // 
            // PassChangeButton
            // 
            this.PassChangeButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PassChangeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PassChangeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassChangeButton.Location = new System.Drawing.Point(106, 97);
            this.PassChangeButton.Name = "PassChangeButton";
            this.PassChangeButton.Size = new System.Drawing.Size(474, 43);
            this.PassChangeButton.TabIndex = 3;
            this.PassChangeButton.Text = "Zmień hasło";
            this.PassChangeButton.UseVisualStyleBackColor = false;
            this.PassChangeButton.Click += new System.EventHandler(this.PassChangeButton_Click);
            // 
            // EditProductButton
            // 
            this.EditProductButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EditProductButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditProductButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EditProductButton.Location = new System.Drawing.Point(106, 270);
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(474, 43);
            this.EditProductButton.TabIndex = 2;
            this.EditProductButton.Text = "Edytuj produkt";
            this.EditProductButton.UseVisualStyleBackColor = false;
            this.EditProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // DelProductButton
            // 
            this.DelProductButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.DelProductButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelProductButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DelProductButton.Location = new System.Drawing.Point(106, 221);
            this.DelProductButton.Name = "DelProductButton";
            this.DelProductButton.Size = new System.Drawing.Size(474, 43);
            this.DelProductButton.TabIndex = 1;
            this.DelProductButton.Text = "Usuń produkt";
            this.DelProductButton.UseVisualStyleBackColor = false;
            this.DelProductButton.Click += new System.EventHandler(this.DelProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddProductButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddProductButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddProductButton.Location = new System.Drawing.Point(106, 172);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(474, 43);
            this.AddProductButton.TabIndex = 0;
            this.AddProductButton.Text = "Dodaj produkt";
            this.AddProductButton.UseVisualStyleBackColor = false;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // AdminLogBack
            // 
            this.AdminLogBack.Location = new System.Drawing.Point(12, 12);
            this.AdminLogBack.Name = "AdminLogBack";
            this.AdminLogBack.Size = new System.Drawing.Size(75, 23);
            this.AdminLogBack.TabIndex = 4;
            this.AdminLogBack.Text = "Wyloguj";
            this.AdminLogBack.UseVisualStyleBackColor = true;
            this.AdminLogBack.Click += new System.EventHandler(this.AdminLogBack_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Location = new System.Drawing.Point(423, 21);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(71, 32);
            this.StatusLabel.TabIndex = 52;
            this.StatusLabel.Text = "Status";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Status.Location = new System.Drawing.Point(230, 33);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(187, 20);
            this.Status.TabIndex = 51;
            this.Status.Text = "Aktualny status automatu:";
            // 
            // AdminOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.AdminLogBack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminOptions";
            this.Text = "Panel Administratora";
            this.Activated += new System.EventHandler(this.AdminOptions_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminOptions_FormClosing);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button AdminLogBack;
        private Button AddProductButton;
        private Button StatusChangeButton;
        private Button PassChangeButton;
        private Button EditProductButton;
        private Button DelProductButton;
        private Label StatusLabel;
        private Label Status;
    }
}