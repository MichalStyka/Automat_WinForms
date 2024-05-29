using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Automat.Classes
{
    public class AutomatApp
    {
        private static Admin admin;
        public static string? automatDataPath = "data.json";
        public static string? adminDataPath = "adminData.json";
        public static Dictionary<int,Product> ListProducts = new Dictionary<int,Product>();


        public AutomatApp()
        {
            InitializeAdmin();
            InitializeData();  
           
           
        }

        //zwracanie obiektu Admin i słownika Produktów
        public static Admin getAdmin()
        {

            return admin;
        }

        public static Dictionary<int, Product> getProductsDic()
        {
            DeserializeDataFromFile();
            return ListProducts;
        }



//Inicjalizacja -produkty -JSON
        private void InitializeData()
        {           
            if (File.Exists(automatDataPath))
            {
                
                DeserializeDataFromFile();
            }
            else
            {
                ListProducts.Add(1, new Product("Chipsy", 2.55));
                ListProducts.Add(2, new Product("Cola", 12.55));
                ListProducts.Add(3, new Product("Wafelek", 2.80));
                ListProducts.Add(4, new Product("Czekolada", 6.55));
                SerializeDataToFile(ListProducts);
            }                                  
        }


//Serjalizacja i Deserjalizacja metody - Dane produktów
        public static void SerializeDataToFile(Dictionary<int,Product> listP)
        {

            string jsonString = JsonConvert.SerializeObject(listP, Formatting.Indented);
            File.WriteAllText(automatDataPath, jsonString);
        }


        public static Dictionary<int, Product> DeserializeDataFromFile()
        {

            string jsonString = File.ReadAllText(automatDataPath);
            ListProducts = JsonConvert.DeserializeObject<Dictionary<int, Product>>(jsonString);
            return ListProducts;
        }


        //Serjalizacja i Deserjalizacja metody - Admin

     
        private void InitializeAdmin()
        {
            if (File.Exists(adminDataPath))
            {
                //admin =DeserializeAdminFromFile(filepath);
                DeserializeAdminFromFile(adminDataPath);
            }
            else
            {
                // Stworzenie admina z domyslnym username i haslem
                admin = new Admin("admin", "admin",true);
                SerializeAdminToFile(admin, adminDataPath);
            }

            //test();
        }
//metody
        public static void SerializeAdminToFile(Admin admin, string filePath)
        {
            
            string jsonString = JsonConvert.SerializeObject(admin, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        public static void DeserializeAdminFromFile(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            admin = JsonConvert.DeserializeObject<Admin>(jsonString);
            
        }

    
    }

}




   






