namespace TPR_Lab1
{
    partial class GraphForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox_Graph = new System.Windows.Forms.PictureBox();
            this.button_Draw = new System.Windows.Forms.Button();
            this.numericUpDown_startState = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startState)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Graph
            // 
            this.pictureBox_Graph.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Graph.Name = "pictureBox_Graph";
            this.pictureBox_Graph.Size = new System.Drawing.Size(670, 372);
            this.pictureBox_Graph.TabIndex = 0;
            this.pictureBox_Graph.TabStop = false;
            // 
            // button_Draw
            // 
            this.button_Draw.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Draw.Location = new System.Drawing.Point(710, 225);
            this.button_Draw.Name = "button_Draw";
            this.button_Draw.Size = new System.Drawing.Size(154, 28);
            this.button_Draw.TabIndex = 1;
            this.button_Draw.Text = "Нарисовать граф";
            this.button_Draw.UseVisualStyleBackColor = false;
            this.button_Draw.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown_startState
            // 
            this.numericUpDown_startState.Location = new System.Drawing.Point(710, 94);
            this.numericUpDown_startState.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_startState.Name = "numericUpDown_startState";
            this.numericUpDown_startState.Size = new System.Drawing.Size(154, 20);
            this.numericUpDown_startState.TabIndex = 2;
            this.numericUpDown_startState.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор начального состояния";
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_startState);
            this.Controls.Add(this.button_Draw);
            this.Controls.Add(this.pictureBox_Graph);
            this.MaximumSize = new System.Drawing.Size(906, 431);
            this.MinimumSize = new System.Drawing.Size(906, 431);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_startState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Graph;
        private System.Windows.Forms.Button button_Draw;
        private System.Windows.Forms.NumericUpDown numericUpDown_startState;
        private System.Windows.Forms.Label label1;
    }
}