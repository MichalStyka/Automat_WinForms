using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Classes
{
    public class Admin
    {
        public string Login { get; set; } = "Administrator";
        public string Pass { get; set; } = "";
        public bool IsOpen { get; set; }


        public Admin(string login, string pass, bool isOpen)
        {
            Login = login;
            Pass = pass;
            IsOpen = isOpen;
            
        }

       public void StatusChange()
        {
            if (IsOpen == true)
            {
                IsOpen = false;
            }
            else
            {
                IsOpen = true;
            }
        }


        public void PassChange(string newPass)
        {
            Pass = newPass;
        }

    }
}

