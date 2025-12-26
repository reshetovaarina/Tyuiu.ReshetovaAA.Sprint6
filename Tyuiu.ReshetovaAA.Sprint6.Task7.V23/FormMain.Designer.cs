using System.Windows.Forms;

namespace Tyuiu.ReshetovaAA.Sprint6.Task7.V23
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
            this.panelTop_RAA = new System.Windows.Forms.Panel();
            this.buttonHelp_RAA = new System.Windows.Forms.Button();
            this.buttonSaveFile_RAA = new System.Windows.Forms.Button();
            this.buttonDone_RAA = new System.Windows.Forms.Button();
            this.buttonOpen_RAA = new System.Windows.Forms.Button();
            this.groupBoxCondition_RAA = new System.Windows.Forms.GroupBox();
            this.textBoxCondition_RAA = new System.Windows.Forms.TextBox();
            this.groupBoxIn_RAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewInMatrix_RAA = new System.Windows.Forms.DataGridView();
            this.groupBoxOut_RAA = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutMatrix_RAA = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.toolTipButton_RAA = new System.Windows.Forms.ToolTip(this.components);
            this.panelTop_RAA.SuspendLayout();
            this.groupBoxCondition_RAA.SuspendLayout();
            this.groupBoxIn_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_RAA)).BeginInit();
            this.groupBoxOut_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_RAA)).BeginInit();
            this.SuspendLayout();

            // panelTop_RAA

            this.panelTop_RAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop_RAA.Controls.Add(this.buttonHelp_RAA);
            this.panelTop_RAA.Controls.Add(this.buttonSaveFile_RAA);
            this.panelTop_RAA.Controls.Add(this.buttonDone_RAA);
            this.panelTop_RAA.Controls.Add(this.buttonOpen_RAA);
            this.panelTop_RAA.Location = new System.Drawing.Point(12, 12);
            this.panelTop_RAA.Name = "panelTop_RAA";
            this.panelTop_RAA.Size = new System.Drawing.Size(1160, 56);
            this.panelTop_RAA.TabIndex = 0;

            // buttonHelp_RAA

            this.buttonHelp_RAA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_RAA.Image = Properties.Resources.icon_info;  
            this.buttonHelp_RAA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHelp_RAA.Location = new System.Drawing.Point(1040, 8);
            this.buttonHelp_RAA.Name = "buttonHelp_RAA";
            this.buttonHelp_RAA.Size = new System.Drawing.Size(110, 40);
            this.buttonHelp_RAA.TabIndex = 3;
            this.buttonHelp_RAA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipButton_RAA.SetToolTip(this.buttonHelp_RAA, "Информация о программе");
            this.buttonHelp_RAA.UseVisualStyleBackColor = true;
            this.buttonHelp_RAA.Click += new System.EventHandler(this.buttonHelp_RAA_Click);

            // buttonSaveFile_RAA

            this.buttonSaveFile_RAA.Image = Properties.Resources.icon_save;  
            this.buttonSaveFile_RAA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveFile_RAA.Location = new System.Drawing.Point(196, 8);
            this.buttonSaveFile_RAA.Name = "buttonSaveFile_RAA";
            this.buttonSaveFile_RAA.Size = new System.Drawing.Size(110, 40);
            this.buttonSaveFile_RAA.TabIndex = 2;
            this.buttonSaveFile_RAA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipButton_RAA.SetToolTip(this.buttonSaveFile_RAA, "Сохранить результат в CSV");
            this.buttonSaveFile_RAA.UseVisualStyleBackColor = true;
            this.buttonSaveFile_RAA.Click += new System.EventHandler(this.buttonSaveFile_RAA_Click);

            // buttonDone_RAA

            this.buttonDone_RAA.Image = Properties.Resources.icon_add;   
            this.buttonDone_RAA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDone_RAA.Location = new System.Drawing.Point(102, 8);
            this.buttonDone_RAA.Name = "buttonDone_RAA";
            this.buttonDone_RAA.Size = new System.Drawing.Size(88, 40);
            this.buttonDone_RAA.TabIndex = 1;
            this.buttonDone_RAA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipButton_RAA.SetToolTip(this.buttonDone_RAA, "Изменить последний столбец");
            this.buttonDone_RAA.UseVisualStyleBackColor = true;
            this.buttonDone_RAA.Click += new System.EventHandler(this.buttonDone_RAA_Click);

            // buttonOpen_RAA

            this.buttonOpen_RAA.Image = Properties.Resources.icon_load; 
            this.buttonOpen_RAA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpen_RAA.Location = new System.Drawing.Point(8, 8);
            this.buttonOpen_RAA.Name = "buttonOpen_RAA";
            this.buttonOpen_RAA.Size = new System.Drawing.Size(88, 40);
            this.buttonOpen_RAA.TabIndex = 0;
            this.buttonOpen_RAA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTipButton_RAA.SetToolTip(this.buttonOpen_RAA, "Открыть входной CSV");
            this.buttonOpen_RAA.UseVisualStyleBackColor = true;
            this.buttonOpen_RAA.Click += new System.EventHandler(this.buttonOpen_RAA_Click);

            // groupBoxCondition_RAA

            this.groupBoxCondition_RAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCondition_RAA.Controls.Add(this.textBoxCondition_RAA);
            this.groupBoxCondition_RAA.Location = new System.Drawing.Point(12, 74);
            this.groupBoxCondition_RAA.Name = "groupBoxCondition_RAA";
            this.groupBoxCondition_RAA.Size = new System.Drawing.Size(1160, 82);
            this.groupBoxCondition_RAA.TabIndex = 1;
            this.groupBoxCondition_RAA.TabStop = false;
            this.groupBoxCondition_RAA.Text = "Условие:";

            // textBoxCondition_RAA

            this.textBoxCondition_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCondition_RAA.Location = new System.Drawing.Point(3, 19);
            this.textBoxCondition_RAA.Multiline = true;
            this.textBoxCondition_RAA.Name = "textBoxCondition_RAA";
            this.textBoxCondition_RAA.ReadOnly = true;
            this.textBoxCondition_RAA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCondition_RAA.Size = new System.Drawing.Size(1154, 60);
            this.textBoxCondition_RAA.TabIndex = 0;
            this.textBoxCondition_RAA.Text = "Дан файл InPutFileTask7V23.csv, в котором хранится матрица целочисленных значений. Загрузить файл через openFileDialog в объект dataGridViewIn. Изменить в последнем столбце значения меньше 2 на 2. Результат вывести в объект dataGridViewOut. Сохранить результат в файл OutPutFileTask7V23.csv через saveFileDialog.";

            // groupBoxIn_RAA

            this.groupBoxIn_RAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxIn_RAA.Controls.Add(this.dataGridViewInMatrix_RAA);
            this.groupBoxIn_RAA.Location = new System.Drawing.Point(12, 162);
            this.groupBoxIn_RAA.Name = "groupBoxIn_RAA";
            this.groupBoxIn_RAA.Size = new System.Drawing.Size(570, 387);
            this.groupBoxIn_RAA.TabIndex = 2;
            this.groupBoxIn_RAA.TabStop = false;
            this.groupBoxIn_RAA.Text = "Ввод:";

            // dataGridViewInMatrix_RAA

            this.dataGridViewInMatrix_RAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInMatrix_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInMatrix_RAA.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewInMatrix_RAA.Name = "dataGridViewInMatrix_RAA";
            this.dataGridViewInMatrix_RAA.RowHeadersVisible = false;
            this.dataGridViewInMatrix_RAA.RowTemplate.Height = 24;
            this.dataGridViewInMatrix_RAA.Size = new System.Drawing.Size(564, 365);
            this.dataGridViewInMatrix_RAA.TabIndex = 0;

            // groupBoxOut_RAA

            this.groupBoxOut_RAA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOut_RAA.Controls.Add(this.dataGridViewOutMatrix_RAA);
            this.groupBoxOut_RAA.Location = new System.Drawing.Point(602, 162);
            this.groupBoxOut_RAA.Name = "groupBoxOut_RAA";
            this.groupBoxOut_RAA.Size = new System.Drawing.Size(570, 387);
            this.groupBoxOut_RAA.TabIndex = 3;
            this.groupBoxOut_RAA.TabStop = false;
            this.groupBoxOut_RAA.Text = "Вывод:";

            // dataGridViewOutMatrix_RAA

            this.dataGridViewOutMatrix_RAA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutMatrix_RAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutMatrix_RAA.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewOutMatrix_RAA.Name = "dataGridViewOutMatrix_RAA";
            this.dataGridViewOutMatrix_RAA.RowHeadersVisible = false;
            this.dataGridViewOutMatrix_RAA.RowTemplate.Height = 24;
            this.dataGridViewOutMatrix_RAA.Size = new System.Drawing.Size(564, 365);
            this.dataGridViewOutMatrix_RAA.TabIndex = 0;

            // openFileDialogTask

            this.openFileDialogTask.FileName = "openFileDialogTask";
            this.openFileDialogTask.Filter = "CSV файлы|*.csv|Все файлы|*.*";

            // saveFileDialogMatrix

            this.saveFileDialogMatrix.Filter = "CSV файлы|*.csv|Все файлы|*.*";

            // FormMain

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.groupBoxOut_RAA);
            this.Controls.Add(this.groupBoxIn_RAA);
            this.Controls.Add(this.groupBoxCondition_RAA);
            this.Controls.Add(this.panelTop_RAA);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 23 | Решетова А.А.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop_RAA.ResumeLayout(false);
            this.groupBoxCondition_RAA.ResumeLayout(false);
            this.groupBoxCondition_RAA.PerformLayout();
            this.groupBoxIn_RAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInMatrix_RAA)).EndInit();
            this.groupBoxOut_RAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutMatrix_RAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_RAA;
        private System.Windows.Forms.Button buttonHelp_RAA;
        private System.Windows.Forms.Button buttonSaveFile_RAA;
        private System.Windows.Forms.Button buttonDone_RAA;
        private System.Windows.Forms.Button buttonOpen_RAA;
        private System.Windows.Forms.GroupBox groupBoxCondition_RAA;
        private System.Windows.Forms.TextBox textBoxCondition_RAA;
        private System.Windows.Forms.GroupBox groupBoxIn_RAA;
        private System.Windows.Forms.DataGridView dataGridViewInMatrix_RAA;
        private System.Windows.Forms.GroupBox groupBoxOut_RAA;
        private System.Windows.Forms.DataGridView dataGridViewOutMatrix_RAA;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
        private System.Windows.Forms.ToolTip toolTipButton_RAA;
    }
}
