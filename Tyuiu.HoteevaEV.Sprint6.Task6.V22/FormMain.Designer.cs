namespace Tyuiu.HoteevaEV.Sprint6.Task6.V22
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelHead = new Panel();
            groupBoxUslovie = new GroupBox();
            textBoxUslovie = new TextBox();
            buttonOpen = new Button();
            buttonInfo = new Button();
            buttonDone = new Button();
            panelLeft = new Panel();
            groupBoxOutPutData = new GroupBox();
            textBoxLoadFromFile = new TextBox();
            panelRight = new Panel();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            splitter1 = new Splitter();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            panelHead.SuspendLayout();
            groupBoxUslovie.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxOutPutData.SuspendLayout();
            panelRight.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.Controls.Add(groupBoxUslovie);
            panelHead.Controls.Add(buttonOpen);
            panelHead.Controls.Add(buttonInfo);
            panelHead.Controls.Add(buttonDone);
            panelHead.Dock = DockStyle.Top;
            panelHead.Location = new Point(0, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(1322, 263);
            panelHead.TabIndex = 0;
            panelHead.Paint += panelHead_Paint;
            // 
            // groupBoxUslovie
            // 
            groupBoxUslovie.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxUslovie.Controls.Add(textBoxUslovie);
            groupBoxUslovie.Location = new Point(3, 123);
            groupBoxUslovie.Name = "groupBoxUslovie";
            groupBoxUslovie.Size = new Size(1316, 137);
            groupBoxUslovie.TabIndex = 1;
            groupBoxUslovie.TabStop = false;
            groupBoxUslovie.Text = "Условие:";
            groupBoxUslovie.Enter += groupBoxUslovie_Enter;
            // 
            // textBoxUslovie
            // 
            textBoxUslovie.BackColor = SystemColors.Control;
            textBoxUslovie.BorderStyle = BorderStyle.None;
            textBoxUslovie.Location = new Point(32, 30);
            textBoxUslovie.Multiline = true;
            textBoxUslovie.Name = "textBoxUslovie";
            textBoxUslovie.ReadOnly = true;
            textBoxUslovie.Size = new Size(1261, 88);
            textBoxUslovie.TabIndex = 1;
            textBoxUslovie.Text = resources.GetString("textBoxUslovie.Text");
            textBoxUslovie.TextChanged += textBox1_TextChanged;
            // 
            // buttonOpen
            // 
            buttonOpen.BackColor = SystemColors.ButtonHighlight;
            buttonOpen.FlatStyle = FlatStyle.Flat;
            buttonOpen.Image = Properties.Resources.Открыть_файл2;
            buttonOpen.Location = new Point(3, 3);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(141, 114);
            buttonOpen.TabIndex = 1;
            toolTip.SetToolTip(buttonOpen, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpen.UseVisualStyleBackColor = false;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo.BackColor = SystemColors.ButtonHighlight;
            buttonInfo.FlatStyle = FlatStyle.Flat;
            buttonInfo.Image = Properties.Resources.Информация;
            buttonInfo.Location = new Point(1169, 3);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(141, 114);
            buttonInfo.TabIndex = 3;
            toolTip.SetToolTip(buttonInfo, "Информация о программе");
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.ButtonHighlight;
            buttonDone.Enabled = false;
            buttonDone.FlatStyle = FlatStyle.Flat;
            buttonDone.Image = Properties.Resources.Выполнить_действие_над_файлом;
            buttonDone.Location = new Point(178, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(141, 114);
            buttonDone.TabIndex = 2;
            toolTip.SetToolTip(buttonDone, "Соединяет первые слова во всех строках в одну строку");
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBoxOutPutData);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 263);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(647, 415);
            panelLeft.TabIndex = 1;
            // 
            // groupBoxOutPutData
            // 
            groupBoxOutPutData.Controls.Add(textBoxLoadFromFile);
            groupBoxOutPutData.Dock = DockStyle.Fill;
            groupBoxOutPutData.Location = new Point(0, 0);
            groupBoxOutPutData.Name = "groupBoxOutPutData";
            groupBoxOutPutData.Size = new Size(647, 415);
            groupBoxOutPutData.TabIndex = 0;
            groupBoxOutPutData.TabStop = false;
            groupBoxOutPutData.Text = "Ввод:";
            // 
            // textBoxLoadFromFile
            // 
            textBoxLoadFromFile.BackColor = SystemColors.ControlLightLight;
            textBoxLoadFromFile.Dock = DockStyle.Fill;
            textBoxLoadFromFile.Location = new Point(3, 27);
            textBoxLoadFromFile.Multiline = true;
            textBoxLoadFromFile.Name = "textBoxLoadFromFile";
            textBoxLoadFromFile.ReadOnly = true;
            textBoxLoadFromFile.ScrollBars = ScrollBars.Vertical;
            textBoxLoadFromFile.Size = new Size(641, 385);
            textBoxLoadFromFile.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(groupBoxResult);
            panelRight.Dock = DockStyle.Right;
            panelRight.Location = new Point(653, 263);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(669, 415);
            panelRight.TabIndex = 0;
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Dock = DockStyle.Fill;
            groupBoxResult.Location = new Point(0, 0);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(669, 415);
            groupBoxResult.TabIndex = 1;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод:";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.ControlLightLight;
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 27);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(663, 385);
            textBoxResult.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(647, 263);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 415);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 678);
            Controls.Add(splitter1);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelHead);
            MinimumSize = new Size(1344, 734);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 22 | Хотеева Е. В.";
            Load += FormMain_Load;
            panelHead.ResumeLayout(false);
            groupBoxUslovie.ResumeLayout(false);
            groupBoxUslovie.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBoxOutPutData.ResumeLayout(false);
            groupBoxOutPutData.PerformLayout();
            panelRight.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead;
        private Button buttonOpen;
        private Button buttonInfo;
        private Button buttonDone;
        private PictureBox pictureBoxSave;
        private PictureBox pictureBoxInfo;
        private GroupBox groupBoxUslovie;
        private TextBox textBoxUslovie;
        private Panel panelLeft;
        private Panel panelRight;
        private Splitter splitter1;
        private GroupBox groupBoxOutPutData;
        private GroupBox groupBoxResult;
        private TextBox textBoxLoadFromFile;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
        private TextBox textBoxResult;
    }
}
