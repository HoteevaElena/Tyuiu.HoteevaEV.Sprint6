namespace Tyuiu.HoteevaEV.Sprint6.Task3.V10
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
            groupBoxUslovie_HEV = new GroupBox();
            dataGridViewMatrix = new DataGridView();
            textBoxData_HEV = new TextBox();
            groupBoxOutPut_HEV = new GroupBox();
            textBoxResult_HEV = new TextBox();
            textBoxResultText_HEV = new TextBox();
            buttonDone_HEV = new Button();
            buttonInfo_HEV = new Button();
            groupBoxUslovie_HEV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBoxOutPut_HEV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie_HEV
            // 
            groupBoxUslovie_HEV.Controls.Add(dataGridViewMatrix);
            groupBoxUslovie_HEV.Controls.Add(textBoxData_HEV);
            groupBoxUslovie_HEV.Location = new Point(12, 0);
            groupBoxUslovie_HEV.Name = "groupBoxUslovie_HEV";
            groupBoxUslovie_HEV.Size = new Size(752, 438);
            groupBoxUslovie_HEV.TabIndex = 0;
            groupBoxUslovie_HEV.TabStop = false;
            groupBoxUslovie_HEV.Text = "Условие";
            groupBoxUslovie_HEV.Enter += groupBox1_Enter;
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(403, 27);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersWidth = 62;
            dataGridViewMatrix.Size = new Size(331, 393);
            dataGridViewMatrix.TabIndex = 1;
            // 
            // textBoxData_HEV
            // 
            textBoxData_HEV.BackColor = SystemColors.Control;
            textBoxData_HEV.BorderStyle = BorderStyle.None;
            textBoxData_HEV.Location = new Point(3, 27);
            textBoxData_HEV.Multiline = true;
            textBoxData_HEV.Name = "textBoxData_HEV";
            textBoxData_HEV.ReadOnly = true;
            textBoxData_HEV.Size = new Size(360, 405);
            textBoxData_HEV.TabIndex = 0;
            textBoxData_HEV.Text = resources.GetString("textBoxData_HEV.Text");
            // 
            // groupBoxOutPut_HEV
            // 
            groupBoxOutPut_HEV.Controls.Add(textBoxResult_HEV);
            groupBoxOutPut_HEV.Controls.Add(textBoxResultText_HEV);
            groupBoxOutPut_HEV.Location = new Point(783, 0);
            groupBoxOutPut_HEV.Name = "groupBoxOutPut_HEV";
            groupBoxOutPut_HEV.Size = new Size(267, 392);
            groupBoxOutPut_HEV.TabIndex = 1;
            groupBoxOutPut_HEV.TabStop = false;
            groupBoxOutPut_HEV.Text = "Вывод данных:";
            // 
            // textBoxResult_HEV
            // 
            textBoxResult_HEV.BackColor = SystemColors.ButtonHighlight;
            textBoxResult_HEV.BorderStyle = BorderStyle.FixedSingle;
            textBoxResult_HEV.Location = new Point(18, 60);
            textBoxResult_HEV.Multiline = true;
            textBoxResult_HEV.Name = "textBoxResult_HEV";
            textBoxResult_HEV.ReadOnly = true;
            textBoxResult_HEV.Size = new Size(189, 54);
            textBoxResult_HEV.TabIndex = 1;
            textBoxResult_HEV.TextChanged += textBoxResult_HEV_TextChanged;
            // 
            // textBoxResultText_HEV
            // 
            textBoxResultText_HEV.BorderStyle = BorderStyle.None;
            textBoxResultText_HEV.Location = new Point(18, 30);
            textBoxResultText_HEV.Name = "textBoxResultText_HEV";
            textBoxResultText_HEV.ReadOnly = true;
            textBoxResultText_HEV.Size = new Size(150, 24);
            textBoxResultText_HEV.TabIndex = 0;
            textBoxResultText_HEV.Text = "Результат:";
            textBoxResultText_HEV.TextChanged += textBox1_TextChanged;
            // 
            // buttonDone_HEV
            // 
            buttonDone_HEV.Location = new Point(883, 398);
            buttonDone_HEV.Name = "buttonDone_HEV";
            buttonDone_HEV.Size = new Size(150, 40);
            buttonDone_HEV.TabIndex = 2;
            buttonDone_HEV.Text = "Выполнить";
            buttonDone_HEV.UseVisualStyleBackColor = true;
            buttonDone_HEV.Click += buttonDone_HEV_Click;
            // 
            // buttonInfo_HEV
            // 
            buttonInfo_HEV.Location = new Point(801, 398);
            buttonInfo_HEV.Name = "buttonInfo_HEV";
            buttonInfo_HEV.Size = new Size(50, 40);
            buttonInfo_HEV.TabIndex = 3;
            buttonInfo_HEV.Text = "?";
            buttonInfo_HEV.UseVisualStyleBackColor = true;
            buttonInfo_HEV.Click += buttonInfo_HEV_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 450);
            Controls.Add(buttonInfo_HEV);
            Controls.Add(buttonDone_HEV);
            Controls.Add(groupBoxOutPut_HEV);
            Controls.Add(groupBoxUslovie_HEV);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 10 | Хотеева Е. В.";
            Load += FormMain_Load;
            groupBoxUslovie_HEV.ResumeLayout(false);
            groupBoxUslovie_HEV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBoxOutPut_HEV.ResumeLayout(false);
            groupBoxOutPut_HEV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUslovie_HEV;
        private GroupBox groupBoxOutPut_HEV;
        private TextBox textBoxResultText_HEV;
        private TextBox textBoxResult_HEV;
        private Button buttonDone_HEV;
        private Button buttonInfo_HEV;
        private TextBox textBoxData_HEV;
        private DataGridView dataGridViewMatrix;
    }
}
