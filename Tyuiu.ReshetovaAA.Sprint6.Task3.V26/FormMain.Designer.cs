namespace Tyuiu.ReshetovaAA.Sprint6.Task3.V26
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
            this.labelCondition_RAA = new System.Windows.Forms.Label();
            this.groupBoxMatrix_RAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_RAA = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_RAA = new System.Windows.Forms.GroupBox();
            this.labelResult_RAA = new System.Windows.Forms.Label();
            this.textBoxResult_RAA = new System.Windows.Forms.TextBox();
            this.buttonHelp_RAA = new System.Windows.Forms.Button();
            this.buttonDone_RAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_RAA.SuspendLayout();
            this.groupBoxMatrix_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_RAA)).BeginInit();
            this.groupBoxResult_RAA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCondition_RAA
            // 
            this.groupBoxCondition_RAA.Controls.Add(this.labelCondition_RAA);
            this.groupBoxCondition_RAA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_RAA.Name = "groupBoxCondition_RAA";
            this.groupBoxCondition_RAA.Size = new System.Drawing.Size(360, 140);
            this.groupBoxCondition_RAA.TabIndex = 0;
            this.groupBoxCondition_RAA.TabStop = false;
            this.groupBoxCondition_RAA.Text = "Условие";
            // 
            // labelCondition_RAA
            // 
            this.labelCondition_RAA.AutoSize = true;
            this.labelCondition_RAA.Location = new System.Drawing.Point(10, 25);
            this.labelCondition_RAA.Name = "labelCondition_RAA";
            this.labelCondition_RAA.Size = new System.Drawing.Size(330, 100);
            this.labelCondition_RAA.TabIndex = 0;
            this.labelCondition_RAA.Text = "Вариант 26\r\nДан массив 5 на 5 элементов.\r\nЗаменить четные значения в третьей строке " +
    "на 0.\r\n\r\nРезультат вывести в DataGridView.\r\nГрафический интерфейс оформить по шаблону.";
            // 
            // groupBoxMatrix_RAA
            // 
            this.groupBoxMatrix_RAA.Controls.Add(this.dataGridViewMatrix_RAA);
            this.groupBoxMatrix_RAA.Location = new System.Drawing.Point(390, 12);
            this.groupBoxMatrix_RAA.Name = "groupBoxMatrix_RAA";
            this.groupBoxMatrix_RAA.Size = new System.Drawing.Size(360, 310);
            this.groupBoxMatrix_RAA.TabIndex = 1;
            this.groupBoxMatrix_RAA.TabStop = false;
            this.groupBoxMatrix_RAA.Text = "Матрица";
            // 
            // dataGridViewMatrix_RAA
            // 
            this.dataGridViewMatrix_RAA.AllowUserToAddRows = false;
            this.dataGridViewMatrix_RAA.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix_RAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_RAA.Location = new System.Drawing.Point(10, 25);
            this.dataGridViewMatrix_RAA.Name = "dataGridViewMatrix_RAA";
            this.dataGridViewMatrix_RAA.ReadOnly = true;
            this.dataGridViewMatrix_RAA.RowHeadersVisible = false;
            this.dataGridViewMatrix_RAA.RowTemplate.Height = 29;
            this.dataGridViewMatrix_RAA.Size = new System.Drawing.Size(340, 270);
            this.dataGridViewMatrix_RAA.TabIndex = 0;
            // 
            // groupBoxResult_RAA
            // 
            this.groupBoxResult_RAA.Controls.Add(this.labelResult_RAA);
            this.groupBoxResult_RAA.Controls.Add(this.textBoxResult_RAA);
            this.groupBoxResult_RAA.Location = new System.Drawing.Point(12, 170);
            this.groupBoxResult_RAA.Name = "groupBoxResult_RAA";
            this.groupBoxResult_RAA.Size = new System.Drawing.Size(360, 80);
            this.groupBoxResult_RAA.TabIndex = 2;
            this.groupBoxResult_RAA.TabStop = false;
            this.groupBoxResult_RAA.Text = "Вывод данных";
            // 
            // labelResult_RAA
            // 
            this.labelResult_RAA.AutoSize = true;
            this.labelResult_RAA.Location = new System.Drawing.Point(10, 35);
            this.labelResult_RAA.Name = "labelResult_RAA";
            this.labelResult_RAA.Size = new System.Drawing.Size(78, 20);
            this.labelResult_RAA.TabIndex = 0;
            this.labelResult_RAA.Text = "Результат:";
            // 
            // textBoxResult_RAA
            // 
            this.textBoxResult_RAA.Location = new System.Drawing.Point(100, 32);
            this.textBoxResult_RAA.Name = "textBoxResult_RAA";
            this.textBoxResult_RAA.ReadOnly = true;
            this.textBoxResult_RAA.Size = new System.Drawing.Size(240, 27);
            this.textBoxResult_RAA.TabIndex = 1;
            // 
            // buttonHelp_RAA
            // 
            this.buttonHelp_RAA.Location = new System.Drawing.Point(12, 275);
            this.buttonHelp_RAA.Name = "buttonHelp_RAA";
            this.buttonHelp_RAA.Size = new System.Drawing.Size(60, 40);
            this.buttonHelp_RAA.TabIndex = 3;
            this.buttonHelp_RAA.Text = "?";
            this.buttonHelp_RAA.UseVisualStyleBackColor = true;
            this.buttonHelp_RAA.Click += new System.EventHandler(this.buttonHelp_RAA_Click);
            // 
            // buttonDone_RAA
            // 
            this.buttonDone_RAA.Location = new System.Drawing.Point(220, 275);
            this.buttonDone_RAA.Name = "buttonDone_RAA";
            this.buttonDone_RAA.Size = new System.Drawing.Size(152, 40);
            this.buttonDone_RAA.TabIndex = 4;
            this.buttonDone_RAA.Text = "Выполнить";
            this.buttonDone_RAA.UseVisualStyleBackColor = true;
            this.buttonDone_RAA.Click += new System.EventHandler(this.buttonDone_RAA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 336);
            this.Controls.Add(this.buttonDone_RAA);
            this.Controls.Add(this.buttonHelp_RAA);
            this.Controls.Add(this.groupBoxResult_RAA);
            this.Controls.Add(this.groupBoxMatrix_RAA);
            this.Controls.Add(this.groupBoxCondition_RAA);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Task 3 | Вариант 26 | Решетова А.А.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxCondition_RAA.ResumeLayout(false);
            this.groupBoxCondition_RAA.PerformLayout();
            this.groupBoxMatrix_RAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_RAA)).EndInit();
            this.groupBoxResult_RAA.ResumeLayout(false);
            this.groupBoxResult_RAA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCondition_RAA;
        private System.Windows.Forms.Label labelCondition_RAA;
        private System.Windows.Forms.GroupBox groupBoxMatrix_RAA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_RAA;
        private System.Windows.Forms.GroupBox groupBoxResult_RAA;
        private System.Windows.Forms.Label labelResult_RAA;
        private System.Windows.Forms.TextBox textBoxResult_RAA;
        private System.Windows.Forms.Button buttonHelp_RAA;
        private System.Windows.Forms.Button buttonDone_RAA;
    }
}