using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TPR_Lab1
{
    public partial class InputStrat : Form
    {
        int n, m;
        public Strategy strategy;
        public InputStrat(int n, int m, string name = "") : base()
        {
            this.n = n;
            this.m = m;


            strategy = new Strategy(n);
            InitializeComponent();

            this.Text = name;


            this.dgv_p.RowCount = n + 1;
            this.dgv_p.ColumnCount = m;
            dgv_p.ColumnHeadersVisible = false;
            dgv_p.RowHeadersVisible = false;          
            dgv_p.AllowUserToAddRows = false;

            this.dgv_c.RowCount = n + 1;
            this.dgv_c.ColumnCount = m;
            dgv_c.ColumnHeadersVisible = false;
            dgv_c.RowHeadersVisible = false;
            dgv_c.AllowUserToAddRows = false;
        }

        public InputStrat()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            bool ok = true;
            for (int i = 0; i < n; i++)
            {
                double sum = 0;
                for (int j = 0; j < m; j++)
                {
                    strategy.p[i, j] = double.Parse(dgv_p[j, i].Value.ToString().Replace(".", ","));
                    sum += strategy.p[i, j];
                    strategy.r[i, j]= double.Parse(dgv_c[j, i].Value.ToString().Replace(".", ","));
                }
                if (Math.Abs(sum - 1) > 1E-5)
                    ok = false;
            }

            strategy.Name = tbName.Text;

            if (this.Text.IndexOf("вероятностей") != -1 && !ok)

            {
                MessageBox.Show("Сумма в строке не равна 1");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
