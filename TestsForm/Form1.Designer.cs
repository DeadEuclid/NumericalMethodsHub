namespace TestsForm
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
            this.Parameters = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.yZero = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.xZero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aZero = new System.Windows.Forms.Label();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColmnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Parameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Parameters
            // 
            this.Parameters.Controls.Add(this.textBox5);
            this.Parameters.Controls.Add(this.textBox4);
            this.Parameters.Controls.Add(this.textBox3);
            this.Parameters.Controls.Add(this.textBox2);
            this.Parameters.Controls.Add(this.textBox1);
            this.Parameters.Controls.Add(this.yZero);
            this.Parameters.Controls.Add(this.label6);
            this.Parameters.Controls.Add(this.xZero);
            this.Parameters.Controls.Add(this.label2);
            this.Parameters.Controls.Add(this.aZero);
            this.Parameters.Location = new System.Drawing.Point(12, 285);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(290, 102);
            this.Parameters.TabIndex = 1;
            this.Parameters.TabStop = false;
            this.Parameters.Text = "Параметры";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(177, 42);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(176, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(32, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // yZero
            // 
            this.yZero.AutoSize = true;
            this.yZero.Location = new System.Drawing.Point(151, 45);
            this.yZero.Name = "yZero";
            this.yZero.Size = new System.Drawing.Size(18, 13);
            this.yZero.TabIndex = 6;
            this.yZero.Text = "y=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "N=";
            // 
            // xZero
            // 
            this.xZero.AutoSize = true;
            this.xZero.Location = new System.Drawing.Point(8, 45);
            this.xZero.Name = "xZero";
            this.xZero.Size = new System.Drawing.Size(18, 13);
            this.xZero.TabIndex = 2;
            this.xZero.Text = "x=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "b=";
            // 
            // aZero
            // 
            this.aZero.AutoSize = true;
            this.aZero.Location = new System.Drawing.Point(7, 20);
            this.aZero.Name = "aZero";
            this.aZero.Size = new System.Drawing.Size(19, 13);
            this.aZero.TabIndex = 0;
            this.aZero.Text = "a=";
            // 
            // ColumnY
            // 
            this.ColumnY.HeaderText = "Y";
            this.ColumnY.Name = "ColumnY";
            // 
            // ColmnX
            // 
            this.ColmnX.HeaderText = "X";
            this.ColmnX.Name = "ColmnX";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColmnX,
            this.ColumnY});
            this.dataGridView1.Location = new System.Drawing.Point(311, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(266, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 394);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Parameters);
            this.Name = "Form1";
            this.Text = "la";
            this.Parameters.ResumeLayout(false);
            this.Parameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Parameters;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label yZero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label xZero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label aZero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColmnX;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

