using System;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Win32;

namespace Avalon
{
    public partial class Main_Form : Form
    {

        private PictureBox titlebar = new PictureBox(); // create a PictureBox
        // private PictureBox avalonlogo = new PictureBox(); // create a PictureBox
        private Label titre = new Label(); // simulates the this.close box
        private Label close = new Label(); // simulates the this.close box

        private bool drag = false; // determine if we should be moving the form
        private Point startPoint = new Point(0, 0); // also for the moving

        public Main_Form()
        {
            InitializeComponent();
            Cachesubmenu();

            #region titlebar+move
            this.FormBorderStyle = FormBorderStyle.None;

            this.titlebar.Location = this.Location;
            this.titlebar.Width = this.Width;
            this.titlebar.Height = 25;
            this.titlebar.BackColor = Color.Black;
            this.Controls.Add(this.titlebar);
            this.titlebar.BringToFront();

            this.close.Text = "Fermer";
            this.close.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new Point(this.Width - 55, this.Location.Y + 3);
            this.close.ForeColor = Color.White;
            this.close.BackColor = Color.Black;
            this.Controls.Add(this.close);
            this.close.BringToFront();

            this.titre.Text = "Avalon";
            this.titre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new Point(this.Width - 885, this.Location.Y + 3);
            this.titre.ForeColor = Color.White;
            this.titre.BackColor = Color.Black;
            this.Controls.Add(this.titre);
            this.titre.BringToFront();

            /*
            this.avalonlogo.Image = global::Avalon.Properties.Resources.TPRicon;
            this.Controls.Add(this.avalonlogo);
            this.avalonlogo.BringToFront();
            */

            this.close.MouseEnter += new EventHandler(Control_MouseEnter);
            this.close.MouseLeave += new EventHandler(Control_MouseLeave);
            this.close.MouseClick += new MouseEventHandler(Control_MouseClick);


            this.titlebar.MouseDown += new MouseEventHandler(Title_MouseDown);
            this.titlebar.MouseUp += new MouseEventHandler(Title_MouseUp);
            this.titlebar.MouseMove += new MouseEventHandler(Title_MouseMove);

            //avalonlogo.BringToFront();
 
            titre.BringToFront();

            #endregion
            LabelAvalonversion.Text = "Avalon " + Properties.Resources.version;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        #region move+hovercouleur
        private void Control_MouseEnter(object sender, EventArgs e)
        {
            if (sender.Equals(this.close))
                this.close.ForeColor = Color.Red;
        }

        private void Control_MouseLeave(object sender, EventArgs e)
        { // return them to their default colours
            if (sender.Equals(this.close))
                this.close.ForeColor = Color.White;
        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            if (sender.Equals(this.close))
                this.Close(); // close the form
        }

        void Title_MouseUp(object sender, MouseEventArgs e)
        {
            this.drag = false;
        }

        void Title_MouseDown(object sender, MouseEventArgs e)
        {
            this.startPoint = e.Location;
            this.drag = true;
        }

        void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.drag)
            { // if we should be dragging it, we need to figure out some movement
                Point p1 = new Point(e.X, e.Y);
                Point p2 = this.PointToScreen(p1);
                Point p3 = new Point(p2.X - this.startPoint.X,
                                     p2.Y - this.startPoint.Y);
                this.Location = p3;
            }
           
        }
        #endregion

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


        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Opti_Form());
            Cachesubmenu();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Btn_Click_1(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Avalon", true);
            key.SetValue("Termsaccepted", 0);
            Application.Restart();

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu3_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu2_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu1_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainTruePanel_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}