using System;
using System.Windows.Forms;
using System.IO;

namespace Avalon
{
    public partial class Opti_Form : Form
    {

        string Temp = (Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\temp");

        public Opti_Form()
        {
            InitializeComponent();
        }

        private void InfoSys_groupBox_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Opti_Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attention, " + Temp + " va être supprimé." , "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MessageBox.Show("T'es sûr mec?", "Woula c'est pour pas que tu regrettes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            MessageBox.Show("Bah enfaite je sais pas encore intercepter l'évenement du bouton cancel donc dans tout les cas bah il va se supprimer, excepté si tu arrêtes l'aplication maintenant.", "Dans tout les cas, voilà", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (Directory.Exists(Temp))
            {
                Directory.Delete(Temp, true);
                MessageBox.Show("Voilà, " + Temp + " A été supprimé.", "Voilà mais c'est le titre", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Il existe pas de dossier avec le chemin " + Temp + ".", "Bah zut alors ça existe pas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Exit_Btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }
    }
}
