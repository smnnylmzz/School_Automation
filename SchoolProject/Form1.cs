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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Parent = pictureBox3;
            label3.BackColor = Color.Transparent;

            pictureBox4.Parent = pictureBox3;
            pictureBox4.BackColor = Color.Transparent;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OgrFrm frm = new OgrFrm();
            frm.numara = textBox1.Text;
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OgretmenGiris frm = new OgretmenGiris();
            frm.Show();
            this.Hide();
        }
    }
}
