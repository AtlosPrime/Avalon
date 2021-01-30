using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avalon
{
    public partial class SuperHiddenConnardPanel_Form : Form
    {
        public SuperHiddenConnardPanel_Form()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var source = @"C:\Users\User\Desktop\pepe.txt";
            var destination = @"C:\Users\User\Desktop\words_bck.txt";

            File.Copy(source, destination);
            System.Windows.Forms.MessageBox.Show("Transfert réussi.", "Transfert", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
        }   
    }
}
