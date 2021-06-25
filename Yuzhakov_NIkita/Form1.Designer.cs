namespace Yuzhakov_NIkita
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Rasschet = new System.Windows.Forms.Button();
            this.Sum_Zaim = new System.Windows.Forms.TextBox();
            this.Srok_Zaim = new System.Windows.Forms.TextBox();
            this.Ob_Sum = new System.Windows.Forms.TextBox();
            this.Sum_Proc = new System.Windows.Forms.TextBox();
            this.Ef_Stavka = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сумма займа";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(299, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Срок займа(дней)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(33, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Общая сумма выплаты";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(222, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сумма процентов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(371, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Эффективная ставка";
            // 
            // Rasschet
            // 
            this.Rasschet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rasschet.Location = new System.Drawing.Point(210, 202);
            this.Rasschet.Name = "Rasschet";
            this.Rasschet.Size = new System.Drawing.Size(177, 57);
            this.Rasschet.TabIndex = 5;
            this.Rasschet.Text = "Рассчитать";
            this.Rasschet.UseVisualStyleBackColor = true;
            this.Rasschet.Click += new System.EventHandler(this.Rasschet_Click);
            // 
            // Sum_Zaim
            // 
            this.Sum_Zaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum_Zaim.Location = new System.Drawing.Point(132, 52);
            this.Sum_Zaim.Name = "Sum_Zaim";
            this.Sum_Zaim.Size = new System.Drawing.Size(137, 26);
            this.Sum_Zaim.TabIndex = 6;
            this.Sum_Zaim.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // Srok_Zaim
            // 
            this.Srok_Zaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Srok_Zaim.Location = new System.Drawing.Point(304, 52);
            this.Srok_Zaim.Name = "Srok_Zaim";
            this.Srok_Zaim.Size = new System.Drawing.Size(171, 26);
            this.Srok_Zaim.TabIndex = 7;
            this.Srok_Zaim.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Ob_Sum
            // 
            this.Ob_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ob_Sum.Location = new System.Drawing.Point(37, 342);
            this.Ob_Sum.Name = "Ob_Sum";
            this.Ob_Sum.Size = new System.Drawing.Size(179, 26);
            this.Ob_Sum.TabIndex = 8;
            this.Ob_Sum.TextChanged += new System.EventHandler(this.Rasschet_Click);
            // 
            // Sum_Proc
            // 
            this.Sum_Proc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum_Proc.Location = new System.Drawing.Point(222, 342);
            this.Sum_Proc.Name = "Sum_Proc";
            this.Sum_Proc.Size = new System.Drawing.Size(143, 26);
            this.Sum_Proc.TabIndex = 9;
            // 
            // Ef_Stavka
            // 
            this.Ef_Stavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ef_Stavka.Location = new System.Drawing.Point(371, 342);
            this.Ef_Stavka.Name = "Ef_Stavka";
            this.Ef_Stavka.Size = new System.Drawing.Size(174, 26);
            this.Ef_Stavka.TabIndex = 10;
            this.Ef_Stavka.TextChanged += new System.EventHandler(this.Ef_Stavka_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(364, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(190, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Процент в определенный день  ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(237, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 584);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Ef_Stavka);
            this.Controls.Add(this.Sum_Proc);
            this.Controls.Add(this.Ob_Sum);
            this.Controls.Add(this.Srok_Zaim);
            this.Controls.Add(this.Sum_Zaim);
            this.Controls.Add(this.Rasschet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Калькулятор микрокредита";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Rasschet;
        private System.Windows.Forms.TextBox Sum_Zaim;
        private System.Windows.Forms.TextBox Srok_Zaim;
        private System.Windows.Forms.TextBox Ob_Sum;
        private System.Windows.Forms.TextBox Sum_Proc;
        private System.Windows.Forms.TextBox Ef_Stavka;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

