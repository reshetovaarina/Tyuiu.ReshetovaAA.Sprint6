namespace Tyuiu.ReshetovaAA.Sprint6.Task5.V1
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox groupBoxTask;
        private System.Windows.Forms.Label labelTask;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.TextBox textBoxPath;

        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonHelp;

        private System.Windows.Forms.DataGridView dataGridViewNums;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;

        private System.Windows.Forms.Label labelRAA;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.groupBoxTask = new System.Windows.Forms.GroupBox();
            this.labelTask = new System.Windows.Forms.Label();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();

            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();

            this.dataGridViewNums = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnValue = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelRAA = new System.Windows.Forms.Label();

            this.groupBoxTask.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag)).BeginInit();
            this.SuspendLayout();

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Name = "FormMain";
            this.Text = "Sprint 6 | Task 5 | Variant 1 | Reshetova A.A. (RAA)";

            // groupBoxTask
            this.groupBoxTask.Controls.Add(this.labelTask);
            this.groupBoxTask.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask.Name = "groupBoxTask";
            this.groupBoxTask.Size = new System.Drawing.Size(720, 90);
            this.groupBoxTask.TabIndex = 0;
            this.groupBoxTask.TabStop = false;
            this.groupBoxTask.Text = "Условие";

            // labelTask
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(10, 22);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(695, 60);
            this.labelTask.TabIndex = 0;
            this.labelTask.Text =
                "Прочитать данные из файла InPutFileTask5V1.txt.\r\n" + "Вывести в DataGridView все положительные числа.\r\n" +
                "Построить диаграмму по этим значениям.\r\n" +
                "Вещественные значения округлить до трёх знаков после запятой.";

            // groupBoxPath
            this.groupBoxPath.Controls.Add(this.textBoxPath);
            this.groupBoxPath.Location = new System.Drawing.Point(12, 108);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(720, 55);
            this.groupBoxPath.TabIndex = 1;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Путь к файлу";

            // textBoxPath
            this.textBoxPath.Location = new System.Drawing.Point(10, 22);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ReadOnly = true;
            this.textBoxPath.Size = new System.Drawing.Size(700, 23);
            this.textBoxPath.TabIndex = 0;

            // labelRAA (символы RAA как в прошлый раз)
            this.labelRAA.AutoSize = true;
            this.labelRAA.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelRAA.Location = new System.Drawing.Point(1000, 20);
            this.labelRAA.Name = "labelRAA";
            this.labelRAA.Size = new System.Drawing.Size(72, 32);
            this.labelRAA.TabIndex = 99;
            this.labelRAA.Text = "RAA";

            // buttonDone (зелёная)
            this.buttonDone.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonDone.ForeColor = System.Drawing.Color.White;
            this.buttonDone.Location = new System.Drawing.Point(750, 20);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(120, 45);
            this.buttonDone.TabIndex = 2;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);

            // buttonSave (синяя)
            this.buttonSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(880, 20);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(120, 45);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);

            // buttonOpen (синяя)
            this.buttonOpen.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonOpen.ForeColor = System.Drawing.Color.White;
            this.buttonOpen.Location = new System.Drawing.Point(750, 75);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(120, 45);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = false;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);

            // buttonHelp (серая)
            this.buttonHelp.BackColor = System.Drawing.Color.DimGray;
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(880, 75);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(120, 45);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);

            // dataGridViewNums
            this.dataGridViewNums.AllowUserToAddRows = false;
            this.dataGridViewNums.AllowUserToDeleteRows = false;
            this.dataGridViewNums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.ColumnValue});
            this.dataGridViewNums.Location = new System.Drawing.Point(12, 180);
            this.dataGridViewNums.Name = "dataGridViewNums";
            this.dataGridViewNums.ReadOnly = true;
            this.dataGridViewNums.RowHeadersVisible = false;
            this.dataGridViewNums.Size = new System.Drawing.Size(300, 450);
            this.dataGridViewNums.TabIndex = 6;

            // ColumnIndex
            this.ColumnIndex.HeaderText = "i";
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.ReadOnly = true;
            this.ColumnIndex.Width = 60;

            // ColumnValue
            this.ColumnValue.HeaderText = "Value";
            this.ColumnValue.Name = "ColumnValue";
            this.ColumnValue.ReadOnly = true;
            this.ColumnValue.Width = 200;

            // chartDiag
            chartArea1.AxisX.Title = "Ось X";
            chartArea1.AxisY.Title = "Ось Y";
            chartArea1.Name = "ChartArea1";
            this.chartDiag.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDiag.Legends.Add(legend1);
            this.chartDiag.Location = new System.Drawing.Point(330, 180);
            this.chartDiag.Name = "chartDiag";
            this.chartDiag.Size = new System.Drawing.Size(758, 450);
            this.chartDiag.TabIndex = 7;

            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            this.chartDiag.Series.Add(series1);

            // add controls
            this.Controls.Add(this.groupBoxTask);
            this.Controls.Add(this.groupBoxPath);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.dataGridViewNums);
            this.Controls.Add(this.chartDiag);
            this.Controls.Add(this.labelRAA);

            this.groupBoxTask.ResumeLayout(false);
            this.groupBoxTask.PerformLayout();
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}