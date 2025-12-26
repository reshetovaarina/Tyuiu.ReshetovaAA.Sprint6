using System.Windows.Forms;

namespace Tyuiu.ReshetovaAA.Sprint6.Task7.V23
{
    partial class FormAbout_RAA
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
            this.pictureBoxPhoto_RAA = new System.Windows.Forms.PictureBox();
            this.labelInfo_RAA = new System.Windows.Forms.Label();
            this.buttonOK_RAA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_RAA)).BeginInit();
            this.SuspendLayout();

            // pictureBoxPhoto_RAA

            this.pictureBoxPhoto_RAA.Image = Properties.Resources.photo_me;
            this.pictureBoxPhoto_RAA.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPhoto_RAA.Name = "pictureBoxPhoto_RAA";
            this.pictureBoxPhoto_RAA.Size = new System.Drawing.Size(140, 180);
            this.pictureBoxPhoto_RAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPhoto_RAA.TabIndex = 0;
            this.pictureBoxPhoto_RAA.TabStop = false;

            // labelInfo_RAA

            this.labelInfo_RAA.AutoSize = true;
            this.labelInfo_RAA.Location = new System.Drawing.Point(170, 20);
            this.labelInfo_RAA.Name = "labelInfo_RAA";
            this.labelInfo_RAA.Size = new System.Drawing.Size(330, 90);
            this.labelInfo_RAA.TabIndex = 1;
            this.labelInfo_RAA.Text = "Разработчик: Решетова Арина А.\r\nГруппа: СМАРТб-25-1\r\nТюменский индустриальный университет\r\nВысшая школа цифровых технологий\r\n\r\nСпринт 6, Task 7, Variant 23";

            // buttonOK_RAA

            this.buttonOK_RAA.Location = new System.Drawing.Point(390, 165);
            this.buttonOK_RAA.Name = "buttonOK_RAA";
            this.buttonOK_RAA.Size = new System.Drawing.Size(110, 30);
            this.buttonOK_RAA.TabIndex = 2;
            this.buttonOK_RAA.Text = "ОК";
            this.buttonOK_RAA.UseVisualStyleBackColor = true;
            this.buttonOK_RAA.Click += new System.EventHandler(this.buttonOK_RAA_Click);

            // FormAbout_RAA

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 211);
            this.Controls.Add(this.buttonOK_RAA);
            this.Controls.Add(this.labelInfo_RAA);
            this.Controls.Add(this.pictureBoxPhoto_RAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout_RAA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto_RAA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPhoto_RAA;
        private System.Windows.Forms.Label labelInfo_RAA;
        private System.Windows.Forms.Button buttonOK_RAA;
    }
}
