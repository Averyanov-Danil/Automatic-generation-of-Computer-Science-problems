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
            this.btnExit = new FontAwesome.Sharp.IconButton();
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
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(389, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.ClientSize = new System.Drawing.Size(412, 195);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btn_createPattern);
            this.Controls.Add(this.btn_loadPattern);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SForm_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_loadPattern;
        private System.Windows.Forms.Button btn_createPattern;
        private FontAwesome.Sharp.IconButton btnExit;
    }
}

