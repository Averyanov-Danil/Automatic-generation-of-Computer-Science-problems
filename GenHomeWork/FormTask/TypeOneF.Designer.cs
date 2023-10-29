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
            this.label6 = new System.Windows.Forms.Label();
            this.lastNumSystem = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.btnAddTask = new FontAwesome.Sharp.IconButton();
            this.lblEndTask = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.initialNumSystem = new System.Windows.Forms.NumericUpDown();
            this.lblDescTask = new System.Windows.Forms.Label();
            this.panelInt = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.initialNum = new System.Windows.Forms.NumericUpDown();
            this.lastNum = new System.Windows.Forms.NumericUpDown();
            this.rbtnDouble = new System.Windows.Forms.RadioButton();
            this.rbtnInt = new System.Windows.Forms.RadioButton();
            this.panelIntOrDouble = new System.Windows.Forms.Panel();
            this.numDecimalPoints = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panelC1 = new System.Windows.Forms.Panel();
            this.mainLastNumSystem = new System.Windows.Forms.NumericUpDown();
            this.mainInitialNumSystem = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.rbtnC1 = new System.Windows.Forms.RadioButton();
            this.rbtnC10 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.lastNumSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialNumSystem)).BeginInit();
            this.panelInt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initialNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNum)).BeginInit();
            this.panelIntOrDouble.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDecimalPoints)).BeginInit();
            this.panelC1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLastNumSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainInitialNumSystem)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(551, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Конечное СС2";
            // 
            // lastNumSystem
            // 
            this.lastNumSystem.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.lastNumSystem.Location = new System.Drawing.Point(556, 134);
            this.lastNumSystem.Maximum = new decimal(new int[] {
            280,
            0,
            0,
            0});
            this.lastNumSystem.Name = "lastNumSystem";
            this.lastNumSystem.Size = new System.Drawing.Size(120, 20);
            this.lastNumSystem.TabIndex = 7;
            this.lastNumSystem.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.lastNumSystem.ValueChanged += new System.EventHandler(this.nudCC2_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(567, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Кол-во задач";
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(554, 202);
            this.nudCount.Maximum = new decimal(new int[] {
            300,
            0,
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
            this.btnAddTask.Location = new System.Drawing.Point(580, 254);
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
            this.lblEndTask.Location = new System.Drawing.Point(12, 225);
            this.lblEndTask.Name = "lblEndTask";
            this.lblEndTask.Size = new System.Drawing.Size(653, 26);
            this.lblEndTask.TabIndex = 9;
            this.lblEndTask.Text = "Итог:\r\nПеревести {число} с основанием {Основание 1}  в {от Конечное СС1 до Конечн" +
    "ое СС2} систему счисления.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(551, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Конечное СС1";
            // 
            // initialNumSystem
            // 
            this.initialNumSystem.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.initialNumSystem.Location = new System.Drawing.Point(556, 94);
            this.initialNumSystem.Maximum = new decimal(new int[] {
            280,
            0,
            0,
            0});
            this.initialNumSystem.Name = "initialNumSystem";
            this.initialNumSystem.Size = new System.Drawing.Size(120, 20);
            this.initialNumSystem.TabIndex = 7;
            this.initialNumSystem.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.initialNumSystem.ValueChanged += new System.EventHandler(this.numberSys3_ValueChanged);
            // 
            // lblDescTask
            // 
            this.lblDescTask.AutoSize = true;
            this.lblDescTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescTask.ForeColor = System.Drawing.Color.White;
            this.lblDescTask.Location = new System.Drawing.Point(26, 20);
            this.lblDescTask.Name = "lblDescTask";
            this.lblDescTask.Size = new System.Drawing.Size(653, 26);
            this.lblDescTask.TabIndex = 4;
            this.lblDescTask.Text = "Пример:\r\nПеревести {число} с основанием {Основание 1}  в {от Конечное СС1 до Коне" +
    "чное СС2} систему счисления.";
            this.lblDescTask.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelInt
            // 
            this.panelInt.Controls.Add(this.numDecimalPoints);
            this.panelInt.Controls.Add(this.label4);
            this.panelInt.Controls.Add(this.label1);
            this.panelInt.Controls.Add(this.label2);
            this.panelInt.Controls.Add(this.label3);
            this.panelInt.Controls.Add(this.initialNum);
            this.panelInt.Controls.Add(this.lastNum);
            this.panelInt.Location = new System.Drawing.Point(15, 115);
            this.panelInt.Name = "panelInt";
            this.panelInt.Size = new System.Drawing.Size(214, 84);
            this.panelInt.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 3);
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
            this.label2.Location = new System.Drawing.Point(5, 27);
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
            this.label3.Location = new System.Drawing.Point(112, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "До:";
            // 
            // initialNum
            // 
            this.initialNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.initialNum.Location = new System.Drawing.Point(37, 25);
            this.initialNum.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.initialNum.Name = "initialNum";
            this.initialNum.Size = new System.Drawing.Size(65, 20);
            this.initialNum.TabIndex = 11;
            this.initialNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.initialNum.ValueChanged += new System.EventHandler(this.initialNum_ValueChanged);
            // 
            // lastNum
            // 
            this.lastNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastNum.Location = new System.Drawing.Point(144, 25);
            this.lastNum.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.lastNum.Name = "lastNum";
            this.lastNum.Size = new System.Drawing.Size(65, 20);
            this.lastNum.TabIndex = 10;
            this.lastNum.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.lastNum.ValueChanged += new System.EventHandler(this.lastNum_ValueChanged_1);
            // 
            // rbtnDouble
            // 
            this.rbtnDouble.AutoSize = true;
            this.rbtnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnDouble.ForeColor = System.Drawing.Color.White;
            this.rbtnDouble.Location = new System.Drawing.Point(132, 5);
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
            this.rbtnInt.Checked = true;
            this.rbtnInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnInt.ForeColor = System.Drawing.Color.White;
            this.rbtnInt.Location = new System.Drawing.Point(3, 5);
            this.rbtnInt.Name = "rbtnInt";
            this.rbtnInt.Size = new System.Drawing.Size(123, 17);
            this.rbtnInt.TabIndex = 15;
            this.rbtnInt.TabStop = true;
            this.rbtnInt.Text = "Целочисленные ";
            this.rbtnInt.UseVisualStyleBackColor = true;
            // 
            // panelIntOrDouble
            // 
            this.panelIntOrDouble.Controls.Add(this.rbtnInt);
            this.panelIntOrDouble.Controls.Add(this.rbtnDouble);
            this.panelIntOrDouble.Location = new System.Drawing.Point(8, 85);
            this.panelIntOrDouble.Name = "panelIntOrDouble";
            this.panelIntOrDouble.Size = new System.Drawing.Size(246, 23);
            this.panelIntOrDouble.TabIndex = 12;
            // 
            // numDecimalPoints
            // 
            this.numDecimalPoints.Location = new System.Drawing.Point(88, 64);
            this.numDecimalPoints.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDecimalPoints.Name = "numDecimalPoints";
            this.numDecimalPoints.Size = new System.Drawing.Size(37, 20);
            this.numDecimalPoints.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Кол-во знаков после запятой";
            // 
            // panelC1
            // 
            this.panelC1.Controls.Add(this.label13);
            this.panelC1.Controls.Add(this.label14);
            this.panelC1.Controls.Add(this.label15);
            this.panelC1.Controls.Add(this.mainInitialNumSystem);
            this.panelC1.Controls.Add(this.mainLastNumSystem);
            this.panelC1.Location = new System.Drawing.Point(13, 65);
            this.panelC1.Name = "panelC1";
            this.panelC1.Size = new System.Drawing.Size(238, 49);
            this.panelC1.TabIndex = 12;
            // 
            // mainLastNumSystem
            // 
            this.mainLastNumSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainLastNumSystem.Location = new System.Drawing.Point(149, 19);
            this.mainLastNumSystem.Maximum = new decimal(new int[] {
            280,
            0,
            0,
            0});
            this.mainLastNumSystem.Name = "mainLastNumSystem";
            this.mainLastNumSystem.Size = new System.Drawing.Size(65, 20);
            this.mainLastNumSystem.TabIndex = 10;
            this.mainLastNumSystem.ValueChanged += new System.EventHandler(this.mainLastNumSystem_ValueChanged);
            // 
            // mainInitialNumSystem
            // 
            this.mainInitialNumSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainInitialNumSystem.Location = new System.Drawing.Point(46, 19);
            this.mainInitialNumSystem.Maximum = new decimal(new int[] {
            280,
            0,
            0,
            0});
            this.mainInitialNumSystem.Name = "mainInitialNumSystem";
            this.mainInitialNumSystem.Size = new System.Drawing.Size(65, 20);
            this.mainInitialNumSystem.TabIndex = 11;
            this.mainInitialNumSystem.ValueChanged += new System.EventHandler(this.mainInitialNumSystem_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(117, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "До:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(14, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "От:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(52, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Диапозон основания";
            // 
            // rbtnC1
            // 
            this.rbtnC1.AutoSize = true;
            this.rbtnC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnC1.ForeColor = System.Drawing.Color.White;
            this.rbtnC1.Location = new System.Drawing.Point(121, 25);
            this.rbtnC1.Name = "rbtnC1";
            this.rbtnC1.Size = new System.Drawing.Size(100, 17);
            this.rbtnC1.TabIndex = 13;
            this.rbtnC1.TabStop = true;
            this.rbtnC1.Text = "В диапозоне";
            this.rbtnC1.UseVisualStyleBackColor = true;
            this.rbtnC1.CheckedChanged += new System.EventHandler(this.rbtnC1_10_CheckedChanged);
            // 
            // rbtnC10
            // 
            this.rbtnC10.AutoSize = true;
            this.rbtnC10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.rbtnC10.ForeColor = System.Drawing.Color.White;
            this.rbtnC10.Location = new System.Drawing.Point(42, 25);
            this.rbtnC10.Name = "rbtnC10";
            this.rbtnC10.Size = new System.Drawing.Size(76, 17);
            this.rbtnC10.TabIndex = 13;
            this.rbtnC10.Text = "10\'ичное";
            this.rbtnC10.UseVisualStyleBackColor = true;
            this.rbtnC10.CheckedChanged += new System.EventHandler(this.rbtnC1_10_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(86, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Основание 1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.rbtnC10);
            this.panel2.Controls.Add(this.rbtnC1);
            this.panel2.Controls.Add(this.panelC1);
            this.panel2.Location = new System.Drawing.Point(265, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 134);
            this.panel2.TabIndex = 18;
            // 
            // TypeOneF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(700, 278);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelIntOrDouble);
            this.Controls.Add(this.panelInt);
            this.Controls.Add(this.lblEndTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.initialNumSystem);
            this.Controls.Add(this.lastNumSystem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDescTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TypeOneF";
            this.Text = "TypeOneF";
            ((System.ComponentModel.ISupportInitialize)(this.lastNumSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialNumSystem)).EndInit();
            this.panelInt.ResumeLayout(false);
            this.panelInt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.initialNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNum)).EndInit();
            this.panelIntOrDouble.ResumeLayout(false);
            this.panelIntOrDouble.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDecimalPoints)).EndInit();
            this.panelC1.ResumeLayout(false);
            this.panelC1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainLastNumSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainInitialNumSystem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown lastNumSystem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudCount;
        private FontAwesome.Sharp.IconButton btnAddTask;
        private System.Windows.Forms.Label lblEndTask;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown initialNumSystem;
        private System.Windows.Forms.Label lblDescTask;
        private System.Windows.Forms.Panel panelInt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown initialNum;
        private System.Windows.Forms.NumericUpDown lastNum;
        private System.Windows.Forms.RadioButton rbtnDouble;
        private System.Windows.Forms.RadioButton rbtnInt;
        private System.Windows.Forms.Panel panelIntOrDouble;
        private System.Windows.Forms.NumericUpDown numDecimalPoints;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelC1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown mainInitialNumSystem;
        private System.Windows.Forms.NumericUpDown mainLastNumSystem;
        private System.Windows.Forms.RadioButton rbtnC1;
        private System.Windows.Forms.RadioButton rbtnC10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
    }
}