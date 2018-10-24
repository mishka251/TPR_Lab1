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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox_matrixV = new System.Windows.Forms.GroupBox();
            this.groupBox_matrixD = new System.Windows.Forms.GroupBox();
            this.groupBox_InputDate = new System.Windows.Forms.GroupBox();
            this.label_D1 = new System.Windows.Forms.Label();
            this.label_V1 = new System.Windows.Forms.Label();
            this.dataGridView_InputDateD = new System.Windows.Forms.DataGridView();
            this.dataGridView_InputDateV = new System.Windows.Forms.DataGridView();
            this.pictureBox_Graph = new System.Windows.Forms.PictureBox();
            this.numericUpDown_startState = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_c = new System.Windows.Forms.DataGridView();
            this.dgv_p = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startState)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_p)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Start.Location = new System.Drawing.Point(20, 453);
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
            this.button_SaveModel.Location = new System.Drawing.Point(20, 403);
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
            this.button_LoadModel.Location = new System.Drawing.Point(20, 347);
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
            this.NumericUpDown_countM.ValueChanged += new System.EventHandler(this.NumericUpDown_countM_ValueChanged);
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
            this.NumericUpDown_countState.ValueChanged += new System.EventHandler(this.NumericUpDown_countState_ValueChanged);
            // 
            // NumericUpDown_countStr
            // 
            this.NumericUpDown_countStr.Location = new System.Drawing.Point(26, 144);
            this.NumericUpDown_countStr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_countStr.Name = "NumericUpDown_countStr";
            this.NumericUpDown_countStr.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDown_countStr.TabIndex = 5;
            this.NumericUpDown_countStr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_countStr.ValueChanged += new System.EventHandler(this.NumericUpDown_countStr_ValueChanged);
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
            this.button_CreateSystem.Location = new System.Drawing.Point(20, 297);
            this.button_CreateSystem.Name = "button_CreateSystem";
            this.button_CreateSystem.Size = new System.Drawing.Size(138, 28);
            this.button_CreateSystem.TabIndex = 9;
            this.button_CreateSystem.Text = "Создать систему";
            this.button_CreateSystem.UseVisualStyleBackColor = false;
            this.button_CreateSystem.Click += new System.EventHandler(this.Create_Click);
            // 
            // dgv_V
            // 
            this.dgv_V.AllowUserToAddRows = false;
            this.dgv_V.AllowUserToDeleteRows = false;
            this.dgv_V.AllowUserToResizeColumns = false;
            this.dgv_V.AllowUserToResizeRows = false;
            this.dgv_V.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_V.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_V.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_V.Location = new System.Drawing.Point(6, 19);
            this.dgv_V.Name = "dgv_V";
            this.dgv_V.ReadOnly = true;
            this.dgv_V.Size = new System.Drawing.Size(401, 121);
            this.dgv_V.TabIndex = 10;
            // 
            // dgv_D
            // 
            this.dgv_D.AllowUserToAddRows = false;
            this.dgv_D.AllowUserToDeleteRows = false;
            this.dgv_D.AllowUserToResizeColumns = false;
            this.dgv_D.AllowUserToResizeRows = false;
            this.dgv_D.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_D.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_D.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_D.Location = new System.Drawing.Point(6, 26);
            this.dgv_D.Name = "dgv_D";
            this.dgv_D.ReadOnly = true;
            this.dgv_D.Size = new System.Drawing.Size(401, 121);
            this.dgv_D.TabIndex = 11;
            // 
            // button_Graph
            // 
            this.button_Graph.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Graph.Location = new System.Drawing.Point(1209, 114);
            this.button_Graph.Name = "button_Graph";
            this.button_Graph.Size = new System.Drawing.Size(138, 28);
            this.button_Graph.TabIndex = 14;
            this.button_Graph.Text = "Граф";
            this.button_Graph.UseVisualStyleBackColor = false;
            this.button_Graph.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_Count
            // 
            this.groupBox_Count.Controls.Add(this.label5);
            this.groupBox_Count.Controls.Add(this.label_countState);
            this.groupBox_Count.Controls.Add(this.NumericUpDown_countM);
            this.groupBox_Count.Controls.Add(this.NumericUpDown_countState);
            this.groupBox_Count.Controls.Add(this.richTextBox1);
            this.groupBox_Count.Controls.Add(this.NumericUpDown_countStr);
            this.groupBox_Count.Controls.Add(this.label_countM);
            this.groupBox_Count.Controls.Add(this.label_countStr);
            this.groupBox_Count.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Count.Name = "groupBox_Count";
            this.groupBox_Count.Size = new System.Drawing.Size(210, 264);
            this.groupBox_Count.TabIndex = 15;
            this.groupBox_Count.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 188);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 32);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // groupBox_matrixV
            // 
            this.groupBox_matrixV.Controls.Add(this.dgv_V);
            this.groupBox_matrixV.Location = new System.Drawing.Point(237, 358);
            this.groupBox_matrixV.Name = "groupBox_matrixV";
            this.groupBox_matrixV.Size = new System.Drawing.Size(429, 147);
            this.groupBox_matrixV.TabIndex = 16;
            this.groupBox_matrixV.TabStop = false;
            this.groupBox_matrixV.Text = "Матрица V";
            // 
            // groupBox_matrixD
            // 
            this.groupBox_matrixD.Controls.Add(this.dgv_D);
            this.groupBox_matrixD.Location = new System.Drawing.Point(237, 520);
            this.groupBox_matrixD.Name = "groupBox_matrixD";
            this.groupBox_matrixD.Size = new System.Drawing.Size(443, 147);
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
            this.groupBox_InputDate.Location = new System.Drawing.Point(237, 12);
            this.groupBox_InputDate.Name = "groupBox_InputDate";
            this.groupBox_InputDate.Size = new System.Drawing.Size(394, 323);
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
            this.dataGridView_InputDateD.Location = new System.Drawing.Point(7, 202);
            this.dataGridView_InputDateD.Name = "dataGridView_InputDateD";
            this.dataGridView_InputDateD.Size = new System.Drawing.Size(422, 121);
            this.dataGridView_InputDateD.TabIndex = 1;
            // 
            // dataGridView_InputDateV
            // 
            this.dataGridView_InputDateV.AllowUserToAddRows = false;
            this.dataGridView_InputDateV.AllowUserToDeleteRows = false;
            this.dataGridView_InputDateV.AllowUserToResizeColumns = false;
            this.dataGridView_InputDateV.AllowUserToResizeRows = false;
            this.dataGridView_InputDateV.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_InputDateV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_InputDateV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_InputDateV.Location = new System.Drawing.Point(6, 41);
            this.dataGridView_InputDateV.Name = "dataGridView_InputDateV";
            this.dataGridView_InputDateV.Size = new System.Drawing.Size(458, 121);
            this.dataGridView_InputDateV.TabIndex = 0;
            // 
            // pictureBox_Graph
            // 
            this.pictureBox_Graph.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_Graph.Location = new System.Drawing.Point(672, 12);
            this.pictureBox_Graph.Name = "pictureBox_Graph";
            this.pictureBox_Graph.Size = new System.Drawing.Size(482, 178);
            this.pictureBox_Graph.TabIndex = 11;
            this.pictureBox_Graph.TabStop = false;
            // 
            // numericUpDown_startState
            // 
            this.numericUpDown_startState.Location = new System.Drawing.Point(1225, 72);
            this.numericUpDown_startState.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_startState.Name = "numericUpDown_startState";
            this.numericUpDown_startState.Size = new System.Drawing.Size(122, 20);
            this.numericUpDown_startState.TabIndex = 19;
            this.numericUpDown_startState.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1210, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Выбор начального состояния";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgv_c);
            this.panel1.Controls.Add(this.dgv_p);
            this.panel1.Location = new System.Drawing.Point(686, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 256);
            this.panel1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(131, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Название";
            // 
            // tbName
            // 
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(294, 228);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(188, 20);
            this.tbName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(278, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "матрица доходностей";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(28, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Матрица вероятностей";
            // 
            // dgv_c
            // 
            this.dgv_c.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_c.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_c.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_c.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_c.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_c.Location = new System.Drawing.Point(272, 19);
            this.dgv_c.Name = "dgv_c";
            this.dgv_c.Size = new System.Drawing.Size(210, 193);
            this.dgv_c.TabIndex = 9;
            // 
            // dgv_p
            // 
            this.dgv_p.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_p.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_p.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_p.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_p.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_p.Location = new System.Drawing.Point(14, 19);
            this.dgv_p.Name = "dgv_p";
            this.dgv_p.Size = new System.Drawing.Size(205, 193);
            this.dgv_p.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Названия состояний";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_startState);
            this.Controls.Add(this.pictureBox_Graph);
            this.Controls.Add(this.groupBox_InputDate);
            this.Controls.Add(this.groupBox_matrixD);
            this.Controls.Add(this.groupBox_matrixV);
            this.Controls.Add(this.groupBox_Count);
            this.Controls.Add(this.button_CreateSystem);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startState)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox_Graph;
        private System.Windows.Forms.NumericUpDown numericUpDown_startState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_c;
        private System.Windows.Forms.DataGridView dgv_p;
        private System.Windows.Forms.Label label5;
    }
}

