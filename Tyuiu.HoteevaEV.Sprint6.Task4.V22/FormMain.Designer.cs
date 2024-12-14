namespace Tyuiu.HoteevaEV.Sprint6.Task4.V22
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelHead_HEV = new Panel();
            groupBoxInPut_HEV = new GroupBox();
            textBoxEndText_HEV = new TextBox();
            textBoxStartText_HEV = new TextBox();
            textBoxEnd_HEV = new TextBox();
            textBoxStart_HEV = new TextBox();
            groupBoxUslovie_HEV = new GroupBox();
            textBoxData_HEV = new TextBox();
            buttonInfo_HEV = new Button();
            buttonSave_HEV = new Button();
            buttonDone_HEV = new Button();
            panel2 = new Panel();
            panelLeft_HEV = new Panel();
            groupBoxOutPut_HEV = new GroupBox();
            textBoxOutPut_HEV = new TextBox();
            panelRight_HEV = new Panel();
            chartFunc_HEV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelHead_HEV.SuspendLayout();
            groupBoxInPut_HEV.SuspendLayout();
            groupBoxUslovie_HEV.SuspendLayout();
            panelLeft_HEV.SuspendLayout();
            groupBoxOutPut_HEV.SuspendLayout();
            panelRight_HEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunc_HEV).BeginInit();
            SuspendLayout();
            // 
            // panelHead_HEV
            // 
            panelHead_HEV.Controls.Add(groupBoxInPut_HEV);
            panelHead_HEV.Controls.Add(groupBoxUslovie_HEV);
            panelHead_HEV.Controls.Add(buttonInfo_HEV);
            panelHead_HEV.Controls.Add(buttonSave_HEV);
            panelHead_HEV.Controls.Add(buttonDone_HEV);
            panelHead_HEV.Controls.Add(panel2);
            panelHead_HEV.Dock = DockStyle.Top;
            panelHead_HEV.Location = new Point(0, 0);
            panelHead_HEV.Name = "panelHead_HEV";
            panelHead_HEV.Size = new Size(1348, 116);
            panelHead_HEV.TabIndex = 0;
            // 
            // groupBoxInPut_HEV
            // 
            groupBoxInPut_HEV.Anchor = AnchorStyles.Top;
            groupBoxInPut_HEV.Controls.Add(textBoxEndText_HEV);
            groupBoxInPut_HEV.Controls.Add(textBoxStartText_HEV);
            groupBoxInPut_HEV.Controls.Add(textBoxEnd_HEV);
            groupBoxInPut_HEV.Controls.Add(textBoxStart_HEV);
            groupBoxInPut_HEV.Location = new Point(515, 7);
            groupBoxInPut_HEV.Name = "groupBoxInPut_HEV";
            groupBoxInPut_HEV.Size = new Size(340, 88);
            groupBoxInPut_HEV.TabIndex = 2;
            groupBoxInPut_HEV.TabStop = false;
            groupBoxInPut_HEV.Text = "Ввод данных:";
            // 
            // textBoxEndText_HEV
            // 
            textBoxEndText_HEV.BorderStyle = BorderStyle.None;
            textBoxEndText_HEV.Location = new Point(171, 27);
            textBoxEndText_HEV.Name = "textBoxEndText_HEV";
            textBoxEndText_HEV.ReadOnly = true;
            textBoxEndText_HEV.Size = new Size(150, 24);
            textBoxEndText_HEV.TabIndex = 4;
            textBoxEndText_HEV.Text = "Конец шага:";
            // 
            // textBoxStartText_HEV
            // 
            textBoxStartText_HEV.BackColor = SystemColors.Control;
            textBoxStartText_HEV.BorderStyle = BorderStyle.None;
            textBoxStartText_HEV.Location = new Point(6, 27);
            textBoxStartText_HEV.Name = "textBoxStartText_HEV";
            textBoxStartText_HEV.ReadOnly = true;
            textBoxStartText_HEV.Size = new Size(150, 24);
            textBoxStartText_HEV.TabIndex = 3;
            textBoxStartText_HEV.Text = "Старт шага:";
            // 
            // textBoxEnd_HEV
            // 
            textBoxEnd_HEV.Location = new Point(171, 51);
            textBoxEnd_HEV.Name = "textBoxEnd_HEV";
            textBoxEnd_HEV.Size = new Size(150, 31);
            textBoxEnd_HEV.TabIndex = 2;
            // 
            // textBoxStart_HEV
            // 
            textBoxStart_HEV.Location = new Point(6, 51);
            textBoxStart_HEV.Name = "textBoxStart_HEV";
            textBoxStart_HEV.Size = new Size(150, 31);
            textBoxStart_HEV.TabIndex = 1;
            // 
            // groupBoxUslovie_HEV
            // 
            groupBoxUslovie_HEV.Controls.Add(textBoxData_HEV);
            groupBoxUslovie_HEV.Location = new Point(12, 7);
            groupBoxUslovie_HEV.Name = "groupBoxUslovie_HEV";
            groupBoxUslovie_HEV.Size = new Size(466, 88);
            groupBoxUslovie_HEV.TabIndex = 2;
            groupBoxUslovie_HEV.TabStop = false;
            groupBoxUslovie_HEV.Text = "Условие:";
            // 
            // textBoxData_HEV
            // 
            textBoxData_HEV.BorderStyle = BorderStyle.None;
            textBoxData_HEV.Location = new Point(12, 30);
            textBoxData_HEV.Multiline = true;
            textBoxData_HEV.Name = "textBoxData_HEV";
            textBoxData_HEV.ReadOnly = true;
            textBoxData_HEV.Size = new Size(448, 46);
            textBoxData_HEV.TabIndex = 0;
            // 
            // buttonInfo_HEV
            // 
            buttonInfo_HEV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_HEV.BackColor = Color.DeepSkyBlue;
            buttonInfo_HEV.Location = new Point(1211, 20);
            buttonInfo_HEV.Name = "buttonInfo_HEV";
            buttonInfo_HEV.Size = new Size(112, 75);
            buttonInfo_HEV.TabIndex = 3;
            buttonInfo_HEV.Text = "Справка";
            buttonInfo_HEV.UseVisualStyleBackColor = false;
            buttonInfo_HEV.Click += buttonInfo_HEV_Click;
            // 
            // buttonSave_HEV
            // 
            buttonSave_HEV.Anchor = AnchorStyles.Top;
            buttonSave_HEV.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_HEV.Location = new Point(1005, 20);
            buttonSave_HEV.Name = "buttonSave_HEV";
            buttonSave_HEV.Size = new Size(112, 75);
            buttonSave_HEV.TabIndex = 2;
            buttonSave_HEV.Text = "Сохранить";
            buttonSave_HEV.UseVisualStyleBackColor = false;
            buttonSave_HEV.Click += buttonSave_HEV_Click;
            // 
            // buttonDone_HEV
            // 
            buttonDone_HEV.Anchor = AnchorStyles.Top;
            buttonDone_HEV.BackColor = Color.Green;
            buttonDone_HEV.Location = new Point(873, 20);
            buttonDone_HEV.Name = "buttonDone_HEV";
            buttonDone_HEV.Size = new Size(112, 75);
            buttonDone_HEV.TabIndex = 1;
            buttonDone_HEV.Text = "Выполнить";
            buttonDone_HEV.UseVisualStyleBackColor = false;
            buttonDone_HEV.Click += buttonDone_HEV_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 439);
            panel2.TabIndex = 1;
            // 
            // panelLeft_HEV
            // 
            panelLeft_HEV.Controls.Add(groupBoxOutPut_HEV);
            panelLeft_HEV.Dock = DockStyle.Left;
            panelLeft_HEV.Location = new Point(0, 116);
            panelLeft_HEV.Margin = new Padding(5);
            panelLeft_HEV.Name = "panelLeft_HEV";
            panelLeft_HEV.Size = new Size(300, 508);
            panelLeft_HEV.TabIndex = 4;
            // 
            // groupBoxOutPut_HEV
            // 
            groupBoxOutPut_HEV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxOutPut_HEV.Controls.Add(textBoxOutPut_HEV);
            groupBoxOutPut_HEV.Location = new Point(3, 19);
            groupBoxOutPut_HEV.Name = "groupBoxOutPut_HEV";
            groupBoxOutPut_HEV.Size = new Size(292, 477);
            groupBoxOutPut_HEV.TabIndex = 1;
            groupBoxOutPut_HEV.TabStop = false;
            groupBoxOutPut_HEV.Text = "Вывод:";
            groupBoxOutPut_HEV.Enter += groupBoxOutPut_HEV_Enter;
            // 
            // textBoxOutPut_HEV
            // 
            textBoxOutPut_HEV.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxOutPut_HEV.BackColor = SystemColors.ButtonHighlight;
            textBoxOutPut_HEV.Location = new Point(9, 33);
            textBoxOutPut_HEV.Multiline = true;
            textBoxOutPut_HEV.Name = "textBoxOutPut_HEV";
            textBoxOutPut_HEV.ReadOnly = true;
            textBoxOutPut_HEV.ScrollBars = ScrollBars.Vertical;
            textBoxOutPut_HEV.Size = new Size(277, 438);
            textBoxOutPut_HEV.TabIndex = 0;
            // 
            // panelRight_HEV
            // 
            panelRight_HEV.Controls.Add(splitter1);
            panelRight_HEV.Controls.Add(chartFunc_HEV);
            panelRight_HEV.Dock = DockStyle.Fill;
            panelRight_HEV.Location = new Point(300, 116);
            panelRight_HEV.Name = "panelRight_HEV";
            panelRight_HEV.Size = new Size(1048, 508);
            panelRight_HEV.TabIndex = 5;
            // 
            // chartFunc_HEV
            // 
            chartFunc_HEV.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            chartArea2.Name = "ChartArea1";
            chartFunc_HEV.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartFunc_HEV.Legends.Add(legend2);
            chartFunc_HEV.Location = new Point(194, 46);
            chartFunc_HEV.Name = "chartFunc_HEV";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartFunc_HEV.Series.Add(series2);
            chartFunc_HEV.Size = new Size(784, 450);
            chartFunc_HEV.TabIndex = 0;
            chartFunc_HEV.Click += chartFunc_HEV_Click;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 508);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 624);
            Controls.Add(panelRight_HEV);
            Controls.Add(panelLeft_HEV);
            Controls.Add(panelHead_HEV);
            MinimumSize = new Size(1370, 680);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 22 | Хотеева Е. В.";
            Load += FormMain_Load;
            panelHead_HEV.ResumeLayout(false);
            groupBoxInPut_HEV.ResumeLayout(false);
            groupBoxInPut_HEV.PerformLayout();
            groupBoxUslovie_HEV.ResumeLayout(false);
            groupBoxUslovie_HEV.PerformLayout();
            panelLeft_HEV.ResumeLayout(false);
            groupBoxOutPut_HEV.ResumeLayout(false);
            groupBoxOutPut_HEV.PerformLayout();
            panelRight_HEV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunc_HEV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead_HEV;
        private Panel panel2;
        private Button buttonInfo_HEV;
        private Button buttonSave_HEV;
        private Button buttonDone_HEV;
        private Panel panelLeft_HEV;
        private Panel panelRight_HEV;
        private GroupBox groupBoxOutPut_HEV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_HEV;
        private TextBox textBoxOutPut_HEV;
        private GroupBox groupBoxUslovie_HEV;
        private TextBox textBoxData_HEV;
        private TextBox textBoxStart_HEV;
        private GroupBox groupBoxInPut_HEV;
        private TextBox textBoxEnd_HEV;
        private TextBox textBoxEndText_HEV;
        private TextBox textBoxStartText_HEV;
        private Splitter splitter1;
    }
}
