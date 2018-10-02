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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (model == null)
                return;
            model.Calculate();

            dgv_D.RowCount = model.d.n;
            dgv_D.ColumnCount = model.d.m;

            dgv_V.RowCount = model.v.n;
            dgv_V.ColumnCount = model.v.m;

            for (int i = 0; i < model.d.n; i++)
                for (int j = 0; j < model.d.m; j++)
                    dgv_D[j, i].Value = model.d[i, j]+1;

            for (int i = 0; i < model.v.n; i++)
                for (int j = 0; j < model.v.m; j++)
                    dgv_V[j, i].Value = model.v[i, j];

        }
        Model model;
        private void Save_Click(object sender, EventArgs e)
        {
            string file;
            OpenFileDialog ofd = new OpenFileDialog
            {
                //ofd.Filter = ".txt";
                Multiselect = false,
                Title = "Выбор файла для сохранения"
            };
            ofd.ShowDialog();
            file = ofd.FileName;
            model.Save(file);

        }

        private void Load_Click(object sender, EventArgs e)
        {
            string file;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = false,
                //ofd.Filter = ".txt";
                Title = "Выбор файла для загрузки"
            };
            ofd.ShowDialog();
            file = ofd.FileName;
            model = new Model();
            model.Load(file);


            NumericUpDown_countM.Value = model.n;
            NumericUpDown_countState.Value = model.N;
            NumericUpDown_countStr.Value = model.strategies.Length;

        }

        private void Create_Click(object sender, EventArgs e)
        {
            model = new Model();
            model.n = (int)NumericUpDown_countM.Value;
            model.N = (int)NumericUpDown_countState.Value;
            int k = (int)NumericUpDown_countStr.Value;
            model.strategies = new Strategy[k];

            for (int i = 0; i < k; i++)
            {
                Matrix p, r;
                InputMatrix input = new InputMatrix(model.N, model.N, "матрица вероятностей для "+(i+1)+" стратегии");
                input.ShowDialog();
                p = input.mat;

                input = new InputMatrix(model.N, model.N, "матрица ценности для " + (i + 1) + " стратегии");
                input.ShowDialog();
                r = input.mat;
                Strategy s = new Strategy(p, r, model.N);
                model.strategies[i] = s;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphForm gf = new GraphForm(model);
            gf.Show();
        }

    }
}
