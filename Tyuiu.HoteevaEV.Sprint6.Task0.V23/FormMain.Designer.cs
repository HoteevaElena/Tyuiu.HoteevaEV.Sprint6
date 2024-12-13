namespace Tyuiu.HoteevaEV.Sprint6.Task0.V23
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
            textBoxTask = new TextBox();
            groupBox1 = new GroupBox();
            textBoxVarX = new TextBox();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            textBoxResult = new TextBox();
            textBox3 = new TextBox();
            buttonResult = new Button();
            buttonInfo = new Button();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(pictureBoxFormula);
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 21);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(756, 255);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            groupBoxTask.Enter += groupBox1_Enter;
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(525, 30);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(191, 86);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            pictureBoxFormula.Click += pictureBoxFormula_Click;
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Control;
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Location = new Point(0, 30);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(313, 54);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Вычислить выражение по формуле\r\n";
            textBoxTask.TextChanged += textBoxTask_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxVarX);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Location = new Point(12, 288);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(460, 150);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(6, 67);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(150, 31);
            textBoxVarX.TabIndex = 4;
            textBoxVarX.TextChanged += textBoxVarX_TextChanged;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(6, 30);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(150, 24);
            textBox2.TabIndex = 0;
            textBox2.Text = "Переменная Х:";
            textBox2.TextChanged += textBoxValueX_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(488, 288);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 150);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.AllowDrop = true;
            textBoxResult.BackColor = SystemColors.Control;
            textBoxResult.BorderStyle = BorderStyle.None;
            textBoxResult.Location = new Point(6, 67);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(288, 24);
            textBoxResult.TabIndex = 5;
            textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Control;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(6, 30);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(150, 24);
            textBox3.TabIndex = 0;
            textBox3.Text = "Результат:";
            textBox3.TextChanged += textBoxTextRes_TextChanged;
            // 
            // buttonResult
            // 
            buttonResult.Location = new Point(643, 451);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(125, 47);
            buttonResult.TabIndex = 2;
            buttonResult.Text = "Выполнить";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonDone_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Location = new Point(570, 451);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(50, 47);
            buttonInfo.TabIndex = 3;
            buttonInfo.Text = "?";
            buttonInfo.UseVisualStyleBackColor = true;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(buttonInfo);
            Controls.Add(buttonResult);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxTask);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 23 | Хотеева Е. В.";
            Load += FormMain_Load;
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonResult;
        private Button buttonInfo;
        private TextBox textBoxVarX;
        private TextBox textBoxResult;
    }
}
