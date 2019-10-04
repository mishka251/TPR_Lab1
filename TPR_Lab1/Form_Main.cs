using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;

namespace TPR_Lab1
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            panels = new List<Panel>()
            {
                panel1
            };

            this.dgv_p.RowCount = (int)NumericUpDown_countState.Value + 1;
            this.dgv_p.ColumnCount = (int)NumericUpDown_countState.Value;
            dgv_p.ColumnHeadersVisible = false;
            dgv_p.RowHeadersVisible = false;
            dgv_p.AllowUserToAddRows = false;
            dgv_p.AllowUserToResizeColumns = false;
            dgv_p.AllowUserToResizeRows = false;

            this.dgv_c.RowCount = (int)NumericUpDown_countState.Value + 1;
            this.dgv_c.ColumnCount = (int)NumericUpDown_countState.Value;
            dgv_c.ColumnHeadersVisible = false;
            dgv_c.RowHeadersVisible = false;
            dgv_c.AllowUserToAddRows = false;
            dgv_c.AllowUserToResizeColumns = false;
            dgv_c.AllowUserToResizeRows = false;
        }


        void ShowMatsDV(Matrix mat, DataGridView dgv)
        {

            dgv.RowCount = mat.n;
            dgv.ColumnCount = mat.m - 1;

            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            for (int i = 0; i < mat.n; i++)
            {
                dgv.Rows[i].HeaderCell.Value = model.SituationsNames[i];

                dgv[0, i].Value = "-";
                dgv.Columns[0].HeaderText = "шаг " + 0;

                for (int j = 1; j < mat.m; j++)
                {
                    dgv[j - 1, i].Value = mat[i, j] + 1;
                    dgv.Columns[j - 1].HeaderText = "шаг " + j;
                }
            }

        }

        private void start_Click(object sender, EventArgs e)
        {
            if (model == null)
            {
                return;
            }

            model.Calculate();
            ShowMatsDV(model.d, dgv_D);
            ShowMatsDV(model.v, dgv_V);
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
            {
                return;
            }

            file = sfd.FileName;
            model.Save(file);

        }


        void ShowStartMatrix(string type, DataGridView dgv)
        {
            dgv.RowCount = model.N;
            dgv.ColumnCount = (model.N + 1) * model.strategies.Length;

            dgv.RowHeadersVisible = false;

            for (int str = 0; str < model.strategies.Length; str++)
            {
                int col = (model.N + 1) * str;
                dgv.Columns[col].HeaderText = model.strategies[str].Name;


                for (int sost = 0; sost < model.N; sost++)
                {
                    dgv[col, sost].Value = model.SituationsNames[sost];


                    for (int sost2 = 0; sost2 < model.N; sost2++)
                    {

                        dgv.Columns[col + sost + 1].HeaderText = model.SituationsNames[sost];

                        dgv[col + sost + 1, sost2].Value = type == "r" ? model.strategies[str].r[sost2, sost] : model.strategies[str].p[sost2, sost];
                    }
                }
            }
        }

        void ShowMatrixes()
        {
            ShowStartMatrix("r", dataGridView_InputDateD);
            ShowStartMatrix("p", dataGridView_InputDateV);
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
            {
                return;
            }

            file = ofd.FileName;
            model = new Model();
            model.Load(file);


            NumericUpDown_countM.Value = model.n;
            NumericUpDown_countState.Value = model.N;
            NumericUpDown_countStr.Value = model.strategies.Length;

            ShowMatrixes();

        }

        Matrix MatFromDgv(DataGridView dgv)
        {
            Matrix mat = new Matrix(dgv.ColumnCount, dgv.RowCount);
            try
            {
                for (int i = 0; i < mat.n; i++)
                {
                    for (int j = 0; j < mat.m; j++)
                    {
                        mat[i, j] = double.Parse(dgv[j, i].Value.ToString().Replace(".", ","));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка ввода " + ex.Message);
            }


            return mat;
        }

        bool CheckPMatrix(Matrix p)
        {
            for (int i = 0; i < p.n; i++)
            {
                double sum = 0;
                for (int j = 0; j < p.m; j++)
                {
                    sum += p[i, j];
                }

                if (Math.Abs(sum - 1) > 1E-5)
                {
                    return false;
                }
            }
            return true;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            model = new Model
            {
                n = (int)NumericUpDown_countM.Value,
                N = (int)NumericUpDown_countState.Value
            };
            int k = (int)NumericUpDown_countStr.Value;
            model.strategies = new Strategy[k];

            for (int i = 0; i < k; i++)
            {

                Strategy str = new Strategy(model.N);
                foreach (Control tb in panels[i].Controls)
                {
                    if (tb is TextBox)
                    {
                        str.Name = tb.Text;
                    }
                }

                foreach (Control dgv in panels[i].Controls)
                {
                    if (dgv is DataGridView)
                    {
                       // using (var dgv1 = dgv as DataGridView)
                        //{
                            if ((dgv as DataGridView).Name.IndexOf(dgv_p.Name) != -1)
                            {
                                str.p = MatFromDgv(dgv as DataGridView);
                                if (!CheckPMatrix(str.p))
                                {
                                    MessageBox.Show("Ошибка правильности матрицы вероятностей " + (i + 1) + " стратегии");
                                }
                            }
                            else
                            {
                                str.r = MatFromDgv(dgv as DataGridView);
                            }
                       // }
                    }
                }

                model.strategies[i] = str;
            }

            model.SituationsNames = new string[model.N];
            string[] rtb = richTextBox1.Text.Split('\n');
            for (int i = 0; i < model.N && i < rtb.Length; i++)
            {
                model.SituationsNames[i] = rtb[i];
            }

            for (int i = rtb.Length; i < model.N; i++)
            {
                model.SituationsNames[i] = "";
            }

            ShowMatrixes();
        }

        private void NumericUpDown_countM_ValueChanged(object sender, EventArgs e)
        {
            if (model != null)
            {
                model.n = (int)NumericUpDown_countM.Value;
            }
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
        List<Panel> panels;

        DataGridView Copy(DataGridView source)
        {
            DataGridView dgv = new DataGridView
            {
                ColumnCount = source.ColumnCount,
                RowCount = source.RowCount + 1,

                ColumnHeadersVisible = source.ColumnHeadersVisible,
                RowHeadersVisible = source.RowHeadersVisible,
                AllowUserToAddRows = source.AllowUserToAddRows,
                Top = source.Top,
                Left = source.Left,
                AllowUserToResizeColumns = source.AllowUserToResizeColumns,
                AllowUserToResizeRows = source.AllowUserToResizeRows,
                Name = source.Name + panels.Count,

                BorderStyle = source.BorderStyle
            };

            return dgv;
        }

        TextBox Copy(TextBox src)
        {
            TextBox tb = new TextBox
            {
                Left = src.Left,
                Top = src.Top,

                Width = src.Width,
                Height = src.Height,
                Name = src.Name + panels.Count,

                BorderStyle = BorderStyle.FixedSingle
            };

            return tb;
        }
        Label Copy(Label src)
        {
            Label lbl = new Label
            {
                Left = src.Left,
                Top = src.Top,

                Width = src.Width,
                Height = src.Height,

                Text = src.Text,
                Name = src.Name + panels.Count,

                BorderStyle = BorderStyle.FixedSingle
            };

            return lbl;
        }
        const int dy = 350;

        private void NumericUpDown_countStr_ValueChanged(object sender, EventArgs e)
        {

            if (NumericUpDown_countStr.Value > panels.Count)
            {
                Panel newPanel = new Panel();

                DataGridView dgv1 = Copy(dgv_p);
                DataGridView dgv2 = Copy(dgv_c);

                TextBox tb = Copy(tbName);

                Label lbl1 = Copy(label2), lbl2 = Copy(label3), lbl3 = Copy(label4);

                newPanel.Top = panels[panels.Count - 1].Top + dy;
                newPanel.Left = panel1.Left;

                newPanel.Width = panel1.Width;
                newPanel.Height = panel1.Height;

                newPanel.Controls.Add(tb);

                newPanel.Controls.Add(dgv1);
                newPanel.Controls.Add(dgv2);

                newPanel.Controls.Add(lbl1);
                newPanel.Controls.Add(lbl2);
                newPanel.Controls.Add(lbl3);
                newPanel.BorderStyle = BorderStyle.FixedSingle;

                this.Controls.Add(newPanel);
                panels.Add(newPanel);
            }
            else
            {
                this.Controls.Remove(panels[panels.Count - 1]);
                panels.RemoveAt(panels.Count - 1);
            }
        }

        private void NumericUpDown_countState_ValueChanged(object sender, EventArgs e)
        {
            foreach (Panel pan in panels)
            {
                foreach (Control dgv in pan.Controls)
                {
                    if (dgv is DataGridView)
                    {
                        (dgv as DataGridView).ColumnCount = (int)NumericUpDown_countState.Value;
                        (dgv as DataGridView).RowCount = (int)NumericUpDown_countState.Value;
                    }

                }
            }

            numericUpDown_startState.Value = Math.Min(numericUpDown_startState.Value, NumericUpDown_countState.Value);
            numericUpDown_startState.Maximum = NumericUpDown_countState.Value;
        }
    }

}
