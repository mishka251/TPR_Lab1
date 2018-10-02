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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (model == null)
                return;
            model.Calculate();

            dgvD.RowCount = model.d.n;
            dgvD.ColumnCount = model.d.m;

            dgvV.RowCount = model.v.n;
            dgvV.ColumnCount = model.v.m;

            for (int i = 0; i < model.d.n; i++)
                for (int j = 0; j < model.d.m; j++)
                    dgvD[j, i].Value = model.d[i, j] + 1;

            for (int i = 0; i < model.v.n; i++)
                for (int j = 0; j < model.v.m; j++)
                    dgvV[j, i].Value = model.v[i, j];

        }
        Model model;
        private void Save_Click(object sender, EventArgs e)
        {
            string file;
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = ".txt",
                Title = "Выбор файла для сохранения"
            };
            sfd.ShowDialog();
            file = sfd.FileName;
            model.Save(file);

        }

        private void Load_Click(object sender, EventArgs e)
        {
            string file;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = false,
                Filter = ".txt",
                Title = "Выбор файла для загрузки"
            };
            ofd.ShowDialog();
            file = ofd.FileName;
            model = new Model();
            model.Load(file);


            numUDn.Value = model.n;
            numUDN2.Value = model.N;
            numUDk.Value = model.strategies.Length;

        }

        private void Create_Click(object sender, EventArgs e)
        {
            model = new Model();
            model.n = (int)numUDn.Value;
            model.N = (int)numUDN2.Value;
            int k = (int)numUDk.Value;
            model.strategies = new Strategy[k];

            for (int i = 0; i < k; i++)
            {
                Matrix p, r;
                InputMatrix input = new InputMatrix(model.N, model.N, "матрица вероятностей для " + (i + 1) + " стратегии");
                if (input.ShowDialog() == DialogResult.Cancel)
                    return;
                p = input.mat;

                input = new InputMatrix(model.N, model.N, "матрица доходностей для " + (i + 1) + " стратегии");
                if (input.ShowDialog() == DialogResult.Cancel)
                    return;

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
