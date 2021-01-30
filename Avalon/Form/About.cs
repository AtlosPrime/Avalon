using System;
using System.Windows.Forms;

namespace Avalon
{
    public partial class About_Form : Form
    {
        public About_Form()
        {
            InitializeComponent();

            textLabel1.Text = "Avalon";
            label1.Text = "Version 0.0.0\n\nCopyright \u00A9 " + DateTime.Now.Year + "\nAtlos_Prime";
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.monsite.net");
            this.linkLabel1.LinkVisited = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
