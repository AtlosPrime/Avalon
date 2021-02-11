using System;
using System.Windows.Forms;

namespace Avalon
{
    public partial class Main_Form : Form
    {

        public Main_Form()
        {
            InitializeComponent();
            Cachesubmenu();

            this.FormBorderStyle = FormBorderStyle.None;

            LabelAvalonversion.Text = ("Avalon " + global::Avalon.Properties.Resources.version);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Methodes
        private Form activeForm =
          default;
        private void Cachesubmenu()
        {
            Menu1_Panel.Visible = false;
            Menu2_Panel.Visible = false;
            Menu3_Panel.Visible = false;
        }

        private void Montresubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                Cachesubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            MainPanel_Panel.Controls.Add(childForm);
            MainPanel_Panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion

        #region BtnMenu
        private void Btn1menu(object sender, EventArgs e)
        {
            Montresubmenu(Menu1_Panel);
        }

        #region Menu1Btn
        private void Btn1menu1opt(object sender, EventArgs e)
        {
            OpenChildForm(new InfoG_Form());
            Cachesubmenu();
        }

        private void Btn1menu2opt(object sender, EventArgs e)
        {
            OpenChildForm(new Info00_Form());
            Cachesubmenu();
        }
        #endregion

        private void Btn2menu(object sender, EventArgs e)
        {
            Montresubmenu(Menu2_Panel);
        }

        #region Menu2Btn
        private void Btn2menu1opt(object sender, EventArgs e)
        {
            Cachesubmenu();
        }

        #endregion

        private void Btn3menu(object sender, EventArgs e)
        {
            Montresubmenu(Menu3_Panel);
        }

        #region Menu3Btn

        private void Menu3_1_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alors c'est pas prêt donc voilà CHEH.", "Hop hop hop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Cachesubmenu();
        }

        private void Menu3_2_Btn_Click(object sender, EventArgs e)
        {
            Ufopedia_Form Ufo = new Ufopedia_Form();
            Ufo.ShowDialog();
            Cachesubmenu();
        }

        #endregion

        #endregion

        private void MainMenuPanel_PicBox(object sender, EventArgs e)
        {

        }

        private void MainMenuPanel_Panel(object sender, PaintEventArgs e)
        {

        }

        private void MainPanel_Panel1(object sender, PaintEventArgs e)
        {

        }

        private void MainInfo_Panel(object sender, PaintEventArgs e)
        {

        }

        private void Avalonversion_Label(object sender, EventArgs e)
        {

        }

        private void Description_Label(object sender, EventArgs e)
        {

        }

        private void Wait_Label1(object sender, EventArgs e)
        {

        }

        private void About_Btn_Click(object sender, EventArgs e)
        {
            About_Form About = new About_Form();
            About.ShowDialog();
        }

        private void UrlMain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Opti_Form());
            Cachesubmenu();
        }
    }
}