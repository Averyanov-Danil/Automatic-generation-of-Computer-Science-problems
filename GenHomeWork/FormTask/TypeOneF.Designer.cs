namespace GenHomeWork.FormTask
{
    partial class TypeOneF
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
            this.numberSys1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numberSys2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddTask = new FontAwesome.Sharp.IconButton();
            this.lblEndTask = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberSys3 = new System.Windows.Forms.NumericUpDown();
            this.lblDescTask = new System.Windows.Forms.Label();
            this.panelInt = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudStart = new System.Windows.Forms.NumericUpDown();
            this.nudEnd = new System.Windows.Forms.NumericUpDown();
            this.rbtnDouble = new System.Windows.Forms.RadioButton();
            this.rbtnInt = new System.Windows.Forms.RadioButton();
            this.panelDouble = new System.Windows.Forms.Panel();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberSys1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSys2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSys3)).BeginInit();
            this.panelInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).BeginInit();
            this.panelDouble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // numberSys1
            // 
            this.numberSys1.Location = new System.Drawing.Point(72, 183);
            this.numberSys1.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numberSys1.Name = "numberSys1";
            this.numberSys1.Size = new System.Drawing.Size(120, 20);
            this.numberSys1.TabIndex = 7;
            this.numberSys1.ValueChanged += new System.EventHandler(this.nudCC1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(90, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Основание 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(258, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Конечное СС1";
            // 
            // numberSys2
            // 
            this.numberSys2.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberSys2.Location = new System.Drawing.Point(263, 117);
            this.numberSys2.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numberSys2.Name = "numberSys2";
            this.numberSys2.Size = new System.Drawing.Size(120, 20);
            this.numberSys2.TabIndex = 7;
            this.numberSys2.ValueChanged += new System.EventHandler(this.nudCC2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(434, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Кол-во задач";
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(421, 117);
            this.nudCount.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(120, 20);
            this.nudCount.TabIndex = 7;
            this.nudCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTask.ForeColor = System.Drawing.Color.White;
            this.btnAddTask.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btnAddTask.IconColor = System.Drawing.Color.White;
            this.btnAddTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTask.IconSize = 30;
            this.btnAddTask.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTask.Location = new System.Drawing.Point(437, 232);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(118, 23);
            this.btnAddTask.TabIndex = 8;
            this.btnAddTask.Text = "Добавить";
            this.btnAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // lblEndTask
            // 
            this.lblEndTask.AutoSize = true;
            this.lblEndTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEndTask.ForeColor = System.Drawing.Color.White;
            this.lblEndTask.Location = new System.Drawing.Point(12, 203);
            this.lblEndTask.Name = "lblEndTask";
            this.lblEndTask.Size = new System.Drawing.Size(542, 26);
            this.lblEndTask.TabIndex = 9;
            this.lblEndTask.Text = "Итог:\r\nПеревести {число} с основанием {Основание СС}  в {Основание СС} систему сч" +
    "исления.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(256, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Конечное СС2";
            // 
            // numberSys3
            // 
            this.numberSys3.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberSys3.Location = new System.Drawing.Point(261, 182);
            this.numberSys3.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numberSys3.Name = "numberSys3";
            this.numberSys3.Size = new System.Drawing.Size(120, 20);
            this.numberSys3.TabIndex = 7;
            this.numberSys3.ValueChanged += new System.EventHandler(this.numberSys3_ValueChanged);
            // 
            // lblDescTask
            // 
            this.lblDescTask.AutoSize = true;
            this.lblDescTask.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescTask.ForeColor = System.Drawing.Color.White;
            this.lblDescTask.Location = new System.Drawing.Point(0, 0);
            this.lblDescTask.Name = "lblDescTask";
            this.lblDescTask.Size = new System.Drawing.Size(534, 39);
            this.lblDescTask.TabIndex = 4;
            this.lblDescTask.Text = "Пример:\r\nПеревести {число} с основанием {Основание 1}  в {от Конечное СС1 до Коне" +
    "чное СС2} \r\nсистему счисления.";
            // 
            // panelInt
            // 
            this.panelInt.Controls.Add(this.label1);
            this.panelInt.Controls.Add(this.label2);
            this.panelInt.Controls.Add(this.label3);
            this.panelInt.Controls.Add(this.nudStart);
            this.panelInt.Controls.Add(this.nudEnd);
            this.panelInt.Location = new System.Drawing.Point(23, 75);
            this.panelInt.Name = "panelInt";
            this.panelInt.Size = new System.Drawing.Size(214, 84);
            this.panelInt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Диапозон чисел";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "От:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(110, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "До:";
            // 
            // nudStart
            // 
            this.nudStart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudStart.Location = new System.Drawing.Point(39, 41);
            this.nudStart.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudStart.Name = "nudStart";
            this.nudStart.Size = new System.Drawing.Size(65, 20);
            this.nudStart.TabIndex = 11;
            // 
            // nudEnd
            // 
            this.nudEnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudEnd.Location = new System.Drawing.Point(142, 41);
            this.nudEnd.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudEnd.Name = "nudEnd";
            this.nudEnd.Size = new System.Drawing.Size(65, 20);
            this.nudEnd.TabIndex = 10;
            // 
            // rbtnDouble
            // 
            this.rbtnDouble.AutoSize = true;
            this.rbtnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnDouble.ForeColor = System.Drawing.Color.White;
            this.rbtnDouble.Location = new System.Drawing.Point(139, 58);
            this.rbtnDouble.Name = "rbtnDouble";
            this.rbtnDouble.Size = new System.Drawing.Size(114, 17);
            this.rbtnDouble.TabIndex = 14;
            this.rbtnDouble.TabStop = true;
            this.rbtnDouble.Text = "Вещественные";
            this.rbtnDouble.UseVisualStyleBackColor = true;
            // 
            // rbtnInt
            // 
            this.rbtnInt.AutoSize = true;
            this.rbtnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnInt.ForeColor = System.Drawing.Color.White;
            this.rbtnInt.Location = new System.Drawing.Point(15, 58);
            this.rbtnInt.Name = "rbtnInt";
            this.rbtnInt.Size = new System.Drawing.Size(123, 17);
            this.rbtnInt.TabIndex = 15;
            this.rbtnInt.TabStop = true;
            this.rbtnInt.Text = "Целочисленные ";
            this.rbtnInt.UseVisualStyleBackColor = true;
            // 
            // panelDouble
            // 
            this.panelDouble.Controls.Add(this.numericUpDown3);
            this.panelDouble.Controls.Add(this.label8);
            this.panelDouble.Controls.Add(this.label9);
            this.panelDouble.Controls.Add(this.label10);
            this.panelDouble.Controls.Add(this.numericUpDown1);
            this.panelDouble.Controls.Add(this.label11);
            this.panelDouble.Controls.Add(this.numericUpDown2);
            this.panelDouble.Location = new System.Drawing.Point(563, 42);
            this.panelDouble.Name = "panelDouble";
            this.panelDouble.Size = new System.Drawing.Size(214, 84);
            this.panelDouble.TabIndex = 16;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(91, 58);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(37, 20);
            this.numericUpDown3.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Кол-во знаков после запятой";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(60, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Диапозон чисел";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(5, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "От:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Location = new System.Drawing.Point(140, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(108, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "До:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown2.Location = new System.Drawing.Point(37, 19);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 20);
            this.numericUpDown2.TabIndex = 11;
            // 
            // TypeOneF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(567, 267);
            this.Controls.Add(this.panelDouble);
            this.Controls.Add(this.rbtnDouble);
            this.Controls.Add(this.rbtnInt);
            this.Controls.Add(this.panelInt);
            this.Controls.Add(this.lblEndTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.numberSys3);
            this.Controls.Add(this.numberSys2);
            this.Controls.Add(this.numberSys1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDescTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TypeOneF";
            this.Text = "TypeOneF";
            ((System.ComponentModel.ISupportInitialize)(this.numberSys1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSys2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberSys3)).EndInit();
            this.panelInt.ResumeLayout(false);
            this.panelInt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnd)).EndInit();
            this.panelDouble.ResumeLayout(false);
            this.panelDouble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numberSys1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numberSys2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCount;
        private FontAwesome.Sharp.IconButton btnAddTask;
        private System.Windows.Forms.Label lblEndTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numberSys3;
        private System.Windows.Forms.Label lblDescTask;
        private System.Windows.Forms.Panel panelInt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudStart;
        private System.Windows.Forms.NumericUpDown nudEnd;
        private System.Windows.Forms.RadioButton rbtnDouble;
        private System.Windows.Forms.RadioButton rbtnInt;
        private System.Windows.Forms.Panel panelDouble;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}