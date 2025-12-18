namespace Tyuiu.ReshetovaAA.Sprint6.Task6.V2
{
    partial class FormAbout
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pictureBox_RAA = new System.Windows.Forms.PictureBox();
            this.labelInfo_RAA = new System.Windows.Forms.Label();
            this.buttonOK_RAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RAA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_RAA
            // 
            this.pictureBox_RAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_RAA.Name = "pictureBox_RAA";
            this.pictureBox_RAA.Size = new System.Drawing.Size(160, 160);
            this.pictureBox_RAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_RAA.TabIndex = 0;
            this.pictureBox_RAA.TabStop = false;
            // можешь потом поставить картинку:
            // this.pictureBox_RAA.Image = Properties.Resources.about;
            // 
            // labelInfo_RAA
            // 
            this.labelInfo_RAA.Location = new System.Drawing.Point(188, 12);
            this.labelInfo_RAA.Name = "labelInfo_RAA";
            this.labelInfo_RAA.Size = new System.Drawing.Size(360, 140);
            this.labelInfo_RAA.TabIndex = 1;
            this.labelInfo_RAA.Text = "Разработчик: Reshetova A.A.\r\nГруппа: ...\r\n\r\nПрограмма разработана в рамках изучения C#\r\n\r\nВнутреннее имя: Tyuiu.ReshetovaAA.Sprint6.Task6.V2";
            // 
            // buttonOK_RAA
            // 
            this.buttonOK_RAA.Location = new System.Drawing.Point(473, 155);
            this.buttonOK_RAA.Name = "buttonOK_RAA";
            this.buttonOK_RAA.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_RAA.TabIndex = 2;
            this.buttonOK_RAA.Text = "OK";
            this.buttonOK_RAA.UseVisualStyleBackColor = true;
            this.buttonOK_RAA.Click += new System.EventHandler(this.buttonOK_RAA_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 190);
            this.Controls.Add(this.buttonOK_RAA);
            this.Controls.Add(this.labelInfo_RAA);
            this.Controls.Add(this.pictureBox_RAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_RAA;
        private System.Windows.Forms.Label labelInfo_RAA;
        private System.Windows.Forms.Button buttonOK_RAA;
    }
}