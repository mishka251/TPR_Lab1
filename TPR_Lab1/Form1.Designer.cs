namespace TPR_Lab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.start = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.numUDn = new System.Windows.Forms.NumericUpDown();
            this.numUDN2 = new System.Windows.Forms.NumericUpDown();
            this.numUDk = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Create = new System.Windows.Forms.Button();
            this.dgvV = new System.Windows.Forms.DataGridView();
            this.dgvD = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.V = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUDn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDN2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvD)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(21, 331);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 0;
            this.start.Text = "Начало";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 94);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Сохранить модель";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(103, 94);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 2;
            this.Load.Text = "загрузить модель";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // numUDn
            // 
            this.numUDn.Location = new System.Drawing.Point(12, 57);
            this.numUDn.Name = "numUDn";
            this.numUDn.Size = new System.Drawing.Size(120, 20);
            this.numUDn.TabIndex = 3;
            this.numUDn.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numUDN2
            // 
            this.numUDN2.Location = new System.Drawing.Point(197, 58);
            this.numUDN2.Name = "numUDN2";
            this.numUDN2.Size = new System.Drawing.Size(120, 20);
            this.numUDN2.TabIndex = 4;
            this.numUDN2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numUDk
            // 
            this.numUDk.Location = new System.Drawing.Point(371, 57);
            this.numUDk.Name = "numUDk";
            this.numUDk.Size = new System.Drawing.Size(120, 20);
            this.numUDk.TabIndex = 5;
            this.numUDk.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Количество шагов модели";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Количество стратегий";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество состояний";
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(525, 45);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 9;
            this.Create.Text = "Создать систему";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // dgvV
            // 
            this.dgvV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvV.Location = new System.Drawing.Point(12, 163);
            this.dgvV.Name = "dgvV";
            this.dgvV.Size = new System.Drawing.Size(240, 150);
            this.dgvV.TabIndex = 10;
            // 
            // dgvD
            // 
            this.dgvD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvD.Location = new System.Drawing.Point(475, 163);
            this.dgvD.Name = "dgvD";
            this.dgvD.Size = new System.Drawing.Size(240, 150);
            this.dgvD.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "D";
            // 
            // V
            // 
            this.V.AutoSize = true;
            this.V.Location = new System.Drawing.Point(18, 138);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(14, 13);
            this.V.TabIndex = 13;
            this.V.Text = "V";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Граф";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.V);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvD);
            this.Controls.Add(this.dgvV);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUDk);
            this.Controls.Add(this.numUDN2);
            this.Controls.Add(this.numUDn);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUDn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDN2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.NumericUpDown numUDn;
        private System.Windows.Forms.NumericUpDown numUDN2;
        private System.Windows.Forms.NumericUpDown numUDk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.DataGridView dgvV;
        private System.Windows.Forms.DataGridView dgvD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label V;
        private System.Windows.Forms.Button button1;
    }
}

