using Automat.Classes;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
namespace Automat

{
    public partial class mainForm : Form
    {
        //public static Admin admin;
        Admin admin = AutomatApp.getAdmin();

        public static Dictionary<int, Product> ProductList = new Dictionary<int, Product>();
        public static List<int> ProductIds = new List<int>();
       

        public static int selectedId;
        public static string productName = "";
        public static double productPrice;


        public static void dataRefresh()
        {
            ProductList = AutomatApp.getProductsDic();
            ProductIds = new List<int>(ProductList.Keys);
        }



        public mainForm()
        {
            InitializeComponent();

        }


//pokazywanie statusu - otwarte zamkniete
        public string DisplayStatus()
        {
            string statusName;
            if (admin.IsOpen == false)
            {
                statusName = "Nieczynne";
            }
            else
            {
                statusName = "Czynne";
            }

            return statusName;
        }

        //dawanie asorytemntu do odpowiednich texboxów


        public void CleanAsort()
        {

            for (int i = 1; i <= 10; i++)
            {
                TextBox textBox = this.Controls.Find("textBox" + i, true).FirstOrDefault() as TextBox;
                if (textBox != null)
                {
                    textBox.Clear();
                }
            }

            for (int i = 1; i <= 10; i++)
            {
                Label label = this.Controls.Find("label" + i, true).FirstOrDefault() as Label;
                if (label != null)
                {
                    label.Text = string.Empty;
                }
            }


        }


        public void ShowAsort()
        {                     
            foreach (var kvp in ProductList)
            {
                TextBox textBox = Controls.Find("TextBox" + kvp.Key, true)[0] as TextBox;
                textBox.Text = $"{kvp.Value.Name}";                           
            }


            foreach(var kvp in ProductList)
            {
                Label label = Controls.Find("label" + kvp.Key, true)[0] as Label;
                if (label != null)
                {
                    label.Text = kvp.Value.price.ToString()+" PLN";
                }
                
            }


        }

 

        private void MainZatwierdz_Click(object sender, EventArgs e)
        {


            if (admin.IsOpen == false)
            {
                MessageBox.Show("Nie mo¿na kupowaæ bo jest nieczynne");
            }
            else
            {

                if (checkBoxGotowka.Checked == false & checkBoxKarta.Checked == false)
                {
                    MessageBox.Show("Musisz wybraæ opcje p³atnoœci!!");
                }
                else
                {
                    selectedId = (int)WybProduktComboBox.SelectedValue;
                    productName= ProductList[selectedId].Name;
                    productPrice= ProductList[selectedId].price;



                    if (checkBoxGotowka.Checked == true)
                    {
                        this.Hide();
                        Forms.payingWithMoney.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show($"Kupiono: {productName}\nKonto obciazono o {productPrice} z³.\n Dziêkujemy!!! ");
                        checkBoxGotowka.Checked = false;
                        checkBoxKarta.Checked = false;
                    }

                }




            }







        }


        //zeby tylko jeden by³ zaznaczony
        private void checkBoxKarta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKarta.Checked )
            {
                checkBoxGotowka.Checked = false;
               
            } 
           
        }

        private void checkBoxGotowka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGotowka.Checked)
            {
                checkBoxKarta.Checked = false;

            }
        }

        private void panelAdminButton_Click(object sender, EventArgs e)
        {           
            Forms.adminLog.Show();
            this.Hide();
        }

        private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
           
        }

        private void mainForm_Activated(object sender, EventArgs e)
        {
            CleanAsort();
            AutomatApp.DeserializeDataFromFile();
            dataRefresh();
            ProductIds.Sort();

            StatusLabel.Text = DisplayStatus();
            checkBoxGotowka.Checked = false;
            checkBoxKarta.Checked = false;
            ShowAsort();
            //combobox - wybor dostepnego produktu


            WybProduktComboBox.DataSource = new BindingSource(ProductIds, null);



            selectedId = 0;
            productName = "";
            productPrice = 0;
            
        }

       
    }
}