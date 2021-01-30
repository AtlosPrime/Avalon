using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Avalon
{
    public partial class Conditions_Form : Form
    {

        public bool acceptedTerms = false;

        public Conditions_Form()
        {
            InitializeComponent();
        }

        private void Condition_Load(object sender, EventArgs e)
        {

        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (acceptedTerms == false)
            {
                Environment.Exit(0); 
            }
        }

        
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                acceptedTerms = true;
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Avalon", true);
                key.SetValue("Termsaccepted", 1);
                this.Close();
            }
            else
            {
                checkBox1.ForeColor = Color.Red;
                MessageBox.Show("Vous devez acceptez les termes et les conditions pour pouvoir utiliser ce programme.", "Termes et Conditions", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
            }
        }



        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reveal_Click(object sender, EventArgs e)
        {
            SuperHiddenConnardPanel_Form Super = new SuperHiddenConnardPanel_Form();
            Super.ShowDialog();
        }
    }
}
