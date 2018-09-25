using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR_Lab1
{
    public partial class GraphForm : Form
    {
        Model model;
        public GraphForm(Model m)
        {
            InitializeComponent();
            model = m;
            numericUpDown1.Maximum = m.N;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int sit = (int)numericUpDown1.Value;

            Graph gr = new Graph();

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics g = Graphics.FromImage(bmp);

            gr.Draw(model, g, pictureBox1.Width, pictureBox1.Height, sit-1, (int)model.d[sit-1, model.n-1]);

            pictureBox1.Image = bmp;

        }
    }
}
