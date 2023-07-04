using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void btnKulup_Click(object sender, EventArgs e)
        {
            FrmKulup fr = new FrmKulup();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void btnDers_Click(object sender, EventArgs e)
        {
            frmDersler fr = new frmDersler();
            fr.Show();
            this.Hide();
        }

        private void FrmOgretmen_Load(object sender, EventArgs e)
        {

        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            frmOgrenci fr = new frmOgrenci();
            fr.Show();
            this.Hide();
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar fr = new FrmSinavNotlar();
            fr.Show();
            this.Hide();
        }
    }
}
