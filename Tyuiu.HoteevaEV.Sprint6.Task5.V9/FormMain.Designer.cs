namespace Tyuiu.HoteevaEV.Sprint6.Task5.V9
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelHead = new Panel();
            buttonInfo = new Button();
            buttonOpenFile = new Button();
            buttonDone = new Button();
            panelLeft = new Panel();
            groupBoxOut = new GroupBox();
            dataGridViewNums = new DataGridView();
            groupBoxUslovie = new GroupBox();
            textBoxUslovie = new TextBox();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelHead.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            groupBoxUslovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.BackColor = SystemColors.Control;
            panelHead.BorderStyle = BorderStyle.FixedSingle;
            panelHead.Controls.Add(buttonInfo);
            panelHead.Controls.Add(buttonOpenFile);
            panelHead.Controls.Add(buttonDone);
            panelHead.Dock = DockStyle.Top;
            panelHead.Location = new Point(0, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(1218, 150);
            panelHead.TabIndex = 0;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top;
            buttonInfo.BackColor = Color.DeepSkyBlue;
            buttonInfo.Location = new Point(1078, 33);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(110, 90);
            buttonInfo.TabIndex = 4;
            buttonInfo.Text = "Справка";
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Anchor = AnchorStyles.Top;
            buttonOpenFile.BackColor = Color.FromArgb(128, 128, 255);
            buttonOpenFile.Location = new Point(914, 33);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(110, 90);
            buttonOpenFile.TabIndex = 3;
            buttonOpenFile.Text = "Открыть файл";
            buttonOpenFile.UseVisualStyleBackColor = false;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top;
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(774, 33);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(110, 90);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = SystemColors.Control;
            panelLeft.Controls.Add(groupBoxOut);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 150);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(300, 535);
            panelLeft.TabIndex = 0;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxOut.BackColor = SystemColors.Control;
            groupBoxOut.Controls.Add(dataGridViewNums);
            groupBoxOut.Location = new Point(4, 1);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(293, 531);
            groupBoxOut.TabIndex = 2;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод данных:";
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Location = new Point(6, 30);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.ReadOnly = true;
            dataGridViewNums.RowHeadersWidth = 62;
            dataGridViewNums.ScrollBars = ScrollBars.Vertical;
            dataGridViewNums.Size = new Size(281, 495);
            dataGridViewNums.TabIndex = 2;
            dataGridViewNums.CellContentClick += dataGridViewNums_CellContentClick;
            // 
            // groupBoxUslovie
            // 
            groupBoxUslovie.BackColor = SystemColors.Control;
            groupBoxUslovie.Controls.Add(textBoxUslovie);
            groupBoxUslovie.Location = new Point(4, 4);
            groupBoxUslovie.Name = "groupBoxUslovie";
            groupBoxUslovie.Size = new Size(736, 140);
            groupBoxUslovie.TabIndex = 1;
            groupBoxUslovie.TabStop = false;
            groupBoxUslovie.Text = "Условие:";
            // 
            // textBoxUslovie
            // 
            textBoxUslovie.BackColor = SystemColors.Control;
            textBoxUslovie.BorderStyle = BorderStyle.None;
            textBoxUslovie.Location = new Point(8, 30);
            textBoxUslovie.Multiline = true;
            textBoxUslovie.Name = "textBoxUslovie";
            textBoxUslovie.ReadOnly = true;
            textBoxUslovie.Size = new Size(698, 104);
            textBoxUslovie.TabIndex = 0;
            textBoxUslovie.Text = "Прочитать данные из файла InPutFileTask5V9.txt. Вывести\r\nв dataGridView элементы равные 0 и построить диаграмму\r\nпо этим значениям.\r\n";
            // 
            // chartDiag
            // 
            chartDiag.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartArea1.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea1);
            chartDiag.Location = new Point(345, 181);
            chartDiag.Name = "chartDiag";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chartDiag.Series.Add(series1);
            chartDiag.Size = new Size(844, 472);
            chartDiag.TabIndex = 3;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1218, 685);
            Controls.Add(chartDiag);
            Controls.Add(groupBoxUslovie);
            Controls.Add(panelLeft);
            Controls.Add(panelHead);
            MinimumSize = new Size(1240, 741);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 9 | Хотеева Е. В.";
            Load += FormMain_Load;
            panelHead.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            groupBoxUslovie.ResumeLayout(false);
            groupBoxUslovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead;
        private Panel panelLeft;
        private GroupBox groupBoxUslovie;
        private TextBox textBoxUslovie;
        private Button buttonOpenFile;
        private Button buttonDone;
        private Button buttonInfo;
        private GroupBox groupBoxOut;
        private DataGridView dataGridViewNums;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
    }
}
