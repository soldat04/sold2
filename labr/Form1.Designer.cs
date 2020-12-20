namespace soldat1
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
            this.Таблица = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.nudKo2 = new System.Windows.Forms.NumericUpDown();
            this.nudKol = new System.Windows.Forms.NumericUpDown();
            this.table = new System.Windows.Forms.DataGridView();
            this.Таблица.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // Таблица
            // 
            this.Таблица.Controls.Add(this.groupBox3);
            this.Таблица.Controls.Add(this.groupBox2);
            this.Таблица.Controls.Add(this.table);
            this.Таблица.Location = new System.Drawing.Point(17, -2);
            this.Таблица.Name = "Таблица";
            this.Таблица.Size = new System.Drawing.Size(535, 449);
            this.Таблица.TabIndex = 3;
            this.Таблица.TabStop = false;
            this.Таблица.UseWaitCursor = true;
            this.Таблица.Enter += new System.EventHandler(this.Таблица_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Location = new System.Drawing.Point(273, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(256, 241);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Решение";
            this.groupBox3.UseWaitCursor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 46);
            this.button4.TabIndex = 10;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.UseWaitCursor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(115, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.UseWaitCursor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(245, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Рассчитать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudValue);
            this.groupBox2.Controls.Add(this.nudKo2);
            this.groupBox2.Controls.Add(this.nudKol);
            this.groupBox2.Location = new System.Drawing.Point(6, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 241);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Таблица";
            this.groupBox2.UseWaitCursor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(146, 46);
            this.button5.TabIndex = 11;
            this.button5.Text = "О программе";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.UseWaitCursor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Заполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "диапазон";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "кол-во столбцов";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "кол-во строк";
            this.label1.UseWaitCursor = true;
            // 
            // nudValue
            // 
            this.nudValue.Location = new System.Drawing.Point(7, 78);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(120, 20);
            this.nudValue.TabIndex = 2;
            this.nudValue.UseWaitCursor = true;
            this.nudValue.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudValue.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            // 
            // nudKo2
            // 
            this.nudKo2.Location = new System.Drawing.Point(7, 52);
            this.nudKo2.Name = "nudKo2";
            this.nudKo2.Size = new System.Drawing.Size(120, 20);
            this.nudKo2.TabIndex = 1;
            this.nudKo2.UseWaitCursor = true;
            this.nudKo2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudKo2.ValueChanged += new System.EventHandler(this.nudKo2_ValueChanged);
            // 
            // nudKol
            // 
            this.nudKol.Location = new System.Drawing.Point(7, 25);
            this.nudKol.Name = "nudKol";
            this.nudKol.Size = new System.Drawing.Size(120, 20);
            this.nudKol.TabIndex = 0;
            this.nudKol.UseWaitCursor = true;
            this.nudKol.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudKol.ValueChanged += new System.EventHandler(this.nudKol_ValueChanged);
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.table.Location = new System.Drawing.Point(6, 14);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(518, 167);
            this.table.TabIndex = 1;
            this.table.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 444);
            this.Controls.Add(this.Таблица);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Практическая №2";
            this.Таблица.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Таблица;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudValue;
        private System.Windows.Forms.NumericUpDown nudKo2;
        private System.Windows.Forms.NumericUpDown nudKol;
        private System.Windows.Forms.DataGridView table;
    }
}

