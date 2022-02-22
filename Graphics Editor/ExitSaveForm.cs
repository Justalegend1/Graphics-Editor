using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Editor
{
    public enum SaveDialogResult { None, Cancel, SaveAndExit, Exit};
    public partial class ExitSaveForm : Form
    {
        public ExitSaveForm(string fileName)
        {
            InitializeComponent();
            SaveFileMessage(fileName);
        }
        public ExitSaveForm()
        {
            InitializeComponent();
        }

        public SaveDialogResult SaveDialogResult { get; set; }
        public string Message { get => richTextBox1.Text; set => richTextBox1.Text = value; }

        public void SaveFileMessage(string fileName)
        {
            Message = "Файл " + fileName + " не сохранен. Вы хотите сохранить файл?";
        }

        public SaveDialogResult ShowSaveDialog()
        {
            ShowDialog();
            return SaveDialogResult;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveDialogResult = SaveDialogResult.SaveAndExit;
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            SaveDialogResult = SaveDialogResult.Exit;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            SaveDialogResult = SaveDialogResult.Cancel;
            this.Close();
        }
    }
}
