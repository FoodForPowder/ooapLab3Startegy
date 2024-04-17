namespace ooapLab3Startegy
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.countArr = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.arrRes = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Y1 = new System.Windows.Forms.MaskedTextBox();
            this.X1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pointRes = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ArrBut = new System.Windows.Forms.Button();
            this.PointBut = new System.Windows.Forms.Button();
            this.X2 = new System.Windows.Forms.MaskedTextBox();
            this.Y2 = new System.Windows.Forms.MaskedTextBox();
            this.ArrayAsText = new System.Windows.Forms.Label();
            this.ArrayLabel = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Набор стратегий:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ArrBut);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.countArr);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(547, 139);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Массив";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Найти медианный элемент.",
            "Найти самый частый элемент.",
            "Найти среднее значение."});
            this.comboBox2.Location = new System.Drawing.Point(9, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(166, 21);
            this.comboBox2.Sorted = true;
            this.comboBox2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Веселимся с массивом";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.ArrayAsText);
            this.panel2.Controls.Add(this.ArrayLabel);
            this.panel2.Controls.Add(this.arrRes);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(9, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(522, 87);
            this.panel2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(197, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Длинна массива";
            // 
            // countArr
            // 
            this.countArr.Location = new System.Drawing.Point(311, 19);
            this.countArr.Mask = "00";
            this.countArr.Name = "countArr";
            this.countArr.Size = new System.Drawing.Size(93, 20);
            this.countArr.TabIndex = 5;
            this.countArr.ValidatingType = typeof(int);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Результат:";
            // 
            // arrRes
            // 
            this.arrRes.AutoSize = true;
            this.arrRes.BackColor = System.Drawing.Color.White;
            this.arrRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrRes.Location = new System.Drawing.Point(20, 62);
            this.arrRes.Name = "arrRes";
            this.arrRes.Size = new System.Drawing.Size(0, 20);
            this.arrRes.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Y2);
            this.tabPage1.Controls.Add(this.X2);
            this.tabPage1.Controls.Add(this.PointBut);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.Y1);
            this.tabPage1.Controls.Add(this.X1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(547, 139);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Точки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MaxStrategy",
            "SqrtStrategy",
            "SumStrategy"});
            this.comboBox1.Location = new System.Drawing.Point(9, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(166, 21);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Нахождение расстояния между точками.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pointRes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(9, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 85);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Y";
            // 
            // Y1
            // 
            this.Y1.Location = new System.Drawing.Point(337, 19);
            this.Y1.Name = "Y1";
            this.Y1.Size = new System.Drawing.Size(42, 20);
            this.Y1.TabIndex = 4;
            // 
            // X1
            // 
            this.X1.Location = new System.Drawing.Point(211, 20);
            this.X1.Name = "X1";
            this.X1.Size = new System.Drawing.Size(45, 20);
            this.X1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Результат:";
            // 
            // pointRes
            // 
            this.pointRes.AutoSize = true;
            this.pointRes.BackColor = System.Drawing.Color.White;
            this.pointRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pointRes.Location = new System.Drawing.Point(30, 50);
            this.pointRes.Name = "pointRes";
            this.pointRes.Size = new System.Drawing.Size(0, 20);
            this.pointRes.TabIndex = 7;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(6, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(555, 165);
            this.tabControl1.TabIndex = 2;
            // 
            // ArrBut
            // 
            this.ArrBut.Location = new System.Drawing.Point(419, 17);
            this.ArrBut.Name = "ArrBut";
            this.ArrBut.Size = new System.Drawing.Size(112, 23);
            this.ArrBut.TabIndex = 6;
            this.ArrBut.Text = "Запуск";
            this.ArrBut.UseVisualStyleBackColor = true;
            this.ArrBut.Click += new System.EventHandler(this.ArrBut_Click);
            // 
            // PointBut
            // 
            this.PointBut.Location = new System.Drawing.Point(443, 16);
            this.PointBut.Name = "PointBut";
            this.PointBut.Size = new System.Drawing.Size(85, 23);
            this.PointBut.TabIndex = 7;
            this.PointBut.Text = "Запуск";
            this.PointBut.UseVisualStyleBackColor = true;
            this.PointBut.Click += new System.EventHandler(this.PointBut_Click);
            // 
            // X2
            // 
            this.X2.Location = new System.Drawing.Point(262, 20);
            this.X2.Name = "X2";
            this.X2.Size = new System.Drawing.Size(48, 20);
            this.X2.TabIndex = 8;
            // 
            // Y2
            // 
            this.Y2.Location = new System.Drawing.Point(385, 20);
            this.Y2.Name = "Y2";
            this.Y2.Size = new System.Drawing.Size(42, 20);
            this.Y2.TabIndex = 9;
            // 
            // ArrayAsText
            // 
            this.ArrayAsText.AutoSize = true;
            this.ArrayAsText.BackColor = System.Drawing.Color.White;
            this.ArrayAsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrayAsText.Location = new System.Drawing.Point(93, 14);
            this.ArrayAsText.Name = "ArrayAsText";
            this.ArrayAsText.Size = new System.Drawing.Size(0, 16);
            this.ArrayAsText.TabIndex = 11;
            // 
            // ArrayLabel
            // 
            this.ArrayLabel.AutoSize = true;
            this.ArrayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArrayLabel.Location = new System.Drawing.Point(3, 12);
            this.ArrayLabel.Name = "ArrayLabel";
            this.ArrayLabel.Size = new System.Drawing.Size(65, 18);
            this.ArrayLabel.TabIndex = 10;
            this.ArrayLabel.Text = "Массив:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 223);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label arrRes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox countArr;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label pointRes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox Y1;
        private System.Windows.Forms.MaskedTextBox X1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button ArrBut;
        private System.Windows.Forms.Button PointBut;
        private System.Windows.Forms.MaskedTextBox Y2;
        private System.Windows.Forms.MaskedTextBox X2;
        private System.Windows.Forms.Label ArrayAsText;
        private System.Windows.Forms.Label ArrayLabel;
    }
}

