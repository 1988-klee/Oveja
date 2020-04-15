using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oveja
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            label3.Text = Convert.ToString(i);
            MessageBox.Show("Aqui estoy..");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 0;
            label3.Text = Convert.ToString(i);
            MessageBox.Show("Estoy Zzz");
            Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
