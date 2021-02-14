namespace Avalon
{
    partial class Main_Form
    {

        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.LogoAvalon_PicBox = new System.Windows.Forms.PictureBox();
            this.MainPanel_Panel = new System.Windows.Forms.Panel();
            this.Wait_Label = new System.Windows.Forms.Label();
            this.Menu_Panel = new System.Windows.Forms.Panel();
            this.CGU_Btn = new System.Windows.Forms.Button();
            this.Menu3_Panel = new System.Windows.Forms.Panel();
            this.Menu3_2_Btn = new System.Windows.Forms.Button();
            this.Menu3_1_Btn = new System.Windows.Forms.Button();
            this.Menu3_Btn = new System.Windows.Forms.Button();
            this.About_Btn = new System.Windows.Forms.Button();
            this.Menu2_Panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Menu2_1_Btn = new System.Windows.Forms.Button();
            this.Menu2_Btn = new System.Windows.Forms.Button();
            this.Menu1_Panel = new System.Windows.Forms.Panel();
            this.Menu1_2_Btn = new System.Windows.Forms.Button();
            this.Menu1_1_Btn = new System.Windows.Forms.Button();
            this.Menu1_Btn = new System.Windows.Forms.Button();
            this.MainTruePanel_Panel = new System.Windows.Forms.Panel();
            this.MainInformation_Panel = new System.Windows.Forms.Panel();
            this.Monsite_UrlMain = new System.Windows.Forms.LinkLabel();
            this.Labeldesc = new System.Windows.Forms.Label();
            this.LabelAvalonversion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoAvalon_PicBox)).BeginInit();
            this.MainPanel_Panel.SuspendLayout();
            this.Menu_Panel.SuspendLayout();
            this.Menu3_Panel.SuspendLayout();
            this.Menu2_Panel.SuspendLayout();
            this.Menu1_Panel.SuspendLayout();
            this.MainTruePanel_Panel.SuspendLayout();
            this.MainInformation_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.LogoAvalon_PicBox);
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // LogoAvalon_PicBox
            // 
            resources.ApplyResources(this.LogoAvalon_PicBox, "LogoAvalon_PicBox");
            this.LogoAvalon_PicBox.Image = global::Avalon.Properties.Resources.Avalon_Logo;
            this.LogoAvalon_PicBox.Name = "LogoAvalon_PicBox";
            this.LogoAvalon_PicBox.TabStop = false;
            this.LogoAvalon_PicBox.Click += new System.EventHandler(this.MainMenuPanel_PicBox);
            // 
            // MainPanel_Panel
            // 
            resources.ApplyResources(this.MainPanel_Panel, "MainPanel_Panel");
            this.MainPanel_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MainPanel_Panel.Controls.Add(this.Wait_Label);
            this.MainPanel_Panel.Name = "MainPanel_Panel";
            this.MainPanel_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Panel1);
            // 
            // Wait_Label
            // 
            resources.ApplyResources(this.Wait_Label, "Wait_Label");
            this.Wait_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Wait_Label.Name = "Wait_Label";
            this.Wait_Label.Click += new System.EventHandler(this.Wait_Label1);
            // 
            // Menu_Panel
            // 
            resources.ApplyResources(this.Menu_Panel, "Menu_Panel");
            this.Menu_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Menu_Panel.Controls.Add(this.CGU_Btn);
            this.Menu_Panel.Controls.Add(this.Menu3_Panel);
            this.Menu_Panel.Controls.Add(this.Menu3_Btn);
            this.Menu_Panel.Controls.Add(this.About_Btn);
            this.Menu_Panel.Controls.Add(this.Menu2_Panel);
            this.Menu_Panel.Controls.Add(this.Menu2_Btn);
            this.Menu_Panel.Controls.Add(this.Menu1_Panel);
            this.Menu_Panel.Controls.Add(this.Menu1_Btn);
            this.Menu_Panel.Controls.Add(this.panelLogo);
            this.Menu_Panel.Name = "Menu_Panel";
            this.Menu_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenuPanel_Panel);
            // 
            // CGU_Btn
            // 
            resources.ApplyResources(this.CGU_Btn, "CGU_Btn");
            this.CGU_Btn.FlatAppearance.BorderSize = 0;
            this.CGU_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            this.CGU_Btn.ForeColor = System.Drawing.Color.LightGray;
            this.CGU_Btn.Name = "CGU_Btn";
            this.CGU_Btn.UseVisualStyleBackColor = true;
            this.CGU_Btn.Click += new System.EventHandler(this.Exit_Btn_Click_1);
            // 
            // Menu3_Panel
            // 
            this.Menu3_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Menu3_Panel.Controls.Add(this.Menu3_2_Btn);
            this.Menu3_Panel.Controls.Add(this.Menu3_1_Btn);
            resources.ApplyResources(this.Menu3_Panel, "Menu3_Panel");
            this.Menu3_Panel.Name = "Menu3_Panel";
            this.Menu3_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu3_Panel_Paint);
            // 
            // Menu3_2_Btn
            // 
            resources.ApplyResources(this.Menu3_2_Btn, "Menu3_2_Btn");
            this.Menu3_2_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Menu3_2_Btn.FlatAppearance.BorderSize = 0;
            this.Menu3_2_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.Menu3_2_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.Menu3_2_Btn.ForeColor = System.Drawing.Color.Silver;
            this.Menu3_2_Btn.Name = "Menu3_2_Btn";
            this.Menu3_2_Btn.UseVisualStyleBackColor = false;
            this.Menu3_2_Btn.Click += new System.EventHandler(this.Menu3_2_Btn_Click);
            // 
            // Menu3_1_Btn
            // 
            resources.ApplyResources(this.Menu3_1_Btn, "Menu3_1_Btn");
            this.Menu3_1_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Menu3_1_Btn.FlatAppearance.BorderSize = 0;
            this.Menu3_1_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.Menu3_1_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.Menu3_1_Btn.ForeColor = System.Drawing.Color.Silver;
            this.Menu3_1_Btn.Name = "Menu3_1_Btn";
            this.Menu3_1_Btn.UseVisualStyleBackColor = false;
            this.Menu3_1_Btn.Click += new System.EventHandler(this.Menu3_1_Btn_Click);
            // 
            // Menu3_Btn
            // 
            resources.ApplyResources(this.Menu3_Btn, "Menu3_Btn");
            this.Menu3_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu3_Btn.FlatAppearance.BorderSize = 0;
            this.Menu3_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.Menu3_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.Menu3_Btn.ForeColor = System.Drawing.Color.Silver;
            this.Menu3_Btn.Name = "Menu3_Btn";
            this.Menu3_Btn.UseVisualStyleBackColor = true;
            this.Menu3_Btn.Click += new System.EventHandler(this.Btn3menu);
            // 
            // About_Btn
            // 
            resources.ApplyResources(this.About_Btn, "About_Btn");
            this.About_Btn.FlatAppearance.BorderSize = 0;
            this.About_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.About_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.About_Btn.ForeColor = System.Drawing.Color.Silver;
            this.About_Btn.Name = "About_Btn";
            this.About_Btn.UseVisualStyleBackColor = true;
            this.About_Btn.Click += new System.EventHandler(this.About_Btn_Click);
            // 
            // Menu2_Panel
            // 
            this.Menu2_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Menu2_Panel.Controls.Add(this.button1);
            this.Menu2_Panel.Controls.Add(this.Menu2_1_Btn);
            resources.ApplyResources(this.Menu2_Panel, "Menu2_Panel");
            this.Menu2_Panel.Name = "Menu2_Panel";
            this.Menu2_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu2_Panel_Paint);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu2_1_Btn
            // 
            resources.ApplyResources(this.Menu2_1_Btn, "Menu2_1_Btn");
            this.Menu2_1_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Menu2_1_Btn.FlatAppearance.BorderSize = 0;
            this.Menu2_1_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.Menu2_1_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.Menu2_1_Btn.ForeColor = System.Drawing.Color.Silver;
            this.Menu2_1_Btn.Name = "Menu2_1_Btn";
            this.Menu2_1_Btn.UseVisualStyleBackColor = false;
            this.Menu2_1_Btn.Click += new System.EventHandler(this.Btn2menu1opt);
            // 
            // Menu2_Btn
            // 
            resources.ApplyResources(this.Menu2_Btn, "Menu2_Btn");
            this.Menu2_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu2_Btn.FlatAppearance.BorderSize = 0;
            this.Menu2_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.Menu2_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.Menu2_Btn.ForeColor = System.Drawing.Color.Silver;
            this.Menu2_Btn.Name = "Menu2_Btn";
            this.Menu2_Btn.UseVisualStyleBackColor = true;
            this.Menu2_Btn.Click += new System.EventHandler(this.Btn2menu);
            // 
            // Menu1_Panel
            // 
            this.Menu1_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.Menu1_Panel.Controls.Add(this.Menu1_2_Btn);
            this.Menu1_Panel.Controls.Add(this.Menu1_1_Btn);
            resources.ApplyResources(this.Menu1_Panel, "Menu1_Panel");
            this.Menu1_Panel.Name = "Menu1_Panel";
            this.Menu1_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Menu1_Panel_Paint);
            // 
            // Menu1_2_Btn
            // 
            resources.ApplyResources(this.Menu1_2_Btn, "Menu1_2_Btn");
            this.Menu1_2_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Menu1_2_Btn.FlatAppearance.BorderSize = 0;
            this.Menu1_2_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.Menu1_2_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.Menu1_2_Btn.ForeColor = System.Drawing.Color.Silver;
            this.Menu1_2_Btn.Name = "Menu1_2_Btn";
            this.Menu1_2_Btn.UseVisualStyleBackColor = false;
            this.Menu1_2_Btn.Click += new System.EventHandler(this.Btn1menu2opt);
            // 
            // Menu1_1_Btn
            // 
            resources.ApplyResources(this.Menu1_1_Btn, "Menu1_1_Btn");
            this.Menu1_1_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Menu1_1_Btn.FlatAppearance.BorderSize = 0;
            this.Menu1_1_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.Menu1_1_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.Menu1_1_Btn.ForeColor = System.Drawing.Color.Silver;
            this.Menu1_1_Btn.Name = "Menu1_1_Btn";
            this.Menu1_1_Btn.UseVisualStyleBackColor = false;
            this.Menu1_1_Btn.Click += new System.EventHandler(this.Btn1menu1opt);
            // 
            // Menu1_Btn
            // 
            resources.ApplyResources(this.Menu1_Btn, "Menu1_Btn");
            this.Menu1_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menu1_Btn.FlatAppearance.BorderSize = 0;
            this.Menu1_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.Menu1_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(34)))));
            this.Menu1_Btn.ForeColor = System.Drawing.Color.Silver;
            this.Menu1_Btn.Name = "Menu1_Btn";
            this.Menu1_Btn.UseVisualStyleBackColor = true;
            this.Menu1_Btn.Click += new System.EventHandler(this.Btn1menu);
            // 
            // MainTruePanel_Panel
            // 
            this.MainTruePanel_Panel.Controls.Add(this.MainInformation_Panel);
            this.MainTruePanel_Panel.Controls.Add(this.MainPanel_Panel);
            resources.ApplyResources(this.MainTruePanel_Panel, "MainTruePanel_Panel");
            this.MainTruePanel_Panel.Name = "MainTruePanel_Panel";
            this.MainTruePanel_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainTruePanel_Panel_Paint);
            // 
            // MainInformation_Panel
            // 
            resources.ApplyResources(this.MainInformation_Panel, "MainInformation_Panel");
            this.MainInformation_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MainInformation_Panel.Controls.Add(this.label11);
            this.MainInformation_Panel.Controls.Add(this.Monsite_UrlMain);
            this.MainInformation_Panel.Controls.Add(this.Labeldesc);
            this.MainInformation_Panel.Controls.Add(this.LabelAvalonversion);
            this.MainInformation_Panel.Name = "MainInformation_Panel";
            this.MainInformation_Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainInfo_Panel);
            // 
            // Monsite_UrlMain
            // 
            resources.ApplyResources(this.Monsite_UrlMain, "Monsite_UrlMain");
            this.Monsite_UrlMain.Name = "Monsite_UrlMain";
            this.Monsite_UrlMain.TabStop = true;
            this.Monsite_UrlMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UrlMain_LinkClicked);
            // 
            // Labeldesc
            // 
            resources.ApplyResources(this.Labeldesc, "Labeldesc");
            this.Labeldesc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Labeldesc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Labeldesc.Name = "Labeldesc";
            this.Labeldesc.Click += new System.EventHandler(this.Description_Label);
            // 
            // LabelAvalonversion
            // 
            resources.ApplyResources(this.LabelAvalonversion, "LabelAvalonversion");
            this.LabelAvalonversion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LabelAvalonversion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.LabelAvalonversion.Name = "LabelAvalonversion";
            this.LabelAvalonversion.Click += new System.EventHandler(this.Avalonversion_Label);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.Color.Red;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Name = "label11";
            // 
            // Main_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Menu_Panel);
            this.Controls.Add(this.MainTruePanel_Panel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.HelpButton = true;
            this.Name = "Main_Form";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoAvalon_PicBox)).EndInit();
            this.MainPanel_Panel.ResumeLayout(false);
            this.MainPanel_Panel.PerformLayout();
            this.Menu_Panel.ResumeLayout(false);
            this.Menu_Panel.PerformLayout();
            this.Menu3_Panel.ResumeLayout(false);
            this.Menu3_Panel.PerformLayout();
            this.Menu2_Panel.ResumeLayout(false);
            this.Menu2_Panel.PerformLayout();
            this.Menu1_Panel.ResumeLayout(false);
            this.Menu1_Panel.PerformLayout();
            this.MainTruePanel_Panel.ResumeLayout(false);
            this.MainTruePanel_Panel.PerformLayout();
            this.MainInformation_Panel.ResumeLayout(false);
            this.MainInformation_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel Menu_Panel;
        private System.Windows.Forms.Panel Menu2_Panel;
        private System.Windows.Forms.Button Menu2_1_Btn;
        private System.Windows.Forms.Button Menu2_Btn;
        private System.Windows.Forms.Panel Menu1_Panel;
        private System.Windows.Forms.Button Menu1_2_Btn;
        private System.Windows.Forms.Button Menu1_1_Btn;
        private System.Windows.Forms.Button Menu1_Btn;
        private System.Windows.Forms.Panel MainPanel_Panel;
        private System.Windows.Forms.Label Wait_Label;
        private System.Windows.Forms.Panel MainTruePanel_Panel;
        private System.Windows.Forms.Button About_Btn;
        private System.Windows.Forms.Button Menu3_Btn;
        private System.Windows.Forms.Panel MainInformation_Panel;
        private System.Windows.Forms.LinkLabel Monsite_UrlMain;
        private System.Windows.Forms.Label Labeldesc;
        private System.Windows.Forms.Label LabelAvalonversion;
        private System.Windows.Forms.Panel Menu3_Panel;
        private System.Windows.Forms.Button Menu3_1_Btn;
        private System.Windows.Forms.Button Menu3_2_Btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox LogoAvalon_PicBox;
        private System.Windows.Forms.Button CGU_Btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
    }
}