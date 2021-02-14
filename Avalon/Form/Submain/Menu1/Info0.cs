using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Avalon
{
    public partial class Info00_Form : Form
    {

        private RegistryKey currentUser;
        private RegistryKey software;
        private RegistryKey microsoft;
        private RegistryKey windows;
        private RegistryKey currentVersion;
        private RegistryKey run;


        public Info00_Form()
        {
            InitializeComponent();
            LoadPrograms();
        }

        private void LoadPrograms()
        {
            OpenSubKeys();
            SetProgrammsToListBox();
        }

        private void OpenSubKeys()
        {
            currentUser = Registry.CurrentUser;
            software = currentUser.OpenSubKey("SOFTWARE", true);
            microsoft = software.OpenSubKey("Microsoft", true);
            windows = microsoft.OpenSubKey("Windows", true);
            currentVersion = windows.OpenSubKey("CurrentVersion", true);
            run = currentVersion.OpenSubKey("Run", true);
        }

        private void UpdateListBox()
        {
            listBoxProgramms.Items.Clear();
            SetProgrammsToListBox();
        }

        private void SetProgrammsToListBox()
        {
            var mass = run.GetValueNames();
            listBoxProgramms.Items.AddRange(mass);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void listBoxProgramms_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string path = GetPath();
            string name = path.Substring(path.LastIndexOf('\\') + 1);

            run.SetValue(name, path);
            UpdateListBox();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listBoxProgramms.Items.Count != 0)
            {
                if (listBoxProgramms.SelectedItem != null)
                    run.DeleteValue($"{listBoxProgramms.SelectedItem.ToString()}");
                else
                    MessageBox.Show("Aucun choix, veuillez selectionner un programme dans la liste au dessus.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateListBox();
        }
        private string GetPath()
        {
            string path = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Exe | *.exe";
            ofd.InitialDirectory = @"C:\Program Files";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
            return path;
        }

        private void Exit_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
