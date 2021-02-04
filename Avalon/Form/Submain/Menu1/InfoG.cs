using System;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;


namespace Avalon
{
    public partial class InfoG_Form : Form
    {
        public InfoG_Form()
        {
            InitializeComponent();

            ///
            string NomHost = Dns.GetHostName();
            label1.Text = ("NetBIOS : " + NomHost);
            ///
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion");
            var _UBR = key.GetValue("UBR").ToString();
            var _CurrentBuild = key.GetValue("CurrentBuild").ToString();
            string build = _CurrentBuild + "." + _UBR; // build
            string Version = (string)Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows NT\CurrentVersion", "ProductName", null); // Version = Windows 'int' 'edition'
            label2.Text = ("Système d'exploitation : " + Version + " build " + build);
        }

        

        private void InfoGform_load(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public static void DisplayDnsConfiguration()
        {
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                Debug.WriteLine(adapter.Description);
                Debug.WriteLine("  DNS suffix .............................. : {0}", properties.DnsSuffix);
                Debug.WriteLine("  DNS enabled ............................. : {0}", properties.IsDnsEnabled);
                Debug.WriteLine("  Dynamically configured DNS .............. : {0}", properties.IsDynamicDnsEnabled);
            }
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
    }
}