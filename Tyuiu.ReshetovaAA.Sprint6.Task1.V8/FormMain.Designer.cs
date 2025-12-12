namespace Tyuiu.ReshetovaAA.Sprint6.Task1.V8
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
            groupBoxCondition_RAA = new GroupBox();
            pictureBoxFormula_RAA = new PictureBox();
            labelCondition_RAA = new Label();
            groupBoxInput_RAA = new GroupBox();
            labelStop_RAA = new Label();
            labelStart_RAA = new Label();
            textBoxStop_RAA = new TextBox();
            textBoxStart_RAA = new TextBox();
            groupBoxOutput_RAA = new GroupBox();
            labelResult_RAA = new Label();
            textBoxResult_RAA = new TextBox();
            buttonHelp_RAA = new Button();
            buttonCalc_RAA = new Button();
            groupBoxCondition_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_RAA).BeginInit();
            groupBoxInput_RAA.SuspendLayout();
            groupBoxOutput_RAA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxCondition_RAA
            // 
            groupBoxCondition_RAA.Controls.Add(pictureBoxFormula_RAA);
            groupBoxCondition_RAA.Controls.Add(labelCondition_RAA);
            groupBoxCondition_RAA.Location = new Point(12, 15);
            groupBoxCondition_RAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxCondition_RAA.Name = "groupBoxCondition_RAA";
            groupBoxCondition_RAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxCondition_RAA.Size = new Size(540, 225);
            groupBoxCondition_RAA.TabIndex = 0;
            groupBoxCondition_RAA.TabStop = false;
            groupBoxCondition_RAA.Text = "Условие";
            // 
            // pictureBoxFormula_RAA
            // 
            pictureBoxFormula_RAA.Image = Properties.Resources.formula;
            pictureBoxFormula_RAA.Location = new Point(220, 95);
            pictureBoxFormula_RAA.Margin = new Padding(3, 4, 3, 4);
            pictureBoxFormula_RAA.Name = "pictureBoxFormula_RAA";
            pictureBoxFormula_RAA.Size = new Size(327, 132);
            pictureBoxFormula_RAA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFormula_RAA.TabIndex = 1;
            pictureBoxFormula_RAA.TabStop = false;
            // 
            // labelCondition_RAA
            // 
            labelCondition_RAA.AutoSize = true;
            labelCondition_RAA.Location = new Point(12, 38);
            labelCondition_RAA.Name = "labelCondition_RAA";
            labelCondition_RAA.Size = new Size(404, 60);
            labelCondition_RAA.TabIndex = 0;
            labelCondition_RAA.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в виде таблицы.\r\nЗначения округлить до двух знаков.";
            // 
            // groupBoxInput_RAA
            // 
            groupBoxInput_RAA.Controls.Add(labelStop_RAA);
            groupBoxInput_RAA.Controls.Add(labelStart_RAA);
            groupBoxInput_RAA.Controls.Add(textBoxStop_RAA);
            groupBoxInput_RAA.Controls.Add(textBoxStart_RAA);
            groupBoxInput_RAA.Location = new Point(12, 250);
            groupBoxInput_RAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxInput_RAA.Name = "groupBoxInput_RAA";
            groupBoxInput_RAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxInput_RAA.Size = new Size(540, 119);
            groupBoxInput_RAA.TabIndex = 1;
            groupBoxInput_RAA.TabStop = false;
            groupBoxInput_RAA.Text = "Ввод данных";
            // 
            // labelStop_RAA
            // 
            labelStop_RAA.AutoSize = true;
            labelStop_RAA.Location = new Point(270, 38);
            labelStop_RAA.Name = "labelStop_RAA";
            labelStop_RAA.Size = new Size(94, 20);
            labelStop_RAA.TabIndex = 1;
            labelStop_RAA.Text = "Конец шага:";
            // 
            // labelStart_RAA
            // 
            labelStart_RAA.AutoSize = true;
            labelStart_RAA.Location = new Point(12, 38);
            labelStart_RAA.Name = "labelStart_RAA";
            labelStart_RAA.Size = new Size(88, 20);
            labelStart_RAA.TabIndex = 0;
            labelStart_RAA.Text = "Старт шага:";
            // 
            // textBoxStop_RAA
            // 
            textBoxStop_RAA.Location = new Point(270, 69);
            textBoxStop_RAA.Margin = new Padding(3, 4, 3, 4);
            textBoxStop_RAA.Name = "textBoxStop_RAA";
            textBoxStop_RAA.Size = new Size(220, 27);
            textBoxStop_RAA.TabIndex = 3;
            textBoxStop_RAA.KeyPress += textBoxStop_RAA_KeyPress;
            // 
            // textBoxStart_RAA
            // 
            textBoxStart_RAA.Location = new Point(12, 69);
            textBoxStart_RAA.Margin = new Padding(3, 4, 3, 4);
            textBoxStart_RAA.Name = "textBoxStart_RAA";
            textBoxStart_RAA.Size = new Size(220, 27);
            textBoxStart_RAA.TabIndex = 2;
            textBoxStart_RAA.KeyPress += textBoxStart_RAA_KeyPress;
            // 
            // groupBoxOutput_RAA
            // 
            groupBoxOutput_RAA.Controls.Add(labelResult_RAA);
            groupBoxOutput_RAA.Controls.Add(textBoxResult_RAA);
            groupBoxOutput_RAA.Location = new Point(565, 15);
            groupBoxOutput_RAA.Margin = new Padding(3, 4, 3, 4);
            groupBoxOutput_RAA.Name = "groupBoxOutput_RAA";
            groupBoxOutput_RAA.Padding = new Padding(3, 4, 3, 4);
            groupBoxOutput_RAA.Size = new Size(250, 354);
            groupBoxOutput_RAA.TabIndex = 2;
            groupBoxOutput_RAA.TabStop = false;
            groupBoxOutput_RAA.Text = "Вывод данных";
            // 
            // labelResult_RAA
            // 
            labelResult_RAA.AutoSize = true;
            labelResult_RAA.Location = new Point(12, 38);
            labelResult_RAA.Name = "labelResult_RAA";
            labelResult_RAA.Size = new Size(78, 20);
            labelResult_RAA.TabIndex = 0;
            labelResult_RAA.Text = "Результат:";
            // 
            // textBoxResult_RAA
            // 
            textBoxResult_RAA.Location = new Point(12, 69);
            textBoxResult_RAA.Margin = new Padding(3, 4, 3, 4);
            textBoxResult_RAA.Multiline = true;
            textBoxResult_RAA.Name = "textBoxResult_RAA";
            textBoxResult_RAA.ReadOnly = true;
            textBoxResult_RAA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_RAA.Size = new Size(225, 262);
            textBoxResult_RAA.TabIndex = 1;
            // 
            // buttonHelp_RAA
            // 
            buttonHelp_RAA.BackColor = Color.DodgerBlue;
            buttonHelp_RAA.FlatStyle = FlatStyle.Flat;
            buttonHelp_RAA.ForeColor = Color.White;
            buttonHelp_RAA.Location = new Point(365, 381);
            buttonHelp_RAA.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_RAA.Name = "buttonHelp_RAA";
            buttonHelp_RAA.Size = new Size(120, 50);
            buttonHelp_RAA.TabIndex = 3;
            buttonHelp_RAA.Text = "Справка";
            buttonHelp_RAA.UseVisualStyleBackColor = false;
            buttonHelp_RAA.Click += buttonHelp_RAA_Click;
            // 
            // buttonCalc_RAA
            // 
            buttonCalc_RAA.BackColor = Color.LightGreen;
            buttonCalc_RAA.FlatStyle = FlatStyle.Flat;
            buttonCalc_RAA.Location = new Point(505, 381);
            buttonCalc_RAA.Margin = new Padding(3, 4, 3, 4);
            buttonCalc_RAA.Name = "buttonCalc_RAA";
            buttonCalc_RAA.Size = new Size(120, 50);
            buttonCalc_RAA.TabIndex = 4;
            buttonCalc_RAA.Text = "Выполнить";
            buttonCalc_RAA.UseVisualStyleBackColor = false;
            buttonCalc_RAA.Click += buttonCalc_RAA_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 450);
            Controls.Add(buttonCalc_RAA);
            Controls.Add(buttonHelp_RAA);
            Controls.Add(groupBoxOutput_RAA);
            Controls.Add(groupBoxInput_RAA);
            Controls.Add(groupBoxCondition_RAA);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 8 | Решетова А.А.";
            groupBoxCondition_RAA.ResumeLayout(false);
            groupBoxCondition_RAA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_RAA).EndInit();
            groupBoxInput_RAA.ResumeLayout(false);
            groupBoxInput_RAA.PerformLayout();
            groupBoxOutput_RAA.ResumeLayout(false);
            groupBoxOutput_RAA.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_RAA;
        private System.Windows.Forms.Label labelCondition_RAA;
        private System.Windows.Forms.PictureBox pictureBoxFormula_RAA;
        private System.Windows.Forms.GroupBox groupBoxInput_RAA;
        private System.Windows.Forms.Label labelStop_RAA;
        private System.Windows.Forms.Label labelStart_RAA;
        private System.Windows.Forms.TextBox textBoxStop_RAA;
        private System.Windows.Forms.TextBox textBoxStart_RAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_RAA;
        private System.Windows.Forms.Label labelResult_RAA;
        private System.Windows.Forms.TextBox textBoxResult_RAA;
        private System.Windows.Forms.Button buttonHelp_RAA;
        private System.Windows.Forms.Button buttonCalc_RAA;
    }
}