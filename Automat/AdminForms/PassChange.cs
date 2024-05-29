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
    public partial class PassChange : Form
    {
        Admin admin = AutomatApp.getAdmin();
        public PassChange()
        {
            InitializeComponent();
        }

        private void PassChange_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void PassChange_Activated(object sender, EventArgs e)
        {
            TBOldPass.Text = "";
            TBNewPass.Text = "";
        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.adminOptions.Show();
        }

        private void ZatwierdzButton_Click(object sender, EventArgs e)
        {
            
               

          

            if(TBOldPass.Text != admin.Pass)
            {
                MessageBox.Show("Stare hasło jest niepoprawne!!");
            }
            else
            {
                if(admin.Pass == TBNewPass.Text)
                    {
                        MessageBox.Show("Nowe hasło musi byc inne niz stare !!");
                    }
                    else
                    {
                    admin.PassChange(TBNewPass.Text);
                    AutomatApp.SerializeAdminToFile(admin, AutomatApp.adminDataPath);
                    MessageBox.Show("Hasło zmienione !!");
                    this.Hide();
                    Forms.adminOptions.Show();
                }
            }
            TBOldPass.Text = "";
            TBNewPass.Text = "";
        }
    }
}
