namespace Tyuiu.ReshetovaAA.Sprint6.Task0.V4
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
            this.groupBoxCondition_RAA = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula_RAA = new System.Windows.Forms.PictureBox();
            this.labelCond_RAA = new System.Windows.Forms.Label();
            this.groupBoxInput_RAA = new System.Windows.Forms.GroupBox();
            this.labelX_RAA = new System.Windows.Forms.Label();
            this.textBoxVarX_RAA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_RAA = new System.Windows.Forms.GroupBox();
            this.labelResult_RAA = new System.Windows.Forms.Label();
            this.textBoxResult_RAA = new System.Windows.Forms.TextBox();
            this.buttonHelp_RAA = new System.Windows.Forms.Button();
            this.buttonCalc_RAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_RAA)).BeginInit();
            this.groupBoxInput_RAA.SuspendLayout();
            this.groupBoxOutput_RAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_RAA
            // 
            this.groupBoxCondition_RAA.Controls.Add(this.pictureBoxFormula_RAA);
            this.groupBoxCondition_RAA.Controls.Add(this.labelCond_RAA);
            this.groupBoxCondition_RAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_RAA.Name = "groupBoxCondition_RAA";
            this.groupBoxCondition_RAA.Size = new System.Drawing.Size(520, 140);
            this.groupBoxCondition_RAA.TabIndex = 0;
            this.groupBoxCondition_RAA.TabStop = false;
            this.groupBoxCondition_RAA.Text = "Условие";
            // 
            // pictureBoxFormula_RAA
            // 
            this.pictureBoxFormula_RAA.Image = Properties.Resources.formula;
            this.pictureBoxFormula_RAA.Location = new System.Drawing.Point(350, 28);
            this.pictureBoxFormula_RAA.Name = "pictureBoxFormula_RAA";
            this.pictureBoxFormula_RAA.Size = new System.Drawing.Size(155, 75);
            this.pictureBoxFormula_RAA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFormula_RAA.TabIndex = 1;
            this.pictureBoxFormula_RAA.TabStop = false;
            // 
            // labelCond_RAA
            // 
            this.labelCond_RAA.AutoSize = true;
            this.labelCond_RAA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCond_RAA.Location = new System.Drawing.Point(14, 28);
            this.labelCond_RAA.Name = "labelCond_RAA";
            this.labelCond_RAA.Size = new System.Drawing.Size(305, 40);
            this.labelCond_RAA.TabIndex = 0;
            this.labelCond_RAA.Text = "Вычислить по формуле.";
            // 
            // groupBoxInput_RAA
            // 
            this.groupBoxInput_RAA.Controls.Add(this.labelX_RAA);
            this.groupBoxInput_RAA.Controls.Add(this.textBoxVarX_RAA);
            this.groupBoxInput_RAA.Location = new System.Drawing.Point(12, 158);
            this.groupBoxInput_RAA.Name = "groupBoxInput_RAA";
            this.groupBoxInput_RAA.Size = new System.Drawing.Size(300, 90);
            this.groupBoxInput_RAA.TabIndex = 1;
            this.groupBoxInput_RAA.TabStop = false;
            this.groupBoxInput_RAA.Text = "Ввод данных";
            // 
            // labelX_RAA
            // 
            this.labelX_RAA.AutoSize = true;
            this.labelX_RAA.Location = new System.Drawing.Point(14, 28);
            this.labelX_RAA.Name = "labelX_RAA";
            this.labelX_RAA.Size = new System.Drawing.Size(98, 16);
            this.labelX_RAA.TabIndex = 0;
            this.labelX_RAA.Text = "Переменная X:";
            // 
            // textBoxVarX_RAA
            // 
            this.textBoxVarX_RAA.Location = new System.Drawing.Point(17, 50);
            this.textBoxVarX_RAA.Name = "textBoxVarX_RAA";
            this.textBoxVarX_RAA.Size = new System.Drawing.Size(120, 22);
            this.textBoxVarX_RAA.TabIndex = 1;
            this.textBoxVarX_RAA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_RAA_KeyPress);
            // 
            // groupBoxOutput_RAA
            // 
            this.groupBoxOutput_RAA.Controls.Add(this.labelResult_RAA);
            this.groupBoxOutput_RAA.Controls.Add(this.textBoxResult_RAA);
            this.groupBoxOutput_RAA.Location = new System.Drawing.Point(318, 158);
            this.groupBoxOutput_RAA.Name = "groupBoxOutput_RAA";
            this.groupBoxOutput_RAA.Size = new System.Drawing.Size(214, 90);
            this.groupBoxOutput_RAA.TabIndex = 2;
            this.groupBoxOutput_RAA.TabStop = false;
            this.groupBoxOutput_RAA.Text = "Вывод данных";
            // 
            // labelResult_RAA
            // 
            this.labelResult_RAA.AutoSize = true;
            this.labelResult_RAA.Location = new System.Drawing.Point(12, 28);
            this.labelResult_RAA.Name = "labelResult_RAA";
            this.labelResult_RAA.Size = new System.Drawing.Size(70, 16);
            this.labelResult_RAA.TabIndex = 0;
            this.labelResult_RAA.Text = "Результат:";
            // 
            // textBoxResult_RAA
            // 
            this.textBoxResult_RAA.Location = new System.Drawing.Point(15, 50);
            this.textBoxResult_RAA.Name = "textBoxResult_RAA";
            this.textBoxResult_RAA.ReadOnly = true;
            this.textBoxResult_RAA.Size = new System.Drawing.Size(180, 22);
            this.textBoxResult_RAA.TabIndex = 1;
            // 
            // buttonHelp_RAA
            // 
            this.buttonHelp_RAA.Location = new System.Drawing.Point(318, 258);
            this.buttonHelp_RAA.Name = "buttonHelp_RAA";
            this.buttonHelp_RAA.Size = new System.Drawing.Size(80, 30);
            this.buttonHelp_RAA.TabIndex = 3;
            this.buttonHelp_RAA.Text = "?";
            this.buttonHelp_RAA.UseVisualStyleBackColor = true;
            this.buttonHelp_RAA.Click += new System.EventHandler(this.buttonHelp_RAA_Click);
            // 
            // buttonCalc_RAA
            // 
            this.buttonCalc_RAA.Location = new System.Drawing.Point(404, 258);
            this.buttonCalc_RAA.Name = "buttonCalc_RAA";
            this.buttonCalc_RAA.Size = new System.Drawing.Size(128, 30);
            this.buttonCalc_RAA.TabIndex = 4;
            this.buttonCalc_RAA.Text = "Вычислить";
            this.buttonCalc_RAA.UseVisualStyleBackColor = true;
            this.buttonCalc_RAA.Click += new System.EventHandler(this.buttonCalc_RAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 302);
            this.Controls.Add(this.buttonCalc_RAA);
            this.Controls.Add(this.buttonHelp_RAA);
            this.Controls.Add(this.groupBoxOutput_RAA);
            this.Controls.Add(this.groupBoxInput_RAA);
            this.Controls.Add(this.groupBoxCondition_RAA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Task 0 | Вариант 4 | Решетова А.А.";
            this.groupBoxCondition_RAA.ResumeLayout(false);
            this.groupBoxCondition_RAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_RAA)).EndInit();
            this.groupBoxInput_RAA.ResumeLayout(false);
            this.groupBoxInput_RAA.PerformLayout();
            this.groupBoxOutput_RAA.ResumeLayout(false);
            this.groupBoxOutput_RAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_RAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_RAA;
        private System.Windows.Forms.Label labelCond_RAA;
        private System.Windows.Forms.GroupBox groupBoxInput_RAA;
        private System.Windows.Forms.Label labelX_RAA;
        private System.Windows.Forms.TextBox textBoxVarX_RAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_RAA;
        private System.Windows.Forms.Label labelResult_RAA;
        private System.Windows.Forms.TextBox textBoxResult_RAA;
        private System.Windows.Forms.Button buttonHelp_RAA;
        private System.Windows.Forms.Button buttonCalc_RAA;
    }
}