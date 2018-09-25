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
            this.dataGridView1.RowCount = n+1;
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
            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    mat[i, j] = double.Parse(dataGridView1[j, i].Value.ToString());
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
