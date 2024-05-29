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
    public partial class PayingWithMoney : Form
    {
        public static double Cena;
        public static double moneta;
        public static double zostaloDoZaplaty;
        public static double zaplacono;

        public PayingWithMoney()
        {

            InitializeComponent();




        }

        private void PayingWithMoney_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            //
            if (zaplacono > 0)
            {
                MessageBox.Show($"Wydano: {zaplacono}");
            }
            textBoxToPay.Text = "";
            zaplacono = 0;
            zostaloDoZaplaty = 0;

            this.Hide();
            Forms.mainForm.Show();

        }

        private void PayingWithMoney_Activated(object sender, EventArgs e)
        {
            //wplacono = 0;
            TextBoxItemName.Text = mainForm.productName;
            textBoxPrice.Text = mainForm.productPrice.ToString();
            Cena = mainForm.productPrice;
            textBoxToPay.Text = Cena.ToString();
           


        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            if (Pln20gr.Checked == false & Pln50gr.Checked == false & Pln1zl.Checked == false & Pln2zl.Checked == false & Pln5zl.Checked == false)
            {
                MessageBox.Show("Musisz wybrać wrzucic monete (wybrac) !!");
            }
            else
            {
                zaplacono = zaplacono + moneta;
                zostaloDoZaplaty = Cena - zaplacono;
                zostaloDoZaplaty = Math.Round(zostaloDoZaplaty, 2);
                MessageBox.Show($"Wrzucono: {moneta} zł ");
                if(zaplacono > Cena)
                {
                    textBoxToPay.Text = "Opłacono";
                }
                else
                {
                    textBoxToPay.Text = zostaloDoZaplaty.ToString();
                }
                

                if(zaplacono == Cena)
                {
                    MessageBox.Show($"Kupiono i wydano produkt : {mainForm.productName}");
                    zaplacono = 0;
                    zostaloDoZaplaty = 0;
                    this.Hide();
                    Forms.mainForm.Show();
                }else if (zaplacono > Cena)
                {
                    MessageBox.Show($"Kupiono i wydano produkt : {mainForm.productName}.");
                    MessageBox.Show($"Reszta wydana {zostaloDoZaplaty * -1}");
                    zaplacono = 0;
                    zostaloDoZaplaty = 0;

                    this.Hide();
                    Forms.mainForm.Show();
                }

                //
            }










        }


//Xeby była tylko
        private void Pln20gr_CheckedChanged(object sender, EventArgs e)
        {
            if (Pln20gr.Checked)
            {
                Pln50gr.Checked = false;
                Pln1zl.Checked = false;
                Pln2zl.Checked = false;
                Pln5zl.Checked = false;
                moneta = 0.2;
            }

        }

        private void Pln50gr_CheckedChanged(object sender, EventArgs e)
        {
            if (Pln50gr.Checked)
            {
                Pln20gr.Checked = false;
                Pln1zl.Checked = false;
                Pln2zl.Checked = false;
                Pln5zl.Checked = false;
                moneta = 0.5;
            }
        }

        private void Pln1zl_CheckedChanged(object sender, EventArgs e)
        {
            if (Pln1zl.Checked)
            {
                Pln20gr.Checked = false;
                Pln50gr.Checked = false;
                Pln2zl.Checked = false;
                Pln5zl.Checked = false;
                moneta = 1;
            }
        }

        private void Pln2zl_CheckedChanged(object sender, EventArgs e)
        {
            if (Pln2zl.Checked)
            {
                Pln20gr.Checked = false;
                Pln50gr.Checked = false;
                Pln1zl.Checked = false;
                Pln5zl.Checked = false;
                moneta = 2;
            }
        }

        private void Pln5zl_CheckedChanged(object sender, EventArgs e)
        {
            if (Pln5zl.Checked)
            {
                Pln20gr.Checked = false;
                Pln50gr.Checked = false;
                Pln1zl.Checked = false;
                Pln2zl.Checked = false;
                moneta = 5;
            }
        }
    }
}
