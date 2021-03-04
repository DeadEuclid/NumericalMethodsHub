namespace NumericalMethodsHub
{
    partial class InputForm
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
            this.ordinaryDiff = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.KoshiProblem = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Methods = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.OneStep = new System.Windows.Forms.GroupBox();
            this.RungeKuttMethod = new System.Windows.Forms.CheckBox();
            this.EilerMetodWithRecalculation = new System.Windows.Forms.CheckBox();
            this.HordMetod = new System.Windows.Forms.CheckBox();
            this.EilerMetod = new System.Windows.Forms.CheckBox();
            this.Parameters = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.yZero = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.xZero = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aZero = new System.Windows.Forms.Label();
            this.FirstEdgeProblem = new System.Windows.Forms.TabPage();
            this.SecondEdgeProblem = new System.Windows.Forms.TabPage();
            this.ThridEdgeProblem = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.iterationProcessingMethod = new System.Windows.Forms.CheckBox();
            this.ordinaryDiff.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.KoshiProblem.SuspendLayout();
            this.Methods.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.OneStep.SuspendLayout();
            this.Parameters.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordinaryDiff
            // 
            this.ordinaryDiff.Controls.Add(this.tabControl2);
            this.ordinaryDiff.Location = new System.Drawing.Point(4, 22);
            this.ordinaryDiff.Name = "ordinaryDiff";
            this.ordinaryDiff.Padding = new System.Windows.Forms.Padding(3);
            this.ordinaryDiff.Size = new System.Drawing.Size(581, 413);
            this.ordinaryDiff.TabIndex = 0;
            this.ordinaryDiff.Text = "Обыкновенные дифференцальные уравнения";
            this.ordinaryDiff.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.KoshiProblem);
            this.tabControl2.Controls.Add(this.FirstEdgeProblem);
            this.tabControl2.Controls.Add(this.SecondEdgeProblem);
            this.tabControl2.Controls.Add(this.ThridEdgeProblem);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(570, 401);
            this.tabControl2.TabIndex = 0;
            // 
            // KoshiProblem
            // 
            this.KoshiProblem.Controls.Add(this.button2);
            this.KoshiProblem.Controls.Add(this.richTextBox1);
            this.KoshiProblem.Controls.Add(this.button1);
            this.KoshiProblem.Controls.Add(this.Methods);
            this.KoshiProblem.Controls.Add(this.Parameters);
            this.KoshiProblem.Location = new System.Drawing.Point(4, 22);
            this.KoshiProblem.Name = "KoshiProblem";
            this.KoshiProblem.Padding = new System.Windows.Forms.Padding(3);
            this.KoshiProblem.Size = new System.Drawing.Size(562, 375);
            this.KoshiProblem.TabIndex = 0;
            this.KoshiProblem.Text = "Здача Коши";
            this.KoshiProblem.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(265, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 30);
            this.button2.TabIndex = 4;
            this.button2.Text = "sqrt";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(265, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(278, 32);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Вывести решение и графики";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Methods
            // 
            this.Methods.Controls.Add(this.groupBox1);
            this.Methods.Controls.Add(this.OneStep);
            this.Methods.Location = new System.Drawing.Point(6, 6);
            this.Methods.Name = "Methods";
            this.Methods.Size = new System.Drawing.Size(253, 245);
            this.Methods.TabIndex = 1;
            this.Methods.TabStop = false;
            this.Methods.Text = "Методы";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Location = new System.Drawing.Point(6, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(241, 65);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Многошаговые";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 42);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox3.Size = new System.Drawing.Size(100, 17);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Метод Адемса";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 19);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox4.Size = new System.Drawing.Size(94, 17);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Text = "Метод Милна";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // OneStep
            // 
            this.OneStep.Controls.Add(this.iterationProcessingMethod);
            this.OneStep.Controls.Add(this.RungeKuttMethod);
            this.OneStep.Controls.Add(this.EilerMetodWithRecalculation);
            this.OneStep.Controls.Add(this.HordMetod);
            this.OneStep.Controls.Add(this.EilerMetod);
            this.OneStep.Location = new System.Drawing.Point(6, 20);
            this.OneStep.Name = "OneStep";
            this.OneStep.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OneStep.Size = new System.Drawing.Size(241, 148);
            this.OneStep.TabIndex = 0;
            this.OneStep.TabStop = false;
            this.OneStep.Text = "Одношаговые";
            // 
            // RungeKuttMethod
            // 
            this.RungeKuttMethod.AutoSize = true;
            this.RungeKuttMethod.Location = new System.Drawing.Point(6, 88);
            this.RungeKuttMethod.Name = "RungeKuttMethod";
            this.RungeKuttMethod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RungeKuttMethod.Size = new System.Drawing.Size(124, 17);
            this.RungeKuttMethod.TabIndex = 3;
            this.RungeKuttMethod.Text = "Метод  Рунге-Кутта";
            this.RungeKuttMethod.UseVisualStyleBackColor = true;
            // 
            // EilerMetodWithRecalculation
            // 
            this.EilerMetodWithRecalculation.AutoSize = true;
            this.EilerMetodWithRecalculation.Location = new System.Drawing.Point(6, 65);
            this.EilerMetodWithRecalculation.Name = "EilerMetodWithRecalculation";
            this.EilerMetodWithRecalculation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EilerMetodWithRecalculation.Size = new System.Drawing.Size(164, 17);
            this.EilerMetodWithRecalculation.TabIndex = 2;
            this.EilerMetodWithRecalculation.Text = "Метод Эйлера с персчётом";
            this.EilerMetodWithRecalculation.UseVisualStyleBackColor = true;
            // 
            // HordMetod
            // 
            this.HordMetod.AutoSize = true;
            this.HordMetod.Location = new System.Drawing.Point(6, 42);
            this.HordMetod.Name = "HordMetod";
            this.HordMetod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HordMetod.Size = new System.Drawing.Size(86, 17);
            this.HordMetod.TabIndex = 1;
            this.HordMetod.Text = "Метод Хорд";
            this.HordMetod.UseVisualStyleBackColor = true;
            // 
            // EilerMetod
            // 
            this.EilerMetod.AutoSize = true;
            this.EilerMetod.Location = new System.Drawing.Point(6, 19);
            this.EilerMetod.Name = "EilerMetod";
            this.EilerMetod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EilerMetod.Size = new System.Drawing.Size(98, 17);
            this.EilerMetod.TabIndex = 0;
            this.EilerMetod.Text = "Метод Эйлера";
            this.EilerMetod.UseVisualStyleBackColor = true;
            // 
            // Parameters
            // 
            this.Parameters.Controls.Add(this.textBox6);
            this.Parameters.Controls.Add(this.textBox5);
            this.Parameters.Controls.Add(this.textBox4);
            this.Parameters.Controls.Add(this.textBox3);
            this.Parameters.Controls.Add(this.textBox2);
            this.Parameters.Controls.Add(this.textBox1);
            this.Parameters.Controls.Add(this.yZero);
            this.Parameters.Controls.Add(this.label4);
            this.Parameters.Controls.Add(this.label6);
            this.Parameters.Controls.Add(this.xZero);
            this.Parameters.Controls.Add(this.label2);
            this.Parameters.Controls.Add(this.aZero);
            this.Parameters.Location = new System.Drawing.Point(265, 116);
            this.Parameters.Name = "Parameters";
            this.Parameters.Size = new System.Drawing.Size(290, 102);
            this.Parameters.TabIndex = 0;
            this.Parameters.TabStop = false;
            this.Parameters.Text = "Параметры";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(176, 68);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 12;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "E=";
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
            this.xZero.Click += new System.EventHandler(this.label3_Click);
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
            // FirstEdgeProblem
            // 
            this.FirstEdgeProblem.Location = new System.Drawing.Point(4, 22);
            this.FirstEdgeProblem.Name = "FirstEdgeProblem";
            this.FirstEdgeProblem.Padding = new System.Windows.Forms.Padding(3);
            this.FirstEdgeProblem.Size = new System.Drawing.Size(562, 375);
            this.FirstEdgeProblem.TabIndex = 1;
            this.FirstEdgeProblem.Text = "Первая краевая задача";
            this.FirstEdgeProblem.UseVisualStyleBackColor = true;
            // 
            // SecondEdgeProblem
            // 
            this.SecondEdgeProblem.Location = new System.Drawing.Point(4, 22);
            this.SecondEdgeProblem.Name = "SecondEdgeProblem";
            this.SecondEdgeProblem.Size = new System.Drawing.Size(562, 375);
            this.SecondEdgeProblem.TabIndex = 2;
            this.SecondEdgeProblem.Text = "Вторая краевая задача";
            this.SecondEdgeProblem.UseVisualStyleBackColor = true;
            // 
            // ThridEdgeProblem
            // 
            this.ThridEdgeProblem.Location = new System.Drawing.Point(4, 22);
            this.ThridEdgeProblem.Name = "ThridEdgeProblem";
            this.ThridEdgeProblem.Size = new System.Drawing.Size(562, 375);
            this.ThridEdgeProblem.TabIndex = 3;
            this.ThridEdgeProblem.Text = "Третья краевая задача";
            this.ThridEdgeProblem.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ordinaryDiff);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // iterationProcessingMethod
            // 
            this.iterationProcessingMethod.AutoSize = true;
            this.iterationProcessingMethod.Location = new System.Drawing.Point(6, 110);
            this.iterationProcessingMethod.Name = "iterationProcessingMethod";
            this.iterationProcessingMethod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iterationProcessingMethod.Size = new System.Drawing.Size(161, 30);
            this.iterationProcessingMethod.TabIndex = 4;
            this.iterationProcessingMethod.Text = "Итерационная обработка  \r\nус.метода Эйлера-Коши";
            this.iterationProcessingMethod.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 463);
            this.Controls.Add(this.tabControl1);
            this.Name = "InputForm";
            this.Text = "Численные методы";
            this.ordinaryDiff.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.KoshiProblem.ResumeLayout(false);
            this.Methods.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.OneStep.ResumeLayout(false);
            this.OneStep.PerformLayout();
            this.Parameters.ResumeLayout(false);
            this.Parameters.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage ordinaryDiff;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage KoshiProblem;
        private System.Windows.Forms.GroupBox Methods;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.GroupBox OneStep;
        private System.Windows.Forms.CheckBox RungeKuttMethod;
        private System.Windows.Forms.CheckBox EilerMetodWithRecalculation;
        private System.Windows.Forms.CheckBox HordMetod;
        private System.Windows.Forms.CheckBox EilerMetod;
        private System.Windows.Forms.GroupBox Parameters;
        private System.Windows.Forms.Label xZero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label aZero;
        private System.Windows.Forms.TabPage FirstEdgeProblem;
        private System.Windows.Forms.TabPage SecondEdgeProblem;
        private System.Windows.Forms.TabPage ThridEdgeProblem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label yZero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox iterationProcessingMethod;
    }
}

