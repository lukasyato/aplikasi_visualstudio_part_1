using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            lblKesimpulan.Visible = true;
            lblKesimpulan.Text = "Nama mu adalah " + txtNama.Text + ", \nmakanan favoritmu adalah " + txtFavFood.Text + ", \ndan warna favoritmu adalah " + txtFavColor.Text+".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNama.Text = "";
            txtFavFood.Text = "";
            txtFavColor.Text = "";
            lblKesimpulan.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
