
namespace Avalon
{
    partial class Conditions_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Conditions_Form));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Reveal_Zesupaireydeuncaunarpanhel_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(51, 15);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(551, 325);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox1.Location = new System.Drawing.Point(51, 396);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(317, 28);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "J\'accepte ces termes et conditions";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(51, 463);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(552, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Lancer Avalon";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Reveal_Zesupaireydeuncaunarpanhel_Btn
            // 
            this.Reveal_Zesupaireydeuncaunarpanhel_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reveal_Zesupaireydeuncaunarpanhel_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Reveal_Zesupaireydeuncaunarpanhel_Btn.Location = new System.Drawing.Point(36, 15);
            this.Reveal_Zesupaireydeuncaunarpanhel_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Reveal_Zesupaireydeuncaunarpanhel_Btn.Name = "Reveal_Zesupaireydeuncaunarpanhel_Btn";
            this.Reveal_Zesupaireydeuncaunarpanhel_Btn.Size = new System.Drawing.Size(10, 10);
            this.Reveal_Zesupaireydeuncaunarpanhel_Btn.TabIndex = 5;
            this.Reveal_Zesupaireydeuncaunarpanhel_Btn.UseVisualStyleBackColor = true;
            this.Reveal_Zesupaireydeuncaunarpanhel_Btn.Click += new System.EventHandler(this.Reveal_Click);
            // 
            // Conditions_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(645, 567);
            this.Controls.Add(this.Reveal_Zesupaireydeuncaunarpanhel_Btn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(661, 606);
            this.MinimumSize = new System.Drawing.Size(661, 606);
            this.Name = "Conditions_Form";
            this.Text = "Conditions";
            this.Load += new System.EventHandler(this.Condition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Reveal_Zesupaireydeuncaunarpanhel_Btn;
    }
}