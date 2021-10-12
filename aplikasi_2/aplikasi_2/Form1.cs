using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJumlah_Click(object sender, EventArgs e)
        {
            int numA = 0;
            int numB = 0;
            bool isNumericA = int.TryParse(txtA.Text, out numA);
            bool isNumericB = int.TryParse(txtB.Text, out numB);
            if (isNumericA && isNumericB)
            {
                int jumlah = numA + numB;
                txtHasil.Text = jumlah.ToString();
            }
            else
            {
                MessageBox.Show("Angka yang kamu masukan tidak valid", "Salah Input");
            }
        }
    }
}
