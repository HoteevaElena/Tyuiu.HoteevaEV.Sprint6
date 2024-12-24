namespace Tyuiu.HoteevaEV.Sprint6.Task6.V22
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAva = new PictureBox();
            label1 = new Label();
            textBoxAbout = new TextBox();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAva
            // 
            pictureBoxAva.Location = new Point(0, 0);
            pictureBoxAva.Name = "pictureBoxAva";
            pictureBoxAva.Size = new Size(240, 240);
            pictureBoxAva.TabIndex = 0;
            pictureBoxAva.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(399, 75);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // textBoxAbout
            // 
            textBoxAbout.BackColor = SystemColors.Control;
            textBoxAbout.BorderStyle = BorderStyle.None;
            textBoxAbout.Location = new Point(271, 12);
            textBoxAbout.Multiline = true;
            textBoxAbout.Name = "textBoxAbout";
            textBoxAbout.ReadOnly = true;
            textBoxAbout.Size = new Size(576, 228);
            textBoxAbout.TabIndex = 2;
            textBoxAbout.Text = resources.GetString("textBoxAbout.Text");
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(735, 263);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 34);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 320);
            Controls.Add(buttonOk);
            Controls.Add(textBoxAbout);
            Controls.Add(label1);
            Controls.Add(pictureBoxAva);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAva;
        private Label label1;
        private TextBox textBoxAbout;
        private Button buttonOk;
    }
}