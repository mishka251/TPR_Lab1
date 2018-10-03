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
            numericUpDown_startState.Maximum = m.N;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int sit = (int)numericUpDown_startState.Value;

            Graph gr = new Graph();

            Bitmap bmp = new Bitmap(pictureBox_Graph.Width, pictureBox_Graph.Height);

            Graphics g = Graphics.FromImage(bmp);

            gr.Draw(model, g, pictureBox_Graph.Width, pictureBox_Graph.Height, sit-1);

            pictureBox_Graph.Image = bmp;

        }
    }
}
