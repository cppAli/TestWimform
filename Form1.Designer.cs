namespace WinFormApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.radioButtonOption1 = new System.Windows.Forms.RadioButton();
            this.radioButtonOption2 = new System.Windows.Forms.RadioButton();
            this.radioButtonOption3 = new System.Windows.Forms.RadioButton();
            this.radioButtonOption4 = new System.Windows.Forms.RadioButton();
            this.pointplus = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Teal;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(334, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "!ПРОСТЫЕ ТЕСТЫ!";
            // 
            // labelQuestion
            // 
            this.labelQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQuestion.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelQuestion.Location = new System.Drawing.Point(0, 100);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(982, 84);
            this.labelQuestion.TabIndex = 1;
            this.labelQuestion.Text = "label2";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuestion.Click += new System.EventHandler(this.label2_Click);
            // 
            // radioButtonOption1
            // 
            this.radioButtonOption1.AutoSize = true;
            this.radioButtonOption1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButtonOption1.Location = new System.Drawing.Point(400, 216);
            this.radioButtonOption1.Name = "radioButtonOption1";
            this.radioButtonOption1.Size = new System.Drawing.Size(202, 41);
            this.radioButtonOption1.TabIndex = 2;
            this.radioButtonOption1.Text = "radioButton1";
            this.radioButtonOption1.UseVisualStyleBackColor = true;
            // 
            // radioButtonOption2
            // 
            this.radioButtonOption2.AutoSize = true;
            this.radioButtonOption2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOption2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButtonOption2.Location = new System.Drawing.Point(400, 281);
            this.radioButtonOption2.Name = "radioButtonOption2";
            this.radioButtonOption2.Size = new System.Drawing.Size(202, 41);
            this.radioButtonOption2.TabIndex = 3;
            this.radioButtonOption2.Text = "radioButton2";
            this.radioButtonOption2.UseVisualStyleBackColor = true;
            // 
            // radioButtonOption3
            // 
            this.radioButtonOption3.AutoSize = true;
            this.radioButtonOption3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButtonOption3.Location = new System.Drawing.Point(400, 347);
            this.radioButtonOption3.Name = "radioButtonOption3";
            this.radioButtonOption3.Size = new System.Drawing.Size(202, 41);
            this.radioButtonOption3.TabIndex = 4;
            this.radioButtonOption3.Text = "radioButton3";
            this.radioButtonOption3.UseVisualStyleBackColor = true;
            // 
            // radioButtonOption4
            // 
            this.radioButtonOption4.AutoSize = true;
            this.radioButtonOption4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonOption4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButtonOption4.Location = new System.Drawing.Point(400, 413);
            this.radioButtonOption4.Name = "radioButtonOption4";
            this.radioButtonOption4.Size = new System.Drawing.Size(202, 41);
            this.radioButtonOption4.TabIndex = 5;
            this.radioButtonOption4.Text = "radioButton4";
            this.radioButtonOption4.UseVisualStyleBackColor = true;
            // 
            // pointplus
            // 
            this.pointplus.AutoSize = true;
            this.pointplus.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointplus.ForeColor = System.Drawing.Color.Teal;
            this.pointplus.Location = new System.Drawing.Point(84, 498);
            this.pointplus.Name = "pointplus";
            this.pointplus.Size = new System.Drawing.Size(146, 41);
            this.pointplus.TabIndex = 6;
            this.pointplus.Text = "БАЛЛ: 0";
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Teal;
            this.buttonNext.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonNext.Location = new System.Drawing.Point(414, 493);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(164, 51);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "ВПЕРЕД";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(741, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(229, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "ЗАВЕРШИТЬ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(982, 633);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.pointplus);
            this.Controls.Add(this.radioButtonOption4);
            this.Controls.Add(this.radioButtonOption3);
            this.Controls.Add(this.radioButtonOption2);
            this.Controls.Add(this.radioButtonOption1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.RadioButton radioButtonOption1;
        private System.Windows.Forms.RadioButton radioButtonOption2;
        private System.Windows.Forms.RadioButton radioButtonOption3;
        private System.Windows.Forms.RadioButton radioButtonOption4;
        private System.Windows.Forms.Label pointplus;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button button2;
        //private System.Windows.Forms.ProgressBar progress;
    }
}

