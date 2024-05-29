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
    public partial class AddProductForm : Form
    {


//lista produktów
        public static Dictionary<int, Product> ProductsList = AutomatApp.DeserializeDataFromFile();

//wybrane id
        public static int selectedId;
//możeliwe It produktu
        public static List<int> AllIDs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//zajęte Id produktu
        public static List<int> TakenIds = new List<int>();
//dostępne ID Produktu
        public static List<int> AvailableIds = new List<int>();


        public AddProductForm()
        {
            
            InitializeComponent();
           
        }

//przy zamykaniu aplikcji
        private void AddProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
//jak form bedzie ponownie otworzony
        private void AddProductForm_Activated(object sender, EventArgs e)
        {
            dataRefreshAdd();
            //AutomatApp.SerializeDataToFile(ProductList);

            ////combobox - wybor dostepnego produktu
            WybIDComboBox.DataSource = new BindingSource(AvailableIds, null);
            TakenIds = new List<int>(ProductsList.Keys);
            AvailableIds = AllIDs.Except(TakenIds).ToList();

    }
//przycisk anuluj
        private void Anuluj_Click(object sender, EventArgs e)
        {
            selectedId = 0;
            TBNazwaProduktu.Text = "";
            TBCenaProduktu.Text = "";
            this.Hide();
            Forms.adminOptions.Show();
        }











//przycisk dodaj
        private void DodajButton_Click(object sender, EventArgs e)
        {



            selectedId = (int)WybIDComboBox.SelectedValue;

// Sprawdzanie, czy pola tekstowe są wypełnione
            if (string.IsNullOrEmpty(TBNazwaProduktu.Text) || string.IsNullOrEmpty(TBCenaProduktu.Text))
            {
                MessageBox.Show("Wpisz nazwę/cenę produktu");
                // Opcjonalnie, możesz ustawić tekst w polach, jeśli były puste
                TBNazwaProduktu.Text = "";
                TBCenaProduktu.Text = "";
            }
            else if (double.TryParse(TBCenaProduktu.Text, out double CenaWpisana))
            {
                
                MessageBox.Show($"Dodano produkt {TBNazwaProduktu.Text} o cenie {TBCenaProduktu.Text} na pozycje {selectedId} .");
                ProductsList.Add(selectedId, new Product(TBNazwaProduktu.Text, double.Parse(TBCenaProduktu.Text)));

             
               
                 AutomatApp.SerializeDataToFile(ProductsList);



                 TBNazwaProduktu.Text = "";
                 TBCenaProduktu.Text = "";
                 this.Hide();
                 Forms.adminOptions.Show();
            }
            else
            {
                MessageBox.Show("Nie wpisano liczby.");
            }

           



        }

//refresh danych co przed kazdym ponownym uruchomnieniem się powinien robić
        public static void dataRefreshAdd()
        {

           // ProductList = AutomatApp.DeserializeDataFromFile();
            TakenIds = new List<int>(ProductsList.Keys);
            AvailableIds = AllIDs.Except(TakenIds).ToList();
        }
    }
}

