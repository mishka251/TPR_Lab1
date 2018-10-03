namespace TPR_Lab1
{
    partial class Form_Main
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
            this.button_Start = new System.Windows.Forms.Button();
            this.button_SaveModel = new System.Windows.Forms.Button();
            this.button_LoadModel = new System.Windows.Forms.Button();
            this.NumericUpDown_countM = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_countState = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDown_countStr = new System.Windows.Forms.NumericUpDown();
            this.label_countM = new System.Windows.Forms.Label();
            this.label_countStr = new System.Windows.Forms.Label();
            this.label_countState = new System.Windows.Forms.Label();
            this.button_CreateSystem = new System.Windows.Forms.Button();
            this.dgv_V = new System.Windows.Forms.DataGridView();
            this.dgv_D = new System.Windows.Forms.DataGridView();
            this.button_Graph = new System.Windows.Forms.Button();
            this.groupBox_Count = new System.Windows.Forms.GroupBox();
            this.groupBox_matrixV = new System.Windows.Forms.GroupBox();
            this.groupBox_matrixD = new System.Windows.Forms.GroupBox();
            this.groupBox_InputDate = new System.Windows.Forms.GroupBox();
            this.label_D1 = new System.Windows.Forms.Label();
            this.label_V1 = new System.Windows.Forms.Label();
            this.dataGridView_InputDateD = new System.Windows.Forms.DataGridView();
            this.dataGridView_InputDateV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_countM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_countState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_countStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_D)).BeginInit();
            this.groupBox_Count.SuspendLayout();
            this.groupBox_matrixV.SuspendLayout();
            this.groupBox_matrixD.SuspendLayout();
            this.groupBox_InputDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InputDateD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InputDateV)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Start.Location = new System.Drawing.Point(61, 361);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(138, 28);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Вычислить";
            this.button_Start.UseVisualStyleBackColor = false;
            this.button_Start.Click += new System.EventHandler(this.start_Click);
            // 
            // button_SaveModel
            // 
            this.button_SaveModel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_SaveModel.Location = new System.Drawing.Point(61, 310);
            this.button_SaveModel.Name = "button_SaveModel";
            this.button_SaveModel.Size = new System.Drawing.Size(138, 28);
            this.button_SaveModel.TabIndex = 1;
            this.button_SaveModel.Text = "Сохранить модель";
            this.button_SaveModel.UseVisualStyleBackColor = false;
            this.button_SaveModel.Click += new System.EventHandler(this.Save_Click);
            // 
            // button_LoadModel
            // 
            this.button_LoadModel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_LoadModel.Location = new System.Drawing.Point(61, 276);
            this.button_LoadModel.Name = "button_LoadModel";
            this.button_LoadModel.Size = new System.Drawing.Size(138, 28);
            this.button_LoadModel.TabIndex = 2;
            this.button_LoadModel.Text = "Загрузить модель";
            this.button_LoadModel.UseVisualStyleBackColor = false;
            this.button_LoadModel.Click += new System.EventHandler(this.Load_Click);
            // 
            // NumericUpDown_countM
            // 
            this.NumericUpDown_countM.Location = new System.Drawing.Point(26, 41);
            this.NumericUpDown_countM.Name = "NumericUpDown_countM";
            this.NumericUpDown_countM.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDown_countM.TabIndex = 3;
            this.NumericUpDown_countM.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // NumericUpDown_countState
            // 
            this.NumericUpDown_countState.Location = new System.Drawing.Point(26, 91);
            this.NumericUpDown_countState.Name = "NumericUpDown_countState";
            this.NumericUpDown_countState.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDown_countState.TabIndex = 4;
            this.NumericUpDown_countState.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // NumericUpDown_countStr
            // 
            this.NumericUpDown_countStr.Location = new System.Drawing.Point(26, 144);
            this.NumericUpDown_countStr.Name = "NumericUpDown_countStr";
            this.NumericUpDown_countStr.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDown_countStr.TabIndex = 5;
            this.NumericUpDown_countStr.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label_countM
            // 
            this.label_countM.AutoSize = true;
            this.label_countM.Location = new System.Drawing.Point(23, 25);
            this.label_countM.Name = "label_countM";
            this.label_countM.Size = new System.Drawing.Size(141, 13);
            this.label_countM.TabIndex = 6;
            this.label_countM.Text = "Количество шагов модели";
            // 
            // label_countStr
            // 
            this.label_countStr.AutoSize = true;
            this.label_countStr.Location = new System.Drawing.Point(23, 128);
            this.label_countStr.Name = "label_countStr";
            this.label_countStr.Size = new System.Drawing.Size(120, 13);
            this.label_countStr.TabIndex = 7;
            this.label_countStr.Text = "Количество стратегий";
            // 
            // label_countState
            // 
            this.label_countState.AutoSize = true;
            this.label_countState.Location = new System.Drawing.Point(23, 75);
            this.label_countState.Name = "label_countState";
            this.label_countState.Size = new System.Drawing.Size(122, 13);
            this.label_countState.TabIndex = 8;
            this.label_countState.Text = "Количество состояний";
            // 
            // button_CreateSystem
            // 
            this.button_CreateSystem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_CreateSystem.Location = new System.Drawing.Point(26, 183);
            this.button_CreateSystem.Name = "button_CreateSystem";
            this.button_CreateSystem.Size = new System.Drawing.Size(138, 28);
            this.button_CreateSystem.TabIndex = 9;
            this.button_CreateSystem.Text = "Создать систему";
            this.button_CreateSystem.UseVisualStyleBackColor = false;
            this.button_CreateSystem.Click += new System.EventHandler(this.Create_Click);
            // 
            // dgv_V
            // 
            this.dgv_V.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_V.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_V.Location = new System.Drawing.Point(6, 19);
            this.dgv_V.Name = "dgv_V";
            this.dgv_V.Size = new System.Drawing.Size(596, 121);
            this.dgv_V.TabIndex = 10;
            // 
            // dgv_D
            // 
            this.dgv_D.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_D.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_D.Location = new System.Drawing.Point(6, 19);
            this.dgv_D.Name = "dgv_D";
            this.dgv_D.Size = new System.Drawing.Size(596, 121);
            this.dgv_D.TabIndex = 11;
            // 
            // button_Graph
            // 
            this.button_Graph.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Graph.Location = new System.Drawing.Point(61, 407);
            this.button_Graph.Name = "button_Graph";
            this.button_Graph.Size = new System.Drawing.Size(138, 28);
            this.button_Graph.TabIndex = 14;
            this.button_Graph.Text = "Граф";
            this.button_Graph.UseVisualStyleBackColor = false;
            this.button_Graph.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_Count
            // 
            this.groupBox_Count.Controls.Add(this.label_countState);
            this.groupBox_Count.Controls.Add(this.NumericUpDown_countM);
            this.groupBox_Count.Controls.Add(this.NumericUpDown_countState);
            this.groupBox_Count.Controls.Add(this.NumericUpDown_countStr);
            this.groupBox_Count.Controls.Add(this.label_countM);
            this.groupBox_Count.Controls.Add(this.label_countStr);
            this.groupBox_Count.Controls.Add(this.button_CreateSystem);
            this.groupBox_Count.Location = new System.Drawing.Point(35, 31);
            this.groupBox_Count.Name = "groupBox_Count";
            this.groupBox_Count.Size = new System.Drawing.Size(206, 226);
            this.groupBox_Count.TabIndex = 15;
            this.groupBox_Count.TabStop = false;
            // 
            // groupBox_matrixV
            // 
            this.groupBox_matrixV.Controls.Add(this.dgv_V);
            this.groupBox_matrixV.Location = new System.Drawing.Point(251, 372);
            this.groupBox_matrixV.Name = "groupBox_matrixV";
            this.groupBox_matrixV.Size = new System.Drawing.Size(608, 147);
            this.groupBox_matrixV.TabIndex = 16;
            this.groupBox_matrixV.TabStop = false;
            this.groupBox_matrixV.Text = "Матрица V";
            // 
            // groupBox_matrixD
            // 
            this.groupBox_matrixD.Controls.Add(this.dgv_D);
            this.groupBox_matrixD.Location = new System.Drawing.Point(251, 543);
            this.groupBox_matrixD.Name = "groupBox_matrixD";
            this.groupBox_matrixD.Size = new System.Drawing.Size(608, 147);
            this.groupBox_matrixD.TabIndex = 11;
            this.groupBox_matrixD.TabStop = false;
            this.groupBox_matrixD.Text = "Матрица D";
            // 
            // groupBox_InputDate
            // 
            this.groupBox_InputDate.Controls.Add(this.label_D1);
            this.groupBox_InputDate.Controls.Add(this.label_V1);
            this.groupBox_InputDate.Controls.Add(this.dataGridView_InputDateD);
            this.groupBox_InputDate.Controls.Add(this.dataGridView_InputDateV);
            this.groupBox_InputDate.Location = new System.Drawing.Point(251, 31);
            this.groupBox_InputDate.Name = "groupBox_InputDate";
            this.groupBox_InputDate.Size = new System.Drawing.Size(608, 323);
            this.groupBox_InputDate.TabIndex = 17;
            this.groupBox_InputDate.TabStop = false;
            this.groupBox_InputDate.Text = "Входные данные";
            // 
            // label_D1
            // 
            this.label_D1.AutoSize = true;
            this.label_D1.Location = new System.Drawing.Point(212, 180);
            this.label_D1.Name = "label_D1";
            this.label_D1.Size = new System.Drawing.Size(118, 13);
            this.label_D1.TabIndex = 3;
            this.label_D1.Text = "Матрица доходностей";
            // 
            // label_V1
            // 
            this.label_V1.AutoSize = true;
            this.label_V1.Location = new System.Drawing.Point(183, 25);
            this.label_V1.Name = "label_V1";
            this.label_V1.Size = new System.Drawing.Size(187, 13);
            this.label_V1.TabIndex = 2;
            this.label_V1.Text = "Матрица переходных вероятностей";
            // 
            // dataGridView_InputDateD
            // 
            this.dataGridView_InputDateD.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_InputDateD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_InputDateD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_InputDateD.Location = new System.Drawing.Point(7, 196);
            this.dataGridView_InputDateD.Name = "dataGridView_InputDateD";
            this.dataGridView_InputDateD.Size = new System.Drawing.Size(595, 121);
            this.dataGridView_InputDateD.TabIndex = 1;
            // 
            // dataGridView_InputDateV
            // 
            this.dataGridView_InputDateV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_InputDateV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_InputDateV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_InputDateV.Location = new System.Drawing.Point(6, 41);
            this.dataGridView_InputDateV.Name = "dataGridView_InputDateV";
            this.dataGridView_InputDateV.Size = new System.Drawing.Size(596, 121);
            this.dataGridView_InputDateV.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(893, 702);
            this.Controls.Add(this.groupBox_InputDate);
            this.Controls.Add(this.groupBox_matrixD);
            this.Controls.Add(this.groupBox_matrixV);
            this.Controls.Add(this.groupBox_Count);
            this.Controls.Add(this.button_Graph);
            this.Controls.Add(this.button_LoadModel);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_SaveModel);
            this.Name = "Form_Main";
            this.Text = "Лабораторная работа № 1. Дискретные марковские процессы";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_countM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_countState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_countStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_V)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_D)).EndInit();
            this.groupBox_Count.ResumeLayout(false);
            this.groupBox_Count.PerformLayout();
            this.groupBox_matrixV.ResumeLayout(false);
            this.groupBox_matrixD.ResumeLayout(false);
            this.groupBox_InputDate.ResumeLayout(false);
            this.groupBox_InputDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InputDateD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_InputDateV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_SaveModel;
        private System.Windows.Forms.Button button_LoadModel;
        private System.Windows.Forms.NumericUpDown NumericUpDown_countM;
        private System.Windows.Forms.NumericUpDown NumericUpDown_countState;
        private System.Windows.Forms.NumericUpDown NumericUpDown_countStr;
        private System.Windows.Forms.Label label_countM;
        private System.Windows.Forms.Label label_countStr;
        private System.Windows.Forms.Label label_countState;
        private System.Windows.Forms.Button button_CreateSystem;
        private System.Windows.Forms.DataGridView dgv_V;
        private System.Windows.Forms.DataGridView dgv_D;
        private System.Windows.Forms.Button button_Graph;
        private System.Windows.Forms.GroupBox groupBox_Count;
        private System.Windows.Forms.GroupBox groupBox_matrixV;
        private System.Windows.Forms.GroupBox groupBox_matrixD;
        private System.Windows.Forms.GroupBox groupBox_InputDate;
        private System.Windows.Forms.Label label_D1;
        private System.Windows.Forms.Label label_V1;
        private System.Windows.Forms.DataGridView dataGridView_InputDateD;
        private System.Windows.Forms.DataGridView dataGridView_InputDateV;
    }
}

