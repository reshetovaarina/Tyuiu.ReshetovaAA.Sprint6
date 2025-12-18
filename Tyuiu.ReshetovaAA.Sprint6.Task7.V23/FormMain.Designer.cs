using System.Windows.Forms;

namespace Tyuiu.ReshetovaAA.Sprint6.Task7.V23
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(FormMain));

            toolStripTop_RAA = new ToolStrip();
            buttonOpenFile_RAA = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            buttonDone_RAA = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            buttonSaveFile_RAA = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparatorRight = new ToolStripSeparator();
            buttonHelp_RAA = new ToolStripButton();

            labelTask_RAA = new Label();
            textBoxTask_RAA = new TextBox();
            labelIn_RAA = new Label();
            labelOut_RAA = new Label();

            splitContainerMain_RAA = new SplitContainer();
            dataGridViewInMatrix_RAA = new DataGridView();
            dataGridViewOutMatrix_RAA = new DataGridView();

            openFileDialogTask = new OpenFileDialog();
            saveFileDialogMatrix = new SaveFileDialog();
            toolTipButton_RAA = new ToolTip(components);

            toolStripTop_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain_RAA).BeginInit();
            splitContainerMain_RAA.Panel1.SuspendLayout();
            splitContainerMain_RAA.Panel2.SuspendLayout();
            splitContainerMain_RAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_RAA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_RAA).BeginInit();
            SuspendLayout();

            // 
            // toolStripTop_RAA
            // 
            toolStripTop_RAA.AutoSize = false;
            toolStripTop_RAA.GripStyle = ToolStripGripStyle.Hidden;
            toolStripTop_RAA.ImageScalingSize = new System.Drawing.Size(48, 48);
            toolStripTop_RAA.Items.AddRange(new ToolStripItem[] {
                buttonOpenFile_RAA,
                toolStripSeparator1,
                buttonDone_RAA,
                toolStripSeparator2,
                buttonSaveFile_RAA,
                toolStripSeparator3,
                toolStripSeparatorRight,
                buttonHelp_RAA
            });
            toolStripTop_RAA.Location = new System.Drawing.Point(0, 0);
            toolStripTop_RAA.Name = "toolStripTop_RAA";
            toolStripTop_RAA.Padding = new Padding(6, 8, 6, 8);
            toolStripTop_RAA.Size = new System.Drawing.Size(984, 74);
            toolStripTop_RAA.TabIndex = 0;

            // 
            // buttonOpenFile_RAA
            // 
            buttonOpenFile_RAA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonOpenFile_RAA.Image = Properties.Resources.open;
            buttonOpenFile_RAA.ImageTransparentColor = System.Drawing.Color.Magenta;
            buttonOpenFile_RAA.Name = "buttonOpenFile_RAA";
            buttonOpenFile_RAA.Size = new System.Drawing.Size(52, 52);
            buttonOpenFile_RAA.ToolTipText = "Открыть файл";
            buttonOpenFile_RAA.Click += buttonOpenFile_RAA_Click;

            // 
            // buttonDone_RAA
            // 
            buttonDone_RAA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonDone_RAA.Image = Properties.Resources.done;
            buttonDone_RAA.ImageTransparentColor = System.Drawing.Color.Magenta;
            buttonDone_RAA.Name = "buttonDone_RAA";
            buttonDone_RAA.Size = new System.Drawing.Size(52, 52);
            buttonDone_RAA.ToolTipText = "Выполнить";
            buttonDone_RAA.Click += buttonDone_RAA_Click;

            // 
            // buttonSaveFile_RAA
            // 
            buttonSaveFile_RAA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonSaveFile_RAA.Image = Properties.Resources.save;
            buttonSaveFile_RAA.ImageTransparentColor = System.Drawing.Color.Magenta;
            buttonSaveFile_RAA.Name = "buttonSaveFile_RAA";
            buttonSaveFile_RAA.Size = new System.Drawing.Size(52, 52);
            buttonSaveFile_RAA.ToolTipText = "Сохранить файл";
            buttonSaveFile_RAA.Click += buttonSaveFile_RAA_Click;

            // 
            // separators
            // 
            toolStripSeparator1.AutoSize = false;
            toolStripSeparator1.Size = new System.Drawing.Size(10, 58);
            toolStripSeparator2.AutoSize = false;
            toolStripSeparator2.Size = new System.Drawing.Size(10, 58);
            toolStripSeparator3.AutoSize = false;
            toolStripSeparator3.Size = new System.Drawing.Size(10, 58);

            toolStripSeparatorRight.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparatorRight.AutoSize = false;
            toolStripSeparatorRight.Size = new System.Drawing.Size(10, 58);

            // 
            // buttonHelp_RAA
            // 
            buttonHelp_RAA.Alignment = ToolStripItemAlignment.Right;
            buttonHelp_RAA.DisplayStyle = ToolStripItemDisplayStyle.Image;
            buttonHelp_RAA.Image = Properties.Resources.help;
            buttonHelp_RAA.ImageTransparentColor = System.Drawing.Color.Magenta;
            buttonHelp_RAA.Name = "buttonHelp_RAA";
            buttonHelp_RAA.Size = new System.Drawing.Size(52, 52);
            buttonHelp_RAA.ToolTipText = "О программе";
            buttonHelp_RAA.Click += buttonHelp_RAA_Click;

            // 
            // labelTask_RAA
            // 
            labelTask_RAA.AutoSize = true;
            labelTask_RAA.Location = new System.Drawing.Point(12, 84);
            labelTask_RAA.Name = "labelTask_RAA";
            labelTask_RAA.Size = new System.Drawing.Size(77, 20);
            labelTask_RAA.TabIndex = 1;
            labelTask_RAA.Text = "Условие:";

            // 
            // textBoxTask_RAA
            // 
            textBoxTask_RAA.Location = new System.Drawing.Point(12, 108);
            textBoxTask_RAA.Multiline = true;
            textBoxTask_RAA.ReadOnly = true;
            textBoxTask_RAA.ScrollBars = ScrollBars.Vertical;
            textBoxTask_RAA.Size = new System.Drawing.Size(960, 78);
            textBoxTask_RAA.TabIndex = 2;
            textBoxTask_RAA.Text =
                "Дан файл InPutFileTask7V23.csv в котором хранится матрица целочисленных значений. " +
                "Загрузить файл через openFileDialog в объект dataGridViewIn. " +
                "Изменить в последнем столбце значения меньше 2 на 2. " +
                "Результат вывести в объект dataGridViewOut. " +
                "Сохранить результат в файл OutPutFileTask7V23.csv через saveFileDialog.";

            // 
            // labelIn_RAA
            // 
            labelIn_RAA.AutoSize = true;
            labelIn_RAA.Location = new System.Drawing.Point(12, 198);
            labelIn_RAA.Name = "labelIn_RAA";
            labelIn_RAA.Size = new System.Drawing.Size(44, 20);
            labelIn_RAA.TabIndex = 3;
            labelIn_RAA.Text = "Ввод:";

            // 
            // labelOut_RAA
            // 
            labelOut_RAA.AutoSize = true;
            labelOut_RAA.Location = new System.Drawing.Point(500, 198);
            labelOut_RAA.Name = "labelOut_RAA";
            labelOut_RAA.Size = new System.Drawing.Size(55, 20);
            labelOut_RAA.TabIndex = 4;
            labelOut_RAA.Text = "Вывод:";

            // 
            // splitContainerMain_RAA
            // 
            splitContainerMain_RAA.Location = new System.Drawing.Point(12, 222);
            splitContainerMain_RAA.Name = "splitContainerMain_RAA"; splitContainerMain_RAA.Size = new System.Drawing.Size(960, 367);
            splitContainerMain_RAA.SplitterDistance = 480;
            splitContainerMain_RAA.TabIndex = 5;

            // серый фон как у препода
            splitContainerMain_RAA.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            splitContainerMain_RAA.Panel2.BackColor = System.Drawing.SystemColors.ControlDark;

            // 
            // dataGridViewInMatrix_RAA  (БОЛЬШЕ белого)
            // 
            dataGridViewInMatrix_RAA.AllowUserToAddRows = false;
            dataGridViewInMatrix_RAA.AllowUserToDeleteRows = false;
            dataGridViewInMatrix_RAA.ReadOnly = true;
            dataGridViewInMatrix_RAA.RowHeadersVisible = false;
            dataGridViewInMatrix_RAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInMatrix_RAA.Location = new System.Drawing.Point(8, 8);
            dataGridViewInMatrix_RAA.Name = "dataGridViewInMatrix_RAA";
            dataGridViewInMatrix_RAA.Size = new System.Drawing.Size(460, 350);
            dataGridViewInMatrix_RAA.TabIndex = 0;

            // 
            // dataGridViewOutMatrix_RAA  (БОЛЬШЕ белого)
            // 
            dataGridViewOutMatrix_RAA.AllowUserToAddRows = false;
            dataGridViewOutMatrix_RAA.AllowUserToDeleteRows = false;
            dataGridViewOutMatrix_RAA.ReadOnly = true;
            dataGridViewOutMatrix_RAA.RowHeadersVisible = false;
            dataGridViewOutMatrix_RAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutMatrix_RAA.Location = new System.Drawing.Point(8, 8);
            dataGridViewOutMatrix_RAA.Name = "dataGridViewOutMatrix_RAA";
            dataGridViewOutMatrix_RAA.Size = new System.Drawing.Size(460, 350);
            dataGridViewOutMatrix_RAA.TabIndex = 0;

            splitContainerMain_RAA.Panel1.Controls.Add(dataGridViewInMatrix_RAA);
            splitContainerMain_RAA.Panel2.Controls.Add(dataGridViewOutMatrix_RAA);

            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(984, 601);
            Controls.Add(splitContainerMain_RAA);
            Controls.Add(labelOut_RAA);
            Controls.Add(labelIn_RAA);
            Controls.Add(textBoxTask_RAA);
            Controls.Add(labelTask_RAA);
            Controls.Add(toolStripTop_RAA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 23 | Решетова А.А.";

            toolStripTop_RAA.ResumeLayout(false);
            toolStripTop_RAA.PerformLayout();
            splitContainerMain_RAA.Panel1.ResumeLayout(false);
            splitContainerMain_RAA.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain_RAA).EndInit();
            splitContainerMain_RAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInMatrix_RAA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutMatrix_RAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStripTop_RAA;
        private ToolStripButton buttonOpenFile_RAA;
        private ToolStripButton buttonDone_RAA;
        private ToolStripButton buttonSaveFile_RAA;
        private ToolStripButton buttonHelp_RAA;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparatorRight;

        private Label labelTask_RAA; private TextBox textBoxTask_RAA;
        private Label labelIn_RAA;
        private Label labelOut_RAA;

        private SplitContainer splitContainerMain_RAA;
        private DataGridView dataGridViewInMatrix_RAA;
        private DataGridView dataGridViewOutMatrix_RAA;

        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogMatrix;
        private ToolTip toolTipButton_RAA;
    }
}