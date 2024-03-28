namespace VAL4
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
            this.IterationsDataGauss = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.koefData = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.freeData = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.iteraction = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.rezGaus = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IterationsDataGauss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koefData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezGaus)).BeginInit();
            this.SuspendLayout();
            // 
            // IterationsDataGauss
            // 
            this.IterationsDataGauss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IterationsDataGauss.Location = new System.Drawing.Point(99, 388);
            this.IterationsDataGauss.Name = "IterationsDataGauss";
            this.IterationsDataGauss.Size = new System.Drawing.Size(560, 271);
            this.IterationsDataGauss.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Порядок системы";
            // 
            // koefData
            // 
            this.koefData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.koefData.Location = new System.Drawing.Point(308, 34);
            this.koefData.Name = "koefData";
            this.koefData.Size = new System.Drawing.Size(661, 287);
            this.koefData.TabIndex = 3;
            this.koefData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.koefData_CellEndEdit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Коэффициенты";
            // 
            // freeData
            // 
            this.freeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.freeData.Location = new System.Drawing.Point(1003, 34);
            this.freeData.Name = "freeData";
            this.freeData.Size = new System.Drawing.Size(160, 287);
            this.freeData.TabIndex = 5;
            this.freeData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.freeData_CellEndEdit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1000, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Свободные члены";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(26, 44);
            this.n.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.n.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(120, 20);
            this.n.TabIndex = 7;
            this.n.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(827, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Итерация";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Метод Гаусса";
            // 
            // iteraction
            // 
            this.iteraction.FormattingEnabled = true;
            this.iteraction.Location = new System.Drawing.Point(830, 400);
            this.iteraction.Name = "iteraction";
            this.iteraction.Size = new System.Drawing.Size(121, 21);
            this.iteraction.TabIndex = 13;
            this.iteraction.SelectedIndexChanged += new System.EventHandler(this.iteraction_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 53);
            this.button1.TabIndex = 14;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 97);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 51);
            this.button2.TabIndex = 15;
            this.button2.Text = "Случайные числа";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 55);
            this.button3.TabIndex = 16;
            this.button3.Text = "Самостоятельно заполнить ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rezGaus
            // 
            this.rezGaus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rezGaus.Location = new System.Drawing.Point(681, 388);
            this.rezGaus.Name = "rezGaus";
            this.rezGaus.Size = new System.Drawing.Size(131, 271);
            this.rezGaus.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Итерация";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(678, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Результат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 688);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rezGaus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iteraction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.freeData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.koefData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IterationsDataGauss);
            this.Name = "Form1";
            this.Text = "Val3 Sakhno";
            ((System.ComponentModel.ISupportInitialize)(this.IterationsDataGauss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koefData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rezGaus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView IterationsDataGauss;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView koefData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView freeData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown n;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox iteraction;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView rezGaus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}

