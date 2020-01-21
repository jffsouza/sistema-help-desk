using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace help_desk
{
    static class Program
    {
        public static String Nome;
        public static String Email;
        public static String Departamento;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
