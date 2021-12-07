namespace HexCalculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_diff = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox1.Location = new System.Drawing.Point(30, 95);
            this.textBox1.MaximumSize = new System.Drawing.Size(200, 75);
            this.textBox1.MinimumSize = new System.Drawing.Size(200, 75);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 75);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // button_add
            // 
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_add.Location = new System.Drawing.Point(294, 95);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 70);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Button_add_Click);
            // 
            // button_diff
            // 
            this.button_diff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_diff.Location = new System.Drawing.Point(294, 189);
            this.button_diff.Name = "button_diff";
            this.button_diff.Size = new System.Drawing.Size(100, 70);
            this.button_diff.TabIndex = 2;
            this.button_diff.Text = "-";
            this.button_diff.UseVisualStyleBackColor = true;
            this.button_diff.Click += new System.EventHandler(this.Button_diff_Click);
            // 
            // button_mult
            // 
            this.button_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_mult.Location = new System.Drawing.Point(294, 277);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(100, 70);
            this.button_mult.TabIndex = 3;
            this.button_mult.Text = "*";
            this.button_mult.UseVisualStyleBackColor = true;
            this.button_mult.Click += new System.EventHandler(this.Button_mult_Click);
            // 
            // button_div
            // 
            this.button_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_div.Location = new System.Drawing.Point(294, 371);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(100, 70);
            this.button_div.TabIndex = 4;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.Button_div_Click);
            // 
            // button_equal
            // 
            this.button_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_equal.Location = new System.Drawing.Point(467, 249);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(176, 98);
            this.button_equal.TabIndex = 5;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.Button_equal_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_clear.Location = new System.Drawing.Point(44, 249);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(176, 98);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.Button_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.MaximumSize = new System.Drawing.Size(250, 70);
            this.label1.MinimumSize = new System.Drawing.Size(250, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 70);
            this.label1.TabIndex = 25;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox2.Location = new System.Drawing.Point(452, 95);
            this.textBox2.MaximumSize = new System.Drawing.Size(200, 75);
            this.textBox2.MinimumSize = new System.Drawing.Size(200, 75);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 75);
            this.textBox2.TabIndex = 26;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(476, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 39);
            this.button1.TabIndex = 27;
            this.button1.Text = "Вектор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_mult);
            this.Controls.Add(this.button_diff);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_diff;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
    }
}

