using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Avalon
{
    public partial class Ufopedia_Form : Form
    {
        public Ufopedia_Form()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public static void Open1()
        {

        }

        private void Ufopedia_Form_Load(object sender, EventArgs e)
        {

        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadSave__Btn(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nomitem_Label.Text = "Bâtiments";
            Nomitem_Label.Refresh();
            //Nomitem_Label.Text = "Version 0.0.0\n\nCopyright \u00A9 " + DateTime.Now.Year + "\nAtlos_Prime";
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nomitem_Label.Text = "Véhicules";
            Nomitem_Label.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Nomitem_Label.Text = "Weapons";
            Nomitem_Label.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Nomitem_Label.Text = "Armures";
            Nomitem_Label.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Nomitem_Label.Text = "Aircraft";
            Nomitem_Label.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Nomitem_Label.Text = "Aircraft Equipment";
            Nomitem_Label.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Nomitem_Label.Text = "Aliens Intentions";
            Nomitem_Label.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            PanelMenu.Visible = false;
            PanelMenu.Refresh();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }
    }
}

