using Automat.Classes;
using System.Text.Json.Serialization;



namespace Automat
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
             AutomatApp app = new AutomatApp();
            ApplicationConfiguration.Initialize();
            //Application.Run(new mainForm());
            //mainForm f1 = new mainForm();
            //f1.Show();
            Forms.mainForm.Show();
            Application.Run();
        }
    }
}