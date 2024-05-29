using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automat.AdminForms;

namespace Automat.Classes
{
    static class Forms
    {
        public static AdminLog adminLog = new AdminLog();
        public static mainForm mainForm = new mainForm();
        public static PayingWithMoney payingWithMoney = new PayingWithMoney();
        public static AdminOptions adminOptions = new AdminOptions();
        public static PassChange passchange = new PassChange();
        public static AddProductForm addProduct = new AddProductForm();
        public static DelProductForm delProduct  = new DelProductForm();
        public static EditProductForm editProduct = new EditProductForm();
    }
}
