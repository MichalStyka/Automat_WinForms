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
    public partial class EditProductForm : Form
    {
        //lista produktów
        public static Dictionary<int, Product> ProductsList = AutomatApp.DeserializeDataFromFile();
        //wybrane id
        public static int selectedID;

        public static string OldName ="";
        public static string OldPrice="";

        public static List<int> productListIds = new List<int>();
        public EditProductForm()
        {
            InitializeComponent();
        }

        private void EditProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EditProductForm_Activated(object sender, EventArgs e)
        {
            dataRefresh();
            WybProdComboBox.DataSource = new BindingSource(productListIds, null);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.adminOptions.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {


          

            // Sprawdzanie, czy pola tekstowe są wypełnione
            if (string.IsNullOrEmpty(TbNazwa.Text) || string.IsNullOrEmpty(TbCenaProduktu.Text))
            {
                MessageBox.Show("Nazwa/cena produktu nie może być puste!!");
                // Opcjonalnie, możesz ustawić tekst w polach, jeśli były puste
                
            }
            else if (double.TryParse(TbCenaProduktu.Text, out double CenaWpisana))
            {


                ProductsList[selectedID].Name = TbNazwa.Text;
                ProductsList[selectedID].price = Convert.ToDouble(TbCenaProduktu.Text);
                 AutomatApp.SerializeDataToFile(ProductsList);


                MessageBox.Show($"Zmieniono produkt {OldName} o cenie {OldPrice} PLN na pozycji {selectedID} \n na: {TbNazwa.Text} o cenie {TbCenaProduktu.Text} PLN..");
                TbNazwa.Text = "";
                TbCenaProduktu.Text = "";
                this.Hide();
                Forms.adminOptions.Show();
            }
            else
            {
                MessageBox.Show("Nie wpisano poprawnej ceny (musi byc liczba z przecinkiem jak sepeparator).");
            }


        }



        public static void dataRefresh()
        {

            ProductsList = AutomatApp.getProductsDic();
            productListIds = new List<int>(ProductsList.Keys);
            productListIds.Sort();
        }

        private void WybProdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedID = (int)WybProdComboBox.SelectedValue;

            OldName = ProductsList[selectedID].Name;
            OldPrice = ProductsList[selectedID].price.ToString();

            TbNazwa.Text = ProductsList[selectedID].Name;
            TbCenaProduktu.Text = ProductsList[selectedID].price.ToString();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TbNazwa.Text = OldName;
            TbCenaProduktu.Text = OldPrice;
        }
    }
}
