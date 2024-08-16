namespace Notepad
{
    partial class Postavke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Postavke));
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxFonts = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxFontSizes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select font";
            // 
            // comboBoxFonts
            // 
            this.comboBoxFonts.FormattingEnabled = true;
            this.comboBoxFonts.Location = new System.Drawing.Point(149, 45);
            this.comboBoxFonts.Name = "comboBoxFonts";
            this.comboBoxFonts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFonts.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select font size";
            // 
            // comboBoxFontSizes
            // 
            this.comboBoxFontSizes.FormattingEnabled = true;
            this.comboBoxFontSizes.Location = new System.Drawing.Point(149, 85);
            this.comboBoxFontSizes.Name = "comboBoxFontSizes";
            this.comboBoxFontSizes.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFontSizes.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Postavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 179);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxFontSizes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFonts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Postavke";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Postavke_FormClosing);
            this.Load += new System.EventHandler(this.Postavke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFonts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxFontSizes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}