namespace Tyuiu.ReshetovaAA.Sprint6.Task7.V23
{
    partial class FormAbout_RAA
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            labelInfo_RAA = new Label();
            pictureBoxPhoto_RAA = new PictureBox();
            buttonOk_RAA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_RAA).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_RAA
            // 
            labelInfo_RAA.AutoSize = true;
            labelInfo_RAA.Location = new System.Drawing.Point(170, 20);
            labelInfo_RAA.Name = "labelInfo_RAA";
            labelInfo_RAA.Size = new System.Drawing.Size(430, 180);
            labelInfo_RAA.TabIndex = 0;
            labelInfo_RAA.Text =
                "Разработчик: Решетова А.А.\r\n" +
                "Группа: СМАРТб-25-1\r\n\r\n" +
                "Программа разработана в рамках изучения языка C#\r\n\r\n" +
                "Тюменский индустриальный университет (c) 2025\r\n" +
                "Высшая школа цифровых технологий (c) 2025\r\n\r\n" +
                "Внутреннее имя:\r\n" +
                "Tyuiu.ReshetovaAA.Sprint6.Task7.V23";
            // 
            // pictureBoxPhoto_RAA
            // 
            pictureBoxPhoto_RAA.Location = new System.Drawing.Point(15, 15);
            pictureBoxPhoto_RAA.Name = "pictureBoxPhoto_RAA";
            pictureBoxPhoto_RAA.Size = new System.Drawing.Size(140, 180);
            pictureBoxPhoto_RAA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto_RAA.TabIndex = 1;
            pictureBoxPhoto_RAA.TabStop = false;

            // 🔽 ВАЖНО: твоя фотография
            // Добавь изображение с именем "me" в Properties → Resources
            pictureBoxPhoto_RAA.Image = Properties.Resources.me;

            // 
            // buttonOk_RAA
            // 
            buttonOk_RAA.Location = new System.Drawing.Point(480, 215);
            buttonOk_RAA.Name = "buttonOk_RAA";
            buttonOk_RAA.Size = new System.Drawing.Size(120, 35);
            buttonOk_RAA.TabIndex = 2;
            buttonOk_RAA.Text = "OK";
            buttonOk_RAA.UseVisualStyleBackColor = true;
            buttonOk_RAA.Click += buttonOk_RAA_Click;
            // 
            // FormAbout_RAA
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(620, 265);
            Controls.Add(buttonOk_RAA);
            Controls.Add(pictureBoxPhoto_RAA);
            Controls.Add(labelInfo_RAA);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout_RAA";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto_RAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_RAA;
        private PictureBox pictureBoxPhoto_RAA;
        private Button buttonOk_RAA;
    }
}