using System;
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


            var key1 = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Avalon");
            if (key1 == null)
            {
                RegistryKey key11 = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Avalon");
                key11.SetValue("Termsaccepted", "0");
            }
            else
            {

            }

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE")
;
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
