using System;
using System.Drawing;
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
            dgv_D.ColumnCount = model.d.m - 1;

            dgv_V.RowCount = model.v.n;
            dgv_V.ColumnCount = model.v.m - 1;

            dgv_V.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv_D.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            for (int i = 0; i < model.d.n; i++)
            {
                dgv_D.Rows[i].HeaderCell.Value = model.SituationsNames[i];

                dgv_D[0, i].Value = "-";
                dgv_D.Columns[0].HeaderText = "шаг " + 0;

                for (int j = 1; j < model.d.m; j++)
                {
                    dgv_D[j - 1, i].Value = model.d[i, j] + 1;
                    dgv_D.Columns[j - 1].HeaderText = "шаг " + j;
                }
            }

            for (int i = 0; i < model.v.n; i++)
            {
                dgv_V.Rows[i].HeaderCell.Value = model.SituationsNames[i];

                for (int j = 1; j < model.v.m; j++)
                {
                    dgv_V[j - 1, i].Value = model.v[i, j];
                    dgv_V.Columns[j - 1].HeaderText = "шаг " + j;

                }
            }

        }
        Model model;
        private void Save_Click(object sender, EventArgs e)
        {
            string file;
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "(Текстовые файлы)|*.txt",
                Title = "Выбор файла для сохранения"
            };
            DialogResult dr = sfd.ShowDialog();
            if (dr == DialogResult.Abort || dr == DialogResult.Cancel)
                return;
            file = sfd.FileName;
            model.Save(file);

        }


        void ShowMatrixes()
        {
            dataGridView_InputDateV.RowCount = model.N;
            dataGridView_InputDateV.ColumnCount = (model.N + 1) * model.strategies.Length;

            dataGridView_InputDateD.RowCount = model.N;
            dataGridView_InputDateD.ColumnCount = (model.N + 1) * model.strategies.Length;

            dataGridView_InputDateD.RowHeadersVisible = false;
            dataGridView_InputDateV.RowHeadersVisible = false;

            for (int str = 0; str < model.strategies.Length; str++)
            {
                int col = (model.N + 1) * str;
                dataGridView_InputDateV.Columns[col].HeaderText = model.strategies[str].Name;
                dataGridView_InputDateD.Columns[col].HeaderText = model.strategies[str].Name;



                for (int sost = 0; sost < model.N; sost++)
                {
                    dataGridView_InputDateV[col, sost].Value = model.SituationsNames[sost];
                    dataGridView_InputDateD[col, sost].Value = model.SituationsNames[sost];

                    for (int sost2 = 0; sost2 < model.N; sost2++)
                    {

                        dataGridView_InputDateV.Columns[col + sost + 1].HeaderText = model.SituationsNames[sost];
                        dataGridView_InputDateD.Columns[col + sost + 1].HeaderText = model.SituationsNames[sost];

                        dataGridView_InputDateV[col + sost + 1, sost2].Value = model.strategies[str].p[sost2, sost];
                        dataGridView_InputDateD[col + sost + 1, sost2].Value = model.strategies[str].r[sost2, sost];
                    }
                }
            }

        }


        private void Load_Click(object sender, EventArgs e)
        {
            string file;
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = false,
                Filter = "(Текстовые файлы)|*.txt",
                Title = "Выбор файла для загрузки"
            };
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.Abort || dr == DialogResult.Cancel)
                return;
            file = ofd.FileName;
            model = new Model();
            model.Load(file);


            NumericUpDown_countM.Value = model.n;
            NumericUpDown_countState.Value = model.N;
            NumericUpDown_countStr.Value = model.strategies.Length;

            ShowMatrixes();

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
                var input = new InputStrat(model.N, model.N, "Ввод " + (i + 1) + " стратегии");
                if (input.ShowDialog() == DialogResult.Cancel)
                    return;

                model.strategies[i] = input.strategy;
            }

            model.SituationsNames = new string[model.N];
            for (int i = 0; i < model.N; i++)
                model.SituationsNames[i] = richTextBox1.Text.Split('\n')[i];

            ShowMatrixes();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    GraphForm gf = new GraphForm(model);
        //    gf.Show();
        //}

        private void NumericUpDown_countM_ValueChanged(object sender, EventArgs e)
        {
            model.n = (int)NumericUpDown_countM.Value;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            int sit = (int)numericUpDown_startState.Value;

            Graph gr = new Graph();

            Bitmap bmp = new Bitmap(pictureBox_Graph.Width, pictureBox_Graph.Height);

            Graphics g = Graphics.FromImage(bmp);

            gr.Draw(model, g, pictureBox_Graph.Width, pictureBox_Graph.Height, sit - 1);

            pictureBox_Graph.Image = bmp;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
