using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            this.label1.Location = this.Location;
            this.label1.Width = this.Width;
            this.label1.Height = 25;
            this.label1.BackColor = Color.Black;
            this.label1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
