﻿using System;
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
            this.dataGridView_Input.RowCount = n+1;
            this.dataGridView_Input.ColumnCount = m;
            dataGridView_Input.ColumnHeadersVisible = false;
            dataGridView_Input.RowHeadersVisible = false;
            this.Text = name;
            dataGridView_Input.AllowUserToAddRows = false;
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
                    mat[i, j] = double.Parse(dataGridView_Input[j, i].Value.ToString().Replace(".", ","));
            this.DialogResult = DialogResult.OK;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
