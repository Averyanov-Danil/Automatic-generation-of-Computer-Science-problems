namespace GenHomeWork
{
    partial class SForm
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
            this.btn_loadPattern = new System.Windows.Forms.Button();
            this.btn_createPattern = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatternCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_loadPattern
            // 
            this.btn_loadPattern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(131)))), ((int)(((byte)(141)))));
            this.btn_loadPattern.FlatAppearance.BorderSize = 0;
            this.btn_loadPattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loadPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_loadPattern.ForeColor = System.Drawing.Color.White;
            this.btn_loadPattern.Location = new System.Drawing.Point(217, 78);
            this.btn_loadPattern.Name = "btn_loadPattern";
            this.btn_loadPattern.Size = new System.Drawing.Size(183, 40);
            this.btn_loadPattern.TabIndex = 0;
            this.btn_loadPattern.Text = "Загрузить шаблон";
            this.btn_loadPattern.UseVisualStyleBackColor = false;
            this.btn_loadPattern.Click += new System.EventHandler(this.btn_loadPattern_Click);
            // 
            // btn_createPattern
            // 
            this.btn_createPattern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(131)))), ((int)(((byte)(141)))));
            this.btn_createPattern.FlatAppearance.BorderSize = 0;
            this.btn_createPattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_createPattern.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_createPattern.ForeColor = System.Drawing.Color.White;
            this.btn_createPattern.Location = new System.Drawing.Point(12, 78);
            this.btn_createPattern.Name = "btn_createPattern";
            this.btn_createPattern.Size = new System.Drawing.Size(183, 40);
            this.btn_createPattern.TabIndex = 0;
            this.btn_createPattern.Text = "Создать шаблон";
            this.btn_createPattern.UseVisualStyleBackColor = false;
            this.btn_createPattern.Click += new System.EventHandler(this.btn_createPattern_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Кол-во шаблонов:";
            // 
            // lblPatternCount
            // 
            this.lblPatternCount.AutoSize = true;
            this.lblPatternCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPatternCount.ForeColor = System.Drawing.Color.White;
            this.lblPatternCount.Location = new System.Drawing.Point(384, 9);
            this.lblPatternCount.Name = "lblPatternCount";
            this.lblPatternCount.Size = new System.Drawing.Size(14, 13);
            this.lblPatternCount.TabIndex = 6;
            this.lblPatternCount.Text = "0";
            // 
            // SForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(412, 195);
            this.Controls.Add(this.lblPatternCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_createPattern);
            this.Controls.Add(this.btn_loadPattern);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_loadPattern;
        private System.Windows.Forms.Button btn_createPattern;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPatternCount;
    }
}

