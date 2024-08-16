using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Postavke : Form
    {

        public Font SelectedFont { get; set; }

        
        public Postavke()
        {
            InitializeComponent();

            comboBoxFonts.Items.AddRange(new string[] { "Arial", "Courier New", "Times New Roman" });
            comboBoxFontSizes.Items.AddRange(new string[] { "8", "12", "18" });

            comboBoxFonts.SelectedIndex = 0;
            comboBoxFontSizes.SelectedIndex = 1;
        }

        private void Postavke_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Postavke_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string odabraniFont=comboBoxFonts.SelectedItem.ToString();
            float odabranaVelicinaFonta=float.Parse(comboBoxFontSizes.SelectedItem.ToString());

            SelectedFont =new Font(odabraniFont,odabranaVelicinaFonta);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
