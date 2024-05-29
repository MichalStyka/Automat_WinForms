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

    public partial class DelProductForm : Form
    {
//lista produktów
        public static Dictionary<int, Product> ProductsList = AutomatApp.DeserializeDataFromFile();
//wybrane id
        public static int selectedID;

        public static List<int> productListIds = new List<int>();
        public DelProductForm()
        {
            InitializeComponent();
        }

        private void DelProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.adminOptions.Show();
        }



        private void DelProductForm_Activated(object sender, EventArgs e)
        {

            dataRefresh();
            WybProdComboBox.DataSource = new BindingSource(productListIds, null);

            

        }

        public static void dataRefresh() 
        {
           
            ProductsList = AutomatApp.getProductsDic();
            productListIds = new List<int>(ProductsList.Keys);
            productListIds.Sort();
        }

        private void UsunButton_Click(object sender, EventArgs e)
        {

            ProductsList.Remove((int)WybProdComboBox.SelectedValue);
            AutomatApp.SerializeDataToFile(ProductsList);
            MessageBox.Show($"Usunieto: {TbNazwa.Text} o cenie : {TBCenaProduktu.Text} PLN z pozycji : {selectedID}.");
            TbNazwa.Text = "";
            TBCenaProduktu.Text = "";
            
            this.Hide();
            Forms.adminOptions.Show();


        }

        private void WybProdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedID = (int)WybProdComboBox.SelectedValue;
            TbNazwa.Text = ProductsList[selectedID].Name;
            TBCenaProduktu.Text = ProductsList[selectedID].price.ToString();
        }
    }
}
