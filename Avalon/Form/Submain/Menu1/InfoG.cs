using System;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Win32;
using Microsoft.VisualBasic;



namespace Avalon
{
    public partial class InfoG_Form : Form
    {

        public InfoG_Form()
        {
            InitializeComponent();

            /*
            string NomHost = Dns.GetHostName();
            label1.Text = ("NetBIOS : " + NomHost);
            */
            // Active Computer Name = Tampon du changement jusqu'à restart
            // Computer Name = Changement


            //HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Tcpip\Parameters == True netbios? Automatic switch?
            //NV Hostname == Ture Changement, if NV Hostname changed, == Computer name changé. If restart, ACN + Hostname changé
            //Hostname == Tampon?
            /*
              string newName = "newName";
              key.SetValue("Hostname", newName);
              key.SetValue("NV Hostname", newName);
             */
            string ACN = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\ComputerName\ActiveComputerName", "ComputerName", null);
            string CN = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\ComputerName\ComputerName", "ComputerName", null);

            if (ACN == CN)
            {
                label2.Text = ("NetBIOS : " + ACN);
            }
            else
            {
                label2.Text = ("NetBIOS : " + ACN + " (" + CN + ")");
                label2.ForeColor = Color.Yellow;
                label2.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            var _UBR = key.GetValue("UBR").ToString();
            var _CurrentBuild = key.GetValue("CurrentBuild").ToString();
            string build = _CurrentBuild + "." + _UBR; // build


            string Version = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows NT\CurrentVersion", "ProductName", null); // Version = Windows 'int' 'edition'
            label1.Text = ("Système d'exploitation : " + Version + " build " + build);


            string sys_man = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\HardwareConfig\Current", "SystemManufacturer", null);
            label7.Text = ("System Manufacturer : " + sys_man);

            string sys_prod_name = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\HardwareConfig\Current", "SystemProductName", null); ;
            label8.Text = ("System Product Name : " + sys_prod_name);

            string sys_family = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\HardwareConfig\Current", "SystemFamily", null); ;
            label9.Text = ("System Family : " + sys_family);

        }

        private void InfoGform_load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

            string message = "Voulez vous changer le nom de votre ordinateur?";
            string title = "T'es sûr khoya?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters");
                string input = Interaction.InputBox("Comment voulez vous le nommer?", "Comment?", "Netbios...");
                key.SetValue("NV Hostname ", "DESKTOP-UVAR35");
            }
            else
            {
                // Do something  
            }
        }
    }
}