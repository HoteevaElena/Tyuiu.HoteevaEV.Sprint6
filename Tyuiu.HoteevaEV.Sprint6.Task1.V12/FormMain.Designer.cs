namespace Tyuiu.HoteevaEV.Sprint6.Task1.V12
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
            groupBoxTask = new GroupBox();
            pictureBoxFormula = new PictureBox();
            textBoxUslovie = new TextBox();
            groupBoxOutPut = new GroupBox();
            textBoxResult = new TextBox();
            textBoxResText = new TextBox();
            groupBoxInPut = new GroupBox();
            buttonDone = new Button();
            buttonInfo = new Button();
            textBoxEnd = new TextBox();
            textBoxStart = new TextBox();
            textBoxEndText = new TextBox();
            textBoxStartText = new TextBox();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxOutPut.SuspendLayout();
            groupBoxInPut.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBoxFormula);
            groupBoxTask.Controls.Add(textBoxUslovie);
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(665, 304);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие ";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(6, 96);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(415, 55);
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
            textBoxUslovie.Size = new Size(490, 80);
            textBoxUslovie.TabIndex = 0;
            textBoxUslovie.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.\r\n";
            textBoxUslovie.TextChanged += textBoxUslovie_TextChanged;
            // 
            // groupBoxOutPut
            // 
            groupBoxOutPut.Controls.Add(textBoxResult);
            groupBoxOutPut.Controls.Add(textBoxResText);
            groupBoxOutPut.Location = new Point(680, 0);
            groupBoxOutPut.Name = "groupBoxOutPut";
            groupBoxOutPut.Size = new Size(423, 445);
            groupBoxOutPut.TabIndex = 1;
            groupBoxOutPut.TabStop = false;
            groupBoxOutPut.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Control;
            textBoxResult.BorderStyle = BorderStyle.None;
            textBoxResult.Location = new Point(15, 60);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(395, 364);
            textBoxResult.TabIndex = 1;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // textBoxResText
            // 
            textBoxResText.BackColor = SystemColors.Control;
            textBoxResText.BorderStyle = BorderStyle.None;
            textBoxResText.Location = new Point(15, 30);
            textBoxResText.Name = "textBoxResText";
            textBoxResText.ReadOnly = true;
            textBoxResText.Size = new Size(150, 24);
            textBoxResText.TabIndex = 0;
            textBoxResText.Text = "Результат:";
            // 
            // groupBoxInPut
            // 
            groupBoxInPut.Controls.Add(buttonDone);
            groupBoxInPut.Controls.Add(buttonInfo);
            groupBoxInPut.Controls.Add(textBoxEnd);
            groupBoxInPut.Controls.Add(textBoxStart);
            groupBoxInPut.Controls.Add(textBoxEndText);
            groupBoxInPut.Controls.Add(textBoxStartText);
            groupBoxInPut.Location = new Point(3, 310);
            groupBoxInPut.Name = "groupBoxInPut";
            groupBoxInPut.Size = new Size(662, 135);
            groupBoxInPut.TabIndex = 2;
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
            textBoxEnd.TextChanged += textBoxEnd_TextChanged_1;
            textBoxEnd.KeyPress += textBoxStart_KeyPress;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(6, 83);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(150, 31);
            textBoxStart.TabIndex = 3;
            textBoxStart.TextChanged += textBoxStart_TextChanged;
            textBoxStart.KeyPress += textBoxStart_KeyPress;
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
            textBoxEndText.TextChanged += textBoxEndText_TextChanged;
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 457);
            Controls.Add(groupBoxInPut);
            Controls.Add(groupBoxOutPut);
            Controls.Add(groupBoxTask);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 12 | Хотеева Е. В.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxOutPut.ResumeLayout(false);
            groupBoxOutPut.PerformLayout();
            groupBoxInPut.ResumeLayout(false);
            groupBoxInPut.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxUslovie;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBoxOutPut;
        private TextBox textBoxResText;
        private TextBox textBoxResult;
        private GroupBox groupBoxInPut;
        private TextBox textBoxStart;
        private TextBox textBoxEndText;
        private TextBox textBoxStartText;
        private TextBox textBoxEnd;
        private Button buttonDone;
        private Button buttonInfo;
    }
}
