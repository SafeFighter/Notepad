using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using System.IO;

namespace Notepad
{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.ComboBox comboBoxFonts;
        private System.Windows.Forms.ComboBox comboBoxFontSizes;

        public Form1()
        {
            InitializeComponent();
            this.comboBoxFonts = new System.Windows.Forms.ComboBox();
            this.comboBoxFontSizes = new System.Windows.Forms.ComboBox();

            comboBoxFonts.Items.AddRange(new string[] { "Arial", "Courier New", "Times New Roman" });
            comboBoxFontSizes.Items.AddRange(new string[] { "8", "12", "18" });

            // Postavite početne vrijednosti
            comboBoxFonts.SelectedIndex = 0;
            comboBoxFontSizes.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save your document";
            saveFileDialog1.Filter = "Text Document|*.txt| HTML| *.html";


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fp = saveFileDialog1.FileName;

                using (StreamWriter writer = new StreamWriter(fp))
                {
                    writer.Write(textBox1.Text);
                }

            }

        }

        private string FilePath;

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Open a file";
            openFileDialog1.Filter = "Text Document|*.txt| Other|*.";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = openFileDialog1.FileName;

                StreamReader document = new StreamReader(FilePath);
                string line;
                textBox1.Clear();

                while ((line = document.ReadLine()) != null)
                {
                    textBox1.AppendText(line + Environment.NewLine);
                }

                document.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                writer.Write(textBox1.Text);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 glavnaForma = new Form1();
            glavnaForma.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                DialogResult result = MessageBox.Show(
            "Are you sure you want to close this application? Any unsaved changes will be lost.",
            "Confirm Exit",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning);

                if (DialogResult.Cancel == result)
                {
                    e.Cancel = true;
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (Postavke postavkeForm = new Postavke())
            {
                if (postavkeForm.ShowDialog() == DialogResult.OK)
                {
                    Font selectedFont = postavkeForm.SelectedFont;

                    textBox1.Font = selectedFont;

                    comboBoxFonts.SelectedItem = selectedFont.FontFamily.Name;
                    comboBoxFontSizes.SelectedItem = selectedFont.Size.ToString();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
