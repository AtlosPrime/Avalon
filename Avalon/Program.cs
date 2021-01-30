using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Avalon
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);


            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Avalon");
            if (Convert.ToInt32(key.GetValue("Termsaccepted")) == 1)
            {
                Application.Run(new Main_Form());
            }
            else
            {
                Application.Run(new Conditions_Form());
                Application.Run(new Main_Form());
            }
        }
    }
}
