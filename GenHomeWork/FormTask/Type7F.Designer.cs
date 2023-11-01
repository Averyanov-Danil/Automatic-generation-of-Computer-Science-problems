namespace GenHomeWork.FormTask
{
    partial class Type7F
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Type7F));
            this.btnAddTask = new FontAwesome.Sharp.IconButton();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbtn2cRandom = new System.Windows.Forms.RadioButton();
            this.rbtn2c16 = new System.Windows.Forms.RadioButton();
            this.rbtn2c8 = new System.Windows.Forms.RadioButton();
            this.rbtn2c2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnCRandom = new System.Windows.Forms.RadioButton();
            this.rbtnC16 = new System.Windows.Forms.RadioButton();
            this.rbtnC8 = new System.Windows.Forms.RadioButton();
            this.rbtnC2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNum = new System.Windows.Forms.NumericUpDown();
            this.initialNum = new System.Windows.Forms.NumericUpDown();
            this.lblDescTask = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtn3cRandom = new System.Windows.Forms.RadioButton();
            this.rbtn3c16 = new System.Windows.Forms.RadioButton();
            this.rbtn3c8 = new System.Windows.Forms.RadioButton();
            this.rbtn3c2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialNum)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.btnAddTask.Location = new System.Drawing.Point(574, 243);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(118, 23);
            this.btnAddTask.TabIndex = 64;
            this.btnAddTask.Text = "Добавить";
            this.btnAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // nudCount
            // 
            this.nudCount.Location = new System.Drawing.Point(569, 175);
            this.nudCount.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(120, 20);
            this.nudCount.TabIndex = 63;
            this.nudCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(582, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Кол-во задач";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbtn2cRandom);
            this.panel3.Controls.Add(this.rbtn2c16);
            this.panel3.Controls.Add(this.rbtn2c8);
            this.panel3.Controls.Add(this.rbtn2c2);
            this.panel3.Location = new System.Drawing.Point(205, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(162, 95);
            this.panel3.TabIndex = 59;
            // 
            // rbtn2cRandom
            // 
            this.rbtn2cRandom.AutoSize = true;
            this.rbtn2cRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn2cRandom.ForeColor = System.Drawing.Color.White;
            this.rbtn2cRandom.Location = new System.Drawing.Point(3, 72);
            this.rbtn2cRandom.Name = "rbtn2cRandom";
            this.rbtn2cRandom.Size = new System.Drawing.Size(155, 17);
            this.rbtn2cRandom.TabIndex = 41;
            this.rbtn2cRandom.Text = "Основание случайное";
            this.rbtn2cRandom.UseVisualStyleBackColor = true;
            this.rbtn2cRandom.CheckedChanged += new System.EventHandler(this.rbtn2cRandom_CheckedChanged);
            // 
            // rbtn2c16
            // 
            this.rbtn2c16.AutoSize = true;
            this.rbtn2c16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn2c16.ForeColor = System.Drawing.Color.White;
            this.rbtn2c16.Location = new System.Drawing.Point(3, 49);
            this.rbtn2c16.Name = "rbtn2c16";
            this.rbtn2c16.Size = new System.Drawing.Size(108, 17);
            this.rbtn2c16.TabIndex = 42;
            this.rbtn2c16.Text = "Основание 16";
            this.rbtn2c16.UseVisualStyleBackColor = true;
            this.rbtn2c16.CheckedChanged += new System.EventHandler(this.rbtn2cRandom_CheckedChanged);
            // 
            // rbtn2c8
            // 
            this.rbtn2c8.AutoSize = true;
            this.rbtn2c8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn2c8.ForeColor = System.Drawing.Color.White;
            this.rbtn2c8.Location = new System.Drawing.Point(3, 26);
            this.rbtn2c8.Name = "rbtn2c8";
            this.rbtn2c8.Size = new System.Drawing.Size(101, 17);
            this.rbtn2c8.TabIndex = 43;
            this.rbtn2c8.Text = "Основание 8";
            this.rbtn2c8.UseVisualStyleBackColor = true;
            this.rbtn2c8.CheckedChanged += new System.EventHandler(this.rbtn2cRandom_CheckedChanged);
            // 
            // rbtn2c2
            // 
            this.rbtn2c2.AutoSize = true;
            this.rbtn2c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn2c2.ForeColor = System.Drawing.Color.White;
            this.rbtn2c2.Location = new System.Drawing.Point(3, 3);
            this.rbtn2c2.Name = "rbtn2c2";
            this.rbtn2c2.Size = new System.Drawing.Size(101, 17);
            this.rbtn2c2.TabIndex = 44;
            this.rbtn2c2.Text = "Основание 2";
            this.rbtn2c2.UseVisualStyleBackColor = true;
            this.rbtn2c2.CheckedChanged += new System.EventHandler(this.rbtn2cRandom_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnCRandom);
            this.panel1.Controls.Add(this.rbtnC16);
            this.panel1.Controls.Add(this.rbtnC8);
            this.panel1.Controls.Add(this.rbtnC2);
            this.panel1.Location = new System.Drawing.Point(17, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 95);
            this.panel1.TabIndex = 60;
            // 
            // rbtnCRandom
            // 
            this.rbtnCRandom.AutoSize = true;
            this.rbtnCRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnCRandom.ForeColor = System.Drawing.Color.White;
            this.rbtnCRandom.Location = new System.Drawing.Point(3, 72);
            this.rbtnCRandom.Name = "rbtnCRandom";
            this.rbtnCRandom.Size = new System.Drawing.Size(155, 17);
            this.rbtnCRandom.TabIndex = 41;
            this.rbtnCRandom.Text = "Основание случайное";
            this.rbtnCRandom.UseVisualStyleBackColor = true;
            this.rbtnCRandom.CheckedChanged += new System.EventHandler(this.rbtnCRandom_CheckedChanged);
            // 
            // rbtnC16
            // 
            this.rbtnC16.AutoSize = true;
            this.rbtnC16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnC16.ForeColor = System.Drawing.Color.White;
            this.rbtnC16.Location = new System.Drawing.Point(3, 49);
            this.rbtnC16.Name = "rbtnC16";
            this.rbtnC16.Size = new System.Drawing.Size(108, 17);
            this.rbtnC16.TabIndex = 42;
            this.rbtnC16.Text = "Основание 16";
            this.rbtnC16.UseVisualStyleBackColor = true;
            this.rbtnC16.CheckedChanged += new System.EventHandler(this.rbtnCRandom_CheckedChanged);
            // 
            // rbtnC8
            // 
            this.rbtnC8.AutoSize = true;
            this.rbtnC8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnC8.ForeColor = System.Drawing.Color.White;
            this.rbtnC8.Location = new System.Drawing.Point(3, 26);
            this.rbtnC8.Name = "rbtnC8";
            this.rbtnC8.Size = new System.Drawing.Size(101, 17);
            this.rbtnC8.TabIndex = 43;
            this.rbtnC8.Text = "Основание 8";
            this.rbtnC8.UseVisualStyleBackColor = true;
            this.rbtnC8.CheckedChanged += new System.EventHandler(this.rbtnCRandom_CheckedChanged);
            // 
            // rbtnC2
            // 
            this.rbtnC2.AutoSize = true;
            this.rbtnC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtnC2.ForeColor = System.Drawing.Color.White;
            this.rbtnC2.Location = new System.Drawing.Point(3, 3);
            this.rbtnC2.Name = "rbtnC2";
            this.rbtnC2.Size = new System.Drawing.Size(101, 17);
            this.rbtnC2.TabIndex = 44;
            this.rbtnC2.Text = "Основание 2";
            this.rbtnC2.UseVisualStyleBackColor = true;
            this.rbtnC2.CheckedChanged += new System.EventHandler(this.rbtnCRandom_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(280, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Диапозон числа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(209, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 55;
            this.label5.Text = "с2 - Основание 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "с1 - Основание 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(219, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "От:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(347, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "До:";
            // 
            // lastNum
            // 
            this.lastNum.Location = new System.Drawing.Point(383, 81);
            this.lastNum.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.lastNum.Name = "lastNum";
            this.lastNum.Size = new System.Drawing.Size(65, 20);
            this.lastNum.TabIndex = 51;
            this.lastNum.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // initialNum
            // 
            this.initialNum.Location = new System.Drawing.Point(255, 81);
            this.initialNum.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.initialNum.Name = "initialNum";
            this.initialNum.Size = new System.Drawing.Size(79, 20);
            this.initialNum.TabIndex = 52;
            this.initialNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblDescTask
            // 
            this.lblDescTask.AutoSize = true;
            this.lblDescTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescTask.ForeColor = System.Drawing.Color.White;
            this.lblDescTask.Location = new System.Drawing.Point(-1, 6);
            this.lblDescTask.Name = "lblDescTask";
            this.lblDescTask.Size = new System.Drawing.Size(703, 39);
            this.lblDescTask.TabIndex = 50;
            this.lblDescTask.Text = resources.GetString("lblDescTask.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(397, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "с3 - Основание 3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtn3cRandom);
            this.panel2.Controls.Add(this.rbtn3c16);
            this.panel2.Controls.Add(this.rbtn3c8);
            this.panel2.Controls.Add(this.rbtn3c2);
            this.panel2.Location = new System.Drawing.Point(393, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 95);
            this.panel2.TabIndex = 59;
            // 
            // rbtn3cRandom
            // 
            this.rbtn3cRandom.AutoSize = true;
            this.rbtn3cRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn3cRandom.ForeColor = System.Drawing.Color.White;
            this.rbtn3cRandom.Location = new System.Drawing.Point(3, 72);
            this.rbtn3cRandom.Name = "rbtn3cRandom";
            this.rbtn3cRandom.Size = new System.Drawing.Size(155, 17);
            this.rbtn3cRandom.TabIndex = 41;
            this.rbtn3cRandom.Text = "Основание случайное";
            this.rbtn3cRandom.UseVisualStyleBackColor = true;
            this.rbtn3cRandom.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn3c16
            // 
            this.rbtn3c16.AutoSize = true;
            this.rbtn3c16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn3c16.ForeColor = System.Drawing.Color.White;
            this.rbtn3c16.Location = new System.Drawing.Point(3, 49);
            this.rbtn3c16.Name = "rbtn3c16";
            this.rbtn3c16.Size = new System.Drawing.Size(108, 17);
            this.rbtn3c16.TabIndex = 42;
            this.rbtn3c16.Text = "Основание 16";
            this.rbtn3c16.UseVisualStyleBackColor = true;
            this.rbtn3c16.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn3c8
            // 
            this.rbtn3c8.AutoSize = true;
            this.rbtn3c8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn3c8.ForeColor = System.Drawing.Color.White;
            this.rbtn3c8.Location = new System.Drawing.Point(3, 26);
            this.rbtn3c8.Name = "rbtn3c8";
            this.rbtn3c8.Size = new System.Drawing.Size(101, 17);
            this.rbtn3c8.TabIndex = 43;
            this.rbtn3c8.Text = "Основание 8";
            this.rbtn3c8.UseVisualStyleBackColor = true;
            this.rbtn3c8.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtn3c2
            // 
            this.rbtn3c2.AutoSize = true;
            this.rbtn3c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbtn3c2.ForeColor = System.Drawing.Color.White;
            this.rbtn3c2.Location = new System.Drawing.Point(3, 3);
            this.rbtn3c2.Name = "rbtn3c2";
            this.rbtn3c2.Size = new System.Drawing.Size(101, 17);
            this.rbtn3c2.TabIndex = 44;
            this.rbtn3c2.Text = "Основание 2";
            this.rbtn3c2.UseVisualStyleBackColor = true;
            this.rbtn3c2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Type7F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(700, 278);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.nudCount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastNum);
            this.Controls.Add(this.initialNum);
            this.Controls.Add(this.lblDescTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Type7F";
            this.Text = "Type7F";
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.initialNum)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddTask;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbtn2cRandom;
        private System.Windows.Forms.RadioButton rbtn2c16;
        private System.Windows.Forms.RadioButton rbtn2c8;
        private System.Windows.Forms.RadioButton rbtn2c2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnCRandom;
        private System.Windows.Forms.RadioButton rbtnC16;
        private System.Windows.Forms.RadioButton rbtnC8;
        private System.Windows.Forms.RadioButton rbtnC2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lastNum;
        private System.Windows.Forms.NumericUpDown initialNum;
        private System.Windows.Forms.Label lblDescTask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtn3cRandom;
        private System.Windows.Forms.RadioButton rbtn3c16;
        private System.Windows.Forms.RadioButton rbtn3c8;
        private System.Windows.Forms.RadioButton rbtn3c2;
    }
}