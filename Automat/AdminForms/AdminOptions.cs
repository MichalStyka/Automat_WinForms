using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Automat.Classes;

namespace Automat.AdminForms
{
    public partial class AdminOptions : Form
    {
        Admin admin = AutomatApp.getAdmin();
        public AdminOptions()
        {
            InitializeComponent();
            StatusDispaly();
        }

        private void AdminLogBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.mainForm.Show();
        }

        private void AdminOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
   
   //opcje statusowe 
        private void StatusDispaly()
        {
            
            if (admin.IsOpen == false)
            {
                StatusLabel.Text = "Nieczynne";
                StatusLabel.BackColor = Color.Tomato;
                StatusChangeButton.BackColor = Color.Green;
                StatusChangeButton.Text = "Włącz automat";
            }
            else
            {
                StatusLabel.Text = "Czynne";
                StatusLabel.BackColor = Color.Green;
                StatusChangeButton.BackColor = Color.Tomato;
                StatusChangeButton.Text = "Wyłącz automat";
            }

            
        }

        private void AdminOptions_Activated(object sender, EventArgs e)
        {
            StatusDispaly();
        }

        private void StatusChangeButton_Click(object sender, EventArgs e)
        {
            if (admin.IsOpen == false)
            {
                StatusLabel.Text = "Czynne";
                StatusLabel.BackColor = Color.Green;
                StatusChangeButton.BackColor = Color.Tomato;
                StatusChangeButton.Text = "Wyłącz automat";
                
            }
            else
            {
                StatusLabel.Text = "Nieczynne";
                StatusLabel.BackColor = Color.Tomato;
                StatusChangeButton.BackColor = Color.Green;
                StatusChangeButton.Text = "Włącz automat";
            }
            admin.StatusChange();
            AutomatApp.SerializeAdminToFile(admin, AutomatApp.adminDataPath);
        }

        private void PassChangeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.passchange.Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.addProduct.Show();
        }

        private void DelProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.delProduct.Show();
        }

        private void EditProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.editProduct.Show();
        }
    }
}
