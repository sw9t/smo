using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Smo;

namespace smo_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            double Q = double.Parse(textBox1.Text);
            double g = double.Parse(textBox2.Text);
            double t_obs = double.Parse(textBox3.Text);
            double d = double.Parse(textBox4.Text);
            double year = double.Parse(textBox5.Text);
            double n_kanalov = double.Parse(numericUpDown1.Value.ToString());
            richTextBox1.Text = Smo.SSO.Smo_s_otkazami(Q,g,t_obs,d,year,n_kanalov);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            double lambda = double.Parse(textBox10.Text);
            double r = double.Parse(textBox9.Text);
            double t_obs = double.Parse(textBox8.Text);
            double n_kanalov = double.Parse(numericUpDown2.Value.ToString());
            richTextBox2.Text = Smo.SSO.Smo_s_neogranicennoi(lambda, t_obs, r, n_kanalov);
        }
    }
}
