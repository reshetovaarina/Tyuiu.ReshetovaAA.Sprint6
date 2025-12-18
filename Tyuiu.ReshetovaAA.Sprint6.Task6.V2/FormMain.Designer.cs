namespace Tyuiu.ReshetovaAA.Sprint6.Task6.V2
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxCondition_RAA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_RAA = new System.Windows.Forms.PictureBox();
            this.labelCondition_RAA = new System.Windows.Forms.Label();
            this.groupBoxIn_RAA = new System.Windows.Forms.GroupBox();
            this.textBoxIn_RAA = new System.Windows.Forms.TextBox();
            this.groupBoxOut_RAA = new System.Windows.Forms.GroupBox();
            this.textBoxOut_RAA = new System.Windows.Forms.TextBox();
            this.buttonOpenFile_RAA = new System.Windows.Forms.Button();
            this.buttonDone_RAA = new System.Windows.Forms.Button();
            this.buttonHelp_RAA = new System.Windows.Forms.Button();
            this.openFileDialogTask_RAA = new System.Windows.Forms.OpenFileDialog();
            this.labelPath_RAA = new System.Windows.Forms.Label();
            this.toolTip_RAA = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxCondition_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_RAA)).BeginInit();
            this.groupBoxIn_RAA.SuspendLayout();
            this.groupBoxOut_RAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_RAA
            // 
            this.groupBoxCondition_RAA.Controls.Add(this.pictureBoxFormula_RAA);
            this.groupBoxCondition_RAA.Controls.Add(this.labelCondition_RAA);
            this.groupBoxCondition_RAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_RAA.Name = "groupBoxCondition_RAA";
            this.groupBoxCondition_RAA.Size = new System.Drawing.Size(776, 155);
            this.groupBoxCondition_RAA.TabIndex = 0;
            this.groupBoxCondition_RAA.TabStop = false;
            this.groupBoxCondition_RAA.Text = "Условие";
            // 
            // pictureBoxFormula_RAA
            // 
            // ВСТАВЬ СЮДА СВОЮ КАРТИНКУ (если добавишь в Resources)
            // this.pictureBoxFormula_RAA.Image = Properties.Resources.formula;
            this.pictureBoxFormula_RAA.Location = new System.Drawing.Point(420, 22);
            this.pictureBoxFormula_RAA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxFormula_RAA.Name = "pictureBoxFormula_RAA";
            this.pictureBoxFormula_RAA.Size = new System.Drawing.Size(340, 120);
            this.pictureBoxFormula_RAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFormula_RAA.TabIndex = 1;
            this.pictureBoxFormula_RAA.TabStop = false;
            // 
            // labelCondition_RAA
            // 
            this.labelCondition_RAA.Location = new System.Drawing.Point(15, 22);
            this.labelCondition_RAA.Name = "labelCondition_RAA";
            this.labelCondition_RAA.Size = new System.Drawing.Size(390, 120);
            this.labelCondition_RAA.TabIndex = 0;
            this.labelCondition_RAA.Text = "Дан файл InPutFileTask6V2.txt";
            // 
            // groupBoxIn_RAA
            // 
            this.groupBoxIn_RAA.Controls.Add(this.textBoxIn_RAA);
            this.groupBoxIn_RAA.Location = new System.Drawing.Point(12, 199);
            this.groupBoxIn_RAA.Name = "groupBoxIn_RAA";
            this.groupBoxIn_RAA.Size = new System.Drawing.Size(376, 239);
            this.groupBoxIn_RAA.TabIndex = 1;
            this.groupBoxIn_RAA.TabStop = false;
            this.groupBoxIn_RAA.Text = "Ввод";
            // 
            // textBoxIn_RAA
            // 
            this.textBoxIn_RAA.Location = new System.Drawing.Point(6, 22);
            this.textBoxIn_RAA.Multiline = true;
            this.textBoxIn_RAA.Name = "textBoxIn_RAA";
            this.textBoxIn_RAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIn_RAA.Size = new System.Drawing.Size(364, 211);
            this.textBoxIn_RAA.TabIndex = 0;
            // 
            // groupBoxOut_RAA
            // 
            this.groupBoxOut_RAA.Controls.Add(this.textBoxOut_RAA);
            this.groupBoxOut_RAA.Location = new System.Drawing.Point(412, 199);
            this.groupBoxOut_RAA.Name = "groupBoxOut_RAA";
            this.groupBoxOut_RAA.Size = new System.Drawing.Size(376, 239);
            this.groupBoxOut_RAA.TabIndex = 2;
            this.groupBoxOut_RAA.TabStop = false;
            this.groupBoxOut_RAA.Text = "Вывод";
            // 
            // textBoxOut_RAA
            // 
            this.textBoxOut_RAA.Location = new System.Drawing.Point(6, 22);
            this.textBoxOut_RAA.Multiline = true;
            this.textBoxOut_RAA.Name = "textBoxOut_RAA";
            this.textBoxOut_RAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOut_RAA.Size = new System.Drawing.Size(364, 211);
            this.textBoxOut_RAA.TabIndex = 0;
            // 
            // buttonOpenFile_RAA
            // 
            this.buttonOpenFile_RAA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonOpenFile_RAA.Location = new System.Drawing.Point(12, 173);
            this.buttonOpenFile_RAA.Name = "buttonOpenFile_RAA";
            this.buttonOpenFile_RAA.Size = new System.Drawing.Size(110, 23);
            this.buttonOpenFile_RAA.TabIndex = 3;
            this.buttonOpenFile_RAA.Text = "Открыть файл";
            this.toolTip_RAA.SetToolTip(this.buttonOpenFile_RAA, "Выбрать файл для обработки");
            this.buttonOpenFile_RAA.UseVisualStyleBackColor = false;
            this.buttonOpenFile_RAA.Click += new System.EventHandler(this.buttonOpenFile_RAA_Click);
            // 
            // buttonDone_RAA
            // 
            this.buttonDone_RAA.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDone_RAA.Location = new System.Drawing.Point(128, 173);
            this.buttonDone_RAA.Name = "buttonDone_RAA";
            this.buttonDone_RAA.Size = new System.Drawing.Size(110, 23);
            this.buttonDone_RAA.TabIndex = 4;
            this.buttonDone_RAA.Text = "Выполнить";
            this.toolTip_RAA.SetToolTip(this.buttonDone_RAA, "Выполнить обработку");
            this.buttonDone_RAA.UseVisualStyleBackColor = false;
            this.buttonDone_RAA.Click += new System.EventHandler(this.buttonDone_RAA_Click);
            // 
            // buttonHelp_RAA
            // 
            this.buttonHelp_RAA.BackColor = System.Drawing.Color.Khaki;
            this.buttonHelp_RAA.Location = new System.Drawing.Point(678, 173);
            this.buttonHelp_RAA.Name = "buttonHelp_RAA";
            this.buttonHelp_RAA.Size = new System.Drawing.Size(110, 23);
            this.buttonHelp_RAA.TabIndex = 5;
            this.buttonHelp_RAA.Text = "Справка";
            this.toolTip_RAA.SetToolTip(this.buttonHelp_RAA, "О программе");
            this.buttonHelp_RAA.UseVisualStyleBackColor = false;
            this.buttonHelp_RAA.Click += new System.EventHandler(this.buttonHelp_RAA_Click);
            // 
            // openFileDialogTask_RAA
            // 
            this.openFileDialogTask_RAA.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialogTask_RAA.Title = "Выберите текстовый файл";
            // 
            // labelPath_RAA
            // 
            this.labelPath_RAA.AutoEllipsis = true;
            this.labelPath_RAA.Location = new System.Drawing.Point(258, 173);
            this.labelPath_RAA.Name = "labelPath_RAA";
            this.labelPath_RAA.Size = new System.Drawing.Size(414, 23);
            this.labelPath_RAA.TabIndex = 6;
            this.labelPath_RAA.Text = "Файл не выбран";
            this.labelPath_RAA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPath_RAA);
            this.Controls.Add(this.buttonHelp_RAA);
            this.Controls.Add(this.buttonDone_RAA);
            this.Controls.Add(this.buttonOpenFile_RAA);
            this.Controls.Add(this.groupBoxOut_RAA);
            this.Controls.Add(this.groupBoxIn_RAA);
            this.Controls.Add(this.groupBoxCondition_RAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprint 6 | Task 6 | Variant 2 | Reshetova A.A.";
            this.groupBoxCondition_RAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_RAA)).EndInit();
            this.groupBoxIn_RAA.ResumeLayout(false);
            this.groupBoxIn_RAA.PerformLayout();
            this.groupBoxOut_RAA.ResumeLayout(false);
            this.groupBoxOut_RAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_RAA;
        private System.Windows.Forms.Label labelCondition_RAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_RAA;
        private System.Windows.Forms.GroupBox groupBoxIn_RAA;
        private System.Windows.Forms.TextBox textBoxIn_RAA;
        private System.Windows.Forms.GroupBox groupBoxOut_RAA;
        private System.Windows.Forms.TextBox textBoxOut_RAA;
        private System.Windows.Forms.Button buttonOpenFile_RAA;
        private System.Windows.Forms.Button buttonDone_RAA;
        private System.Windows.Forms.Button buttonHelp_RAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_RAA;
        private System.Windows.Forms.Label labelPath_RAA;
        private System.Windows.Forms.ToolTip toolTip_RAA;
    }
}
