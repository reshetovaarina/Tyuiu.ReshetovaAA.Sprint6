namespace Tyuiu.ReshetovaAA.Sprint6.Task2.V7
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxCondition_RAA;
        private System.Windows.Forms.GroupBox groupBoxInput_RAA;
        private System.Windows.Forms.GroupBox groupBoxOutput_RAA;

        private System.Windows.Forms.Label labelCondition_RAA;
        private System.Windows.Forms.Label labelStart_RAA;
        private System.Windows.Forms.Label labelStop_RAA;

        private System.Windows.Forms.TextBox textBoxStartStep_RAA;
        private System.Windows.Forms.TextBox textBoxStopStep_RAA;

        private System.Windows.Forms.Button buttonHelp_RAA;
        private System.Windows.Forms.Button buttonDone_RAA;

        private System.Windows.Forms.DataGridView dataGridViewFunction_RAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX_RAA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnF_RAA;

        private System.Windows.Forms.Panel panelChart_RAA;

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
            this.labelCondition_RAA = new System.Windows.Forms.Label();

            this.groupBoxInput_RAA = new System.Windows.Forms.GroupBox();
            this.labelStart_RAA = new System.Windows.Forms.Label();
            this.labelStop_RAA = new System.Windows.Forms.Label();
            this.textBoxStartStep_RAA = new System.Windows.Forms.TextBox();
            this.textBoxStopStep_RAA = new System.Windows.Forms.TextBox();

            this.buttonHelp_RAA = new System.Windows.Forms.Button();
            this.buttonDone_RAA = new System.Windows.Forms.Button();

            this.groupBoxOutput_RAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_RAA = new System.Windows.Forms.DataGridView();
            this.ColumnX_RAA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnF_RAA = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.panelChart_RAA = new System.Windows.Forms.Panel();

            this.groupBoxCondition_RAA.SuspendLayout();
            this.groupBoxInput_RAA.SuspendLayout();
            this.groupBoxOutput_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_RAA)).BeginInit();
            this.SuspendLayout();

            // groupBoxCondition_RAA
            this.groupBoxCondition_RAA.Controls.Add(this.labelCondition_RAA);
            this.groupBoxCondition_RAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_RAA.Name = "groupBoxCondition_RAA";
            this.groupBoxCondition_RAA.Size = new System.Drawing.Size(520, 140);
            this.groupBoxCondition_RAA.TabIndex = 0;
            this.groupBoxCondition_RAA.TabStop = false;
            this.groupBoxCondition_RAA.Text = "Условие";

            // labelCondition_RAA
            this.labelCondition_RAA.AutoSize = true;
            this.labelCondition_RAA.Location = new System.Drawing.Point(10, 28);
            this.labelCondition_RAA.Name = "labelCondition_RAA";
            this.labelCondition_RAA.Size = new System.Drawing.Size(500, 80);
            this.labelCondition_RAA.TabIndex = 0;
            this.labelCondition_RAA.Text =
                "Вариант 7\r\n" +
                "Протабулировать функцию F(x) на диапазоне [-5; 5] с шагом 1.\r\n" +
                "Произвести проверку деления на 0. При делении на 0 вернуть 0.\r\n" +
                "Значения округлить до 2 знаков и вывести в DataGridView + график.";

            // groupBoxInput_RAA
            this.groupBoxInput_RAA.Controls.Add(this.labelStart_RAA);
            this.groupBoxInput_RAA.Controls.Add(this.textBoxStartStep_RAA);
            this.groupBoxInput_RAA.Controls.Add(this.labelStop_RAA);
            this.groupBoxInput_RAA.Controls.Add(this.textBoxStopStep_RAA);
            this.groupBoxInput_RAA.Location = new System.Drawing.Point(12, 160);
            this.groupBoxInput_RAA.Name = "groupBoxInput_RAA";
            this.groupBoxInput_RAA.Size = new System.Drawing.Size(300, 90);
            this.groupBoxInput_RAA.TabIndex = 1;
            this.groupBoxInput_RAA.TabStop = false;
            this.groupBoxInput_RAA.Text = "Ввод данных";

            // labelStart_RAA
            this.labelStart_RAA.AutoSize = true;
            this.labelStart_RAA.Location = new System.Drawing.Point(10, 35);
            this.labelStart_RAA.Name = "labelStart_RAA";
            this.labelStart_RAA.Size = new System.Drawing.Size(84, 20);
            this.labelStart_RAA.TabIndex = 0;
            this.labelStart_RAA.Text = "Старт шага:";

            // textBoxStartStep_RAA
            this.textBoxStartStep_RAA.Location = new System.Drawing.Point(100, 32);
            this.textBoxStartStep_RAA.Name = "textBoxStartStep_RAA";
            this.textBoxStartStep_RAA.Size = new System.Drawing.Size(60, 27);
            this.textBoxStartStep_RAA.TabIndex = 1;
            this.textBoxStartStep_RAA.Text = "-5";

            // labelStop_RAA
            this.labelStop_RAA.AutoSize = true;
            this.labelStop_RAA.Location = new System.Drawing.Point(170, 35);
            this.labelStop_RAA.Name = "labelStop_RAA";
            this.labelStop_RAA.Size = new System.Drawing.Size(86, 20);
            this.labelStop_RAA.TabIndex = 2;
            this.labelStop_RAA.Text = "Конец шага:";

            // textBoxStopStep_RAA
            this.textBoxStopStep_RAA.Location = new System.Drawing.Point(260, 32);
            this.textBoxStopStep_RAA.Name = "textBoxStopStep_RAA";
            this.textBoxStopStep_RAA.Size = new System.Drawing.Size(60, 27);
            this.textBoxStopStep_RAA.TabIndex = 3;
            this.textBoxStopStep_RAA.Text = "5";

            // buttonHelp_RAA
            this.buttonHelp_RAA.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.buttonHelp_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_RAA.Location = new System.Drawing.Point(330, 170);
            this.buttonHelp_RAA.Name = "buttonHelp_RAA";
            this.buttonHelp_RAA.Size = new System.Drawing.Size(120, 50);
            this.buttonHelp_RAA.TabIndex = 2;
            this.buttonHelp_RAA.Text = "Справка";
            this.buttonHelp_RAA.UseVisualStyleBackColor = false;
            this.buttonHelp_RAA.Click += new System.EventHandler(this.buttonHelp_RAA_Click);

            // buttonDone_RAA
            this.buttonDone_RAA.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDone_RAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_RAA.Location = new System.Drawing.Point(460, 170);
            this.buttonDone_RAA.Name = "buttonDone_RAA";
            this.buttonDone_RAA.Size = new System.Drawing.Size(120, 50);
            this.buttonDone_RAA.TabIndex = 3;
            this.buttonDone_RAA.Text = "Выполнить";
            this.buttonDone_RAA.UseVisualStyleBackColor = false;
            this.buttonDone_RAA.Click += new System.EventHandler(this.buttonDone_RAA_Click);
            this.buttonDone_RAA.MouseEnter += new System.EventHandler(this.buttonDone_RAA_MouseEnter);
            this.buttonDone_RAA.MouseLeave += new System.EventHandler(this.buttonDone_RAA_MouseLeave);
            this.buttonDone_RAA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_RAA_MouseDown);

            // groupBoxOutput_RAA
            this.groupBoxOutput_RAA.Controls.Add(this.dataGridViewFunction_RAA);
            this.groupBoxOutput_RAA.Location = new System.Drawing.Point(540, 12);
            this.groupBoxOutput_RAA.Name = "groupBoxOutput_RAA";
            this.groupBoxOutput_RAA.Size = new System.Drawing.Size(220, 238);
            this.groupBoxOutput_RAA.TabIndex = 4;
            this.groupBoxOutput_RAA.TabStop = false;
            this.groupBoxOutput_RAA.Text = "Таблица";

            // dataGridViewFunction_RAA
            this.dataGridViewFunction_RAA.AllowUserToAddRows = false;
            this.dataGridViewFunction_RAA.AllowUserToDeleteRows = false;
            this.dataGridViewFunction_RAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_RAA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.ColumnX_RAA,
                this.ColumnF_RAA
            });
            this.dataGridViewFunction_RAA.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewFunction_RAA.Name = "dataGridViewFunction_RAA";
            this.dataGridViewFunction_RAA.ReadOnly = true;
            this.dataGridViewFunction_RAA.RowHeadersVisible = false;
            this.dataGridViewFunction_RAA.Size = new System.Drawing.Size(200, 200);
            this.dataGridViewFunction_RAA.TabIndex = 0;

            // ColumnX_RAA
            this.ColumnX_RAA.HeaderText = "X";
            this.ColumnX_RAA.Name = "ColumnX_RAA";
            this.ColumnX_RAA.ReadOnly = true;
            this.ColumnX_RAA.Width = 60;

            // ColumnF_RAA
            this.ColumnF_RAA.HeaderText = "F(x)";
            this.ColumnF_RAA.Name = "ColumnF_RAA";
            this.ColumnF_RAA.ReadOnly = true;
            this.ColumnF_RAA.Width = 120;

            // panelChart_RAA
            this.panelChart_RAA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChart_RAA.Location = new System.Drawing.Point(12, 260);
            this.panelChart_RAA.Name = "panelChart_RAA";
            this.panelChart_RAA.Size = new System.Drawing.Size(748, 250);
            this.panelChart_RAA.TabIndex = 5;

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 525);

            this.Controls.Add(this.panelChart_RAA);
            this.Controls.Add(this.groupBoxOutput_RAA);
            this.Controls.Add(this.buttonDone_RAA);
            this.Controls.Add(this.buttonHelp_RAA);
            this.Controls.Add(this.groupBoxInput_RAA);
            this.Controls.Add(this.groupBoxCondition_RAA);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 7 | Решетова А.А.";

            this.groupBoxCondition_RAA.ResumeLayout(false);
            this.groupBoxCondition_RAA.PerformLayout();
            this.groupBoxInput_RAA.ResumeLayout(false);
            this.groupBoxInput_RAA.PerformLayout();
            this.groupBoxOutput_RAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_RAA)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}