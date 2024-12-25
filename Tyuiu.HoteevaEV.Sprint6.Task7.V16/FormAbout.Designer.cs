namespace Tyuiu.HoteevaEV.Sprint6.Task7.V16
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
            textBoxAbout = new TextBox();
            pictureBoxAva = new PictureBox();
            buttonOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva).BeginInit();
            SuspendLayout();
            // 
            // textBoxAbout
            // 
            textBoxAbout.BackColor = SystemColors.Control;
            textBoxAbout.BorderStyle = BorderStyle.None;
            textBoxAbout.Location = new Point(260, 11);
            textBoxAbout.Multiline = true;
            textBoxAbout.Name = "textBoxAbout";
            textBoxAbout.ReadOnly = true;
            textBoxAbout.Size = new Size(576, 228);
            textBoxAbout.TabIndex = 3;
            textBoxAbout.Text = resources.GetString("textBoxAbout.Text");
            // 
            // pictureBoxAva
            // 
            pictureBoxAva.Location = new Point(0, -1);
            pictureBoxAva.Name = "pictureBoxAva";
            pictureBoxAva.Size = new Size(240, 240);
            pictureBoxAva.TabIndex = 4;
            pictureBoxAva.TabStop = false;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(724, 259);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(112, 34);
            buttonOk.TabIndex = 5;
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
            Controls.Add(pictureBoxAva);
            Controls.Add(textBoxAbout);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAbout;
        private PictureBox pictureBoxAva;
        private Button buttonOk;
    }
}