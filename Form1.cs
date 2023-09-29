using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace checkBox2
{
    public partial class Form1 : Form
    {
        int broj = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btPosalji_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb1.AppendText("Odabrali ste: " + Environment.NewLine);
            if (cbDorucak.Checked)
            {
                tb1.AppendText("Dorucak" + Environment.NewLine); 
            }

            if (cbRucak.Checked)
            {
                tb1.AppendText("Rucak" + Environment.NewLine);
            }

            if (cbVecera.Checked)
            {
                tb1.AppendText("Vecera" + Environment.NewLine);
            }
        }

        private void cbSakriji_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSakriji.Checked)
            {
                tb1.Hide();
            }
            else { tb1.Show(); }
        }

        private void cbDorucak_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
