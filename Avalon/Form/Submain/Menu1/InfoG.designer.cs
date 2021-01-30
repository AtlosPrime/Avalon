namespace Avalon
{
    partial class InfoG_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoG_Form));
            this.InfoSys_groupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exit_Btn = new System.Windows.Forms.Button();
            this.Label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InfoSys_groupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfoSys_groupBox
            // 
            this.InfoSys_groupBox.Controls.Add(this.label3);
            this.InfoSys_groupBox.Controls.Add(this.label2);
            this.InfoSys_groupBox.Controls.Add(this.label1);
            this.InfoSys_groupBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.InfoSys_groupBox, "InfoSys_groupBox");
            this.InfoSys_groupBox.Name = "InfoSys_groupBox";
            this.InfoSys_groupBox.TabStop = false;
            this.InfoSys_groupBox.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.InfoSys_groupBox);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Name = "panel2";
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.FlatAppearance.BorderSize = 0;
            this.Exit_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            resources.ApplyResources(this.Exit_Btn, "Exit_Btn");
            this.Exit_Btn.ForeColor = System.Drawing.Color.LightGray;
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.UseVisualStyleBackColor = true;
            this.Exit_Btn.Click += new System.EventHandler(this.Button5_Click_1);
            // 
            // Label
            // 
            resources.ApplyResources(this.Label, "Label");
            this.Label.ForeColor = System.Drawing.Color.Crimson;
            this.Label.Name = "Label";
            this.Label.Click += new System.EventHandler(this.Label_Click);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.Label);
            this.panel1.Controls.Add(this.Exit_Btn);
            this.panel1.Name = "panel1";
            // 
            // InfoG_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "InfoG_Form";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.InfoGform_load);
            this.InfoSys_groupBox.ResumeLayout(false);
            this.InfoSys_groupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox InfoSys_groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Exit_Btn;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Panel panel1;
    }
}