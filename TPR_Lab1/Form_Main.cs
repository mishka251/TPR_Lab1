using System;
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



            //dgv_D.RowHeadersWidth = 200;

            dgv_V.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv_D.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            for (int i = 0; i < model.d.n; i++)
            {
                dgv_D.Rows[i].HeaderCell.Value = "состояние" + (i + 1);

                //<<<<<<< HEAD
                //=======
                //                dgv_D[0, i].Value = "-";
                //                dgv_D.Columns[0].HeaderText = "шаг " + 0;
                //>>>>>>> ec73972f3b2338cf882691ebd162ecf295942693
                for (int j = 1; j < model.d.m; j++)
                {
                    dgv_D[j - 1, i].Value = model.d[i, j] + 1;
                    dgv_D.Columns[j - 1].HeaderText = "шаг " + j;
                }
            }

            dgv_V.RowHeadersWidth = 200;
            for (int i = 0; i < model.v.n; i++)
            {
                dgv_V.Rows[i].HeaderCell.Value = "состояние" + (i + 1);

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
                    dataGridView_InputDateV[col, sost].Value = "состояние " + (sost + 1);
                    dataGridView_InputDateD[col, sost].Value = "состояние " + (sost + 1);

                    for (int sost2 = 0; sost2 < model.N; sost2++)
                    {

                        dataGridView_InputDateV.Columns[col + sost+1].HeaderText = "состояние " + (sost + 1);
                        dataGridView_InputDateD.Columns[col + sost+1].HeaderText = "состояние " + (sost + 1);

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
            ShowMatrixes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GraphForm gf = new GraphForm(model);
            gf.Show();
        }

        private void NumericUpDown_countM_ValueChanged(object sender, EventArgs e)
        {
            model.n = (int)NumericUpDown_countM.Value;
        }
    }
}
