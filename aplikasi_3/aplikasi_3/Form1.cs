using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int numMin = 0;
            int numMax = 0;
            bool isNumericMin = int.TryParse(txtMin.Text, out numMin);
            bool isNumericMax = int.TryParse(txtMax.Text, out numMax);
            if (isNumericMin && isNumericMax)
            {
                Random rand = new Random();
                int terambil = rand.Next(numMin, numMax+1);
                txtTerambil.Text = terambil.ToString();
            }
            else
            {
                MessageBox.Show("Angka yang kamu masukan tidak valid", "Salah Input");
            }
        }
    }
}
