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
    public partial class InputMatrix : Form
    {
        int n, m;
        public Matrix mat;
        public InputMatrix(int n, int m, string name = "") : base()
        {
            this.n = n;
            this.m = m;


            mat = new Matrix(n, m);
            InitializeComponent();
            this.dataGridView1.RowCount = n + 1;
            this.dataGridView1.ColumnCount = m;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            this.Text = name;
            dataGridView1.AllowUserToAddRows = false;
            // dataGridView1.row
        }

        public InputMatrix()
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
                    mat[i, j] = double.Parse(dataGridView1[j, i].Value.ToString());
                    sum += mat[i, j];
                }
                if (Math.Abs(sum - 1) > 1E-5)
                    ok = false;
            }

            if (!ok)
            {
                MessageBox.Show("Сумма строке не 1");
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
