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

namespace Automat
{
    public partial class AdminLog : Form
    {
        Admin admin = AutomatApp.getAdmin();

        public AdminLog()
        {
            InitializeComponent();

//opcje pola hasła
            TBPassword.PasswordChar = '*';
            TBPassword.MaxLength = 14;
         
        }

        private void AdminLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

            
        }


//Przycisk powortu do głownego automatu
        private void AdminLogBack_Click(object sender, EventArgs e)
        {
            TBLogin.Text = "";
            TBPassword.Text = "";
            this.Hide();
            Forms.mainForm.Show();
            
            
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
           



                if(TBLogin.Text != admin.Login)
            {
                MessageBox.Show("Niepoprawny login ,spróbuj ponownie");
                TBLogin.Text = "";
                TBPassword.Text = "";
            }
            else if(TBPassword.Text != admin.Pass)
            {
                MessageBox.Show("Niepoprawne hasło ,spróbuj ponownie");
                TBLogin.Text = "";
                TBPassword.Text = "";
            } else
            {
                TBLogin.Text = "";
                TBPassword.Text = "";
                this.Hide();
                Forms.adminOptions.Show();
            }
            




        }

        private void AdminLog_Activated(object sender, EventArgs e)
        {
            


            
        }
    }
}
