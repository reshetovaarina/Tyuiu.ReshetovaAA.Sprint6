using System;
using System.IO;
using System.Windows.Forms;
using Tyuiu.ReshetovaAA.Sprint6.Task6.V2.Lib;

namespace Tyuiu.ReshetovaAA.Sprint6.Task6.V2
{
    public partial class FormMain : Form
    {
        private readonly DataService ds = new DataService();
        private string openFilePath = "";

        public FormMain()
        {
            InitializeComponent();
            buttonDone_RAA.Enabled = false;
        }

        private void buttonOpenFile_RAA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_RAA.ShowDialog();
            openFilePath = openFileDialogTask_RAA.FileName;

            if (string.IsNullOrWhiteSpace(openFilePath) || !File.Exists(openFilePath))
                return;

            textBoxIn_RAA.Text = File.ReadAllText(openFilePath);
            labelPath_RAA.Text = openFilePath;

            buttonDone_RAA.Enabled = true;
        }

        private void buttonDone_RAA_Click(object sender, EventArgs e)
        {
            textBoxOut_RAA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_RAA_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.ShowDialog();
        }
    }
}