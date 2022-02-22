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
    public partial class SaveForm : Form
    {
        public SaveForm()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get => textBox.Text;
            set => textBox.BeginInvoke(new Action(() => textBox.Text = value));
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            okButton.Enabled = textBox.Text.IsValidWindowsFilename();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
