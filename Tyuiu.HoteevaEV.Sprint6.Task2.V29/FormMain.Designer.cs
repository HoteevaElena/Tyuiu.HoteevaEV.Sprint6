namespace Tyuiu.HoteevaEV.Sprint6.Task2.V29
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxInPut = new GroupBox();
            buttonDone = new Button();
            buttonInfo = new Button();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            textBoxEndText = new TextBox();
            textBoxStartText = new TextBox();
            groupBoxTask = new GroupBox();
            pictureBoxFormula = new PictureBox();
            textBoxUslovie = new TextBox();
            groupBoxOutPut = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            textBoxResultText = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            groupBoxInPut.SuspendLayout();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxOutPut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            SuspendLayout();
            // 
            // groupBoxInPut
            // 
            groupBoxInPut.Controls.Add(buttonDone);
            groupBoxInPut.Controls.Add(buttonInfo);
            groupBoxInPut.Controls.Add(textBoxEnd);
            groupBoxInPut.Controls.Add(textBoxStart);
            groupBoxInPut.Controls.Add(textBoxEndText);
            groupBoxInPut.Controls.Add(textBoxStartText);
            groupBoxInPut.Location = new Point(15, 335);
            groupBoxInPut.Name = "groupBoxInPut";
            groupBoxInPut.Size = new Size(662, 135);
            groupBoxInPut.TabIndex = 3;
            groupBoxInPut.TabStop = false;
            groupBoxInPut.Text = "Ввод данных";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.DarkGreen;
            buttonDone.Location = new Point(472, 44);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(167, 70);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonEnter_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.DodgerBlue;
            buttonInfo.Location = new Point(348, 44);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(109, 70);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(172, 83);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(150, 31);
            textBoxEnd.TabIndex = 3;
            textBoxEnd.TextChanged += textBoxEnd_TextChanged;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 83);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(150, 31);
            textBoxStart.TabIndex = 3;
            // 
            // textBoxEndText
            // 
            textBoxEndText.BorderStyle = BorderStyle.None;
            textBoxEndText.Location = new Point(172, 44);
            textBoxEndText.Name = "textBoxEndText";
            textBoxEndText.ReadOnly = true;
            textBoxEndText.Size = new Size(150, 24);
            textBoxEndText.TabIndex = 1;
            textBoxEndText.Text = "Конец шага:";
            // 
            // textBoxStartText
            // 
            textBoxStartText.BorderStyle = BorderStyle.None;
            textBoxStartText.Location = new Point(6, 44);
            textBoxStartText.Name = "textBoxStartText";
            textBoxStartText.ReadOnly = true;
            textBoxStartText.Size = new Size(150, 24);
            textBoxStartText.TabIndex = 0;
            textBoxStartText.Text = "Старт шага:";
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBoxFormula);
            groupBoxTask.Controls.Add(textBoxUslovie);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(665, 304);
            groupBoxTask.TabIndex = 4;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие ";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(6, 96);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(509, 55);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            // 
            // textBoxUslovie
            // 
            textBoxUslovie.BackColor = SystemColors.Control;
            textBoxUslovie.BorderStyle = BorderStyle.None;
            textBoxUslovie.Location = new Point(3, 27);
            textBoxUslovie.Multiline = true;
            textBoxUslovie.Name = "textBoxUslovie";
            textBoxUslovie.ReadOnly = true;
            textBoxUslovie.Size = new Size(608, 80);
            textBoxUslovie.TabIndex = 0;
            textBoxUslovie.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGirdView и построить график функции.\r\n";
            textBoxUslovie.TextChanged += textBoxUslovie_TextChanged;
            // 
            // groupBoxOutPut
            // 
            groupBoxOutPut.Controls.Add(chartFunction);
            groupBoxOutPut.Controls.Add(dataGridViewFunction);
            groupBoxOutPut.Controls.Add(textBoxResultText);
            groupBoxOutPut.Location = new Point(703, 13);
            groupBoxOutPut.Name = "groupBoxOutPut";
            groupBoxOutPut.Size = new Size(722, 457);
            groupBoxOutPut.TabIndex = 5;
            groupBoxOutPut.TabStop = false;
            groupBoxOutPut.Text = "Вывод данных:";
            groupBoxOutPut.Enter += groupBox1_Enter;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(187, 60);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(529, 376);
            chartFunction.TabIndex = 7;
            chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridViewFunction.Location = new Point(15, 60);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 62;
            dataGridViewFunction.ScrollBars = ScrollBars.Vertical;
            dataGridViewFunction.Size = new Size(150, 376);
            dataGridViewFunction.TabIndex = 6;
            dataGridViewFunction.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 8;
            X.Name = "X";
            X.Width = 50;
            // 
            // F
            // 
            F.HeaderText = "F(X)";
            F.MinimumWidth = 8;
            F.Name = "F";
            F.Width = 50;
            // 
            // textBoxResultText
            // 
            textBoxResultText.BackColor = SystemColors.Control;
            textBoxResultText.BorderStyle = BorderStyle.None;
            textBoxResultText.Location = new Point(15, 30);
            textBoxResultText.Name = "textBoxResultText";
            textBoxResultText.ReadOnly = true;
            textBoxResultText.Size = new Size(150, 24);
            textBoxResultText.TabIndex = 0;
            textBoxResultText.Text = "Результат:";
            textBoxResultText.TextChanged += textBox1_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 482);
            Controls.Add(groupBoxOutPut);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBoxInPut);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 29 | Хотеева Е. В.";
            groupBoxInPut.ResumeLayout(false);
            groupBoxInPut.PerformLayout();
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxOutPut.ResumeLayout(false);
            groupBoxOutPut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInPut;
        private Button buttonDone;
        private Button buttonInfo;
        private TextBox textBoxEnd;
        private TextBox textBoxStart;
        private TextBox textBoxEndText;
        private TextBox textBoxStartText;
        private GroupBox groupBoxTask;
        private PictureBox pictureBoxFormula;
        private TextBox textBoxUslovie;
        private GroupBox groupBoxOutPut;
        private TextBox textBoxResultText;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
