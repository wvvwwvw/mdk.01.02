namespace BMIcalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.diag_pic = new System.Windows.Forms.PictureBox();
            this.diag = new System.Windows.Forms.Label();
            this.rasch = new System.Windows.Forms.Button();
            this.otmen = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.man = new System.Windows.Forms.PictureBox();
            this.woman = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.Button();
            this.znach = new System.Windows.Forms.Label();
            this.diagg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diag_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.man)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woman)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(290, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BMI калькулятор";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Информация о том, что такое BMI и как калькулятор работает";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(106, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Рост:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(114, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Вес:";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(161, 316);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(66, 22);
            this.height.TabIndex = 6;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(161, 363);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(66, 22);
            this.weight.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(233, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "см";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(233, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "кг";
            // 
            // diag_pic
            // 
            this.diag_pic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.diag_pic.Image = ((System.Drawing.Image)(resources.GetObject("diag_pic.Image")));
            this.diag_pic.Location = new System.Drawing.Point(481, 63);
            this.diag_pic.Name = "diag_pic";
            this.diag_pic.Size = new System.Drawing.Size(194, 266);
            this.diag_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.diag_pic.TabIndex = 10;
            this.diag_pic.TabStop = false;
            // 
            // diag
            // 
            this.diag.AutoSize = true;
            this.diag.Location = new System.Drawing.Point(505, 378);
            this.diag.Name = "diag";
            this.diag.Size = new System.Drawing.Size(0, 16);
            this.diag.TabIndex = 14;
            // 
            // rasch
            // 
            this.rasch.Location = new System.Drawing.Point(56, 400);
            this.rasch.Name = "rasch";
            this.rasch.Size = new System.Drawing.Size(125, 25);
            this.rasch.TabIndex = 15;
            this.rasch.Text = "Рассчитать";
            this.rasch.UseVisualStyleBackColor = true;
            this.rasch.Click += new System.EventHandler(this.rasch_Click);
            // 
            // otmen
            // 
            this.otmen.Location = new System.Drawing.Point(197, 400);
            this.otmen.Name = "otmen";
            this.otmen.Size = new System.Drawing.Size(94, 25);
            this.otmen.TabIndex = 16;
            this.otmen.Text = "Отмена";
            this.otmen.UseVisualStyleBackColor = true;
            this.otmen.Click += new System.EventHandler(this.otmen_Click);
            // 
            // trackBar
            // 
            this.trackBar.Enabled = false;
            this.trackBar.Location = new System.Drawing.Point(366, 367);
            this.trackBar.Maximum = 60;
            this.trackBar.Minimum = 10;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(418, 56);
            this.trackBar.TabIndex = 17;
            this.trackBar.Value = 10;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(364, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "Недостаточный";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(442, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "Здоровый";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(496, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "Избыточный";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(625, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ожирение";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(380, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 8);
            this.label11.TabIndex = 23;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(452, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 8);
            this.label12.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(496, 407);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 8);
            this.label13.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(537, 407);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(232, 8);
            this.label14.TabIndex = 26;
            // 
            // man
            // 
            this.man.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.man.Image = ((System.Drawing.Image)(resources.GetObject("man.Image")));
            this.man.Location = new System.Drawing.Point(42, 161);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(130, 123);
            this.man.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.man.TabIndex = 27;
            this.man.TabStop = false;
            this.man.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // woman
            // 
            this.woman.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.woman.Image = ((System.Drawing.Image)(resources.GetObject("woman.Image")));
            this.woman.Location = new System.Drawing.Point(197, 161);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(130, 123);
            this.woman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.woman.TabIndex = 28;
            this.woman.TabStop = false;
            this.woman.Click += new System.EventHandler(this.woman_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(684, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(91, 24);
            this.exit.TabIndex = 29;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // znach
            // 
            this.znach.AutoSize = true;
            this.znach.Location = new System.Drawing.Point(565, 348);
            this.znach.Name = "znach";
            this.znach.Size = new System.Drawing.Size(0, 16);
            this.znach.TabIndex = 30;
            this.znach.Click += new System.EventHandler(this.znach_Click);
            // 
            // diagg
            // 
            this.diagg.AutoSize = true;
            this.diagg.Location = new System.Drawing.Point(540, 332);
            this.diagg.Name = "diagg";
            this.diagg.Size = new System.Drawing.Size(0, 16);
            this.diagg.TabIndex = 32;
            this.diagg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.diagg.Click += new System.EventHandler(this.diagg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diagg);
            this.Controls.Add(this.znach);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.woman);
            this.Controls.Add(this.man);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.otmen);
            this.Controls.Add(this.rasch);
            this.Controls.Add(this.diag);
            this.Controls.Add(this.diag_pic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.height);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marathon Skills 2015 – BMI calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diag_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.man)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox diag_pic;
        private System.Windows.Forms.Label diag;
        private System.Windows.Forms.Button rasch;
        private System.Windows.Forms.Button otmen;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox man;
        private System.Windows.Forms.PictureBox woman;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label znach;
        private System.Windows.Forms.Label diagg;
    }
}

