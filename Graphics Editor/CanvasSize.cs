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
    public partial class CanvasSize : Form
    {
        private int canvasWidth;
        private int canvasHeight; 
        public CanvasSize()
        {
            InitializeComponent();
        }

        public int CanvasWidth
        {
            get => canvasWidth;

            set
            {
                canvasWidth = value;
                widthTextBox.Text = canvasWidth.ToString();
            }
        }
        public int CanvasHeight
        {
            get => canvasHeight;

            set
            {
                canvasHeight = value;
                heightTextBox.Text = canvasHeight.ToString();
            }
        }

        private void WidthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void WidthTextBox_Leave(object sender, EventArgs e)
        {
            if (widthTextBox.Text == "")
                widthTextBox.Text = canvasWidth.ToString();
        }

        private void HeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void heightTextBox_TextChanged(object sender, EventArgs e)
        {
            int res;
            string input = heightTextBox.Text;
            if (int.TryParse(input, out res) && res >0)
                canvasHeight = res;
            else if (input != "")
                heightTextBox.Text = canvasHeight.ToString();
        }

        private void HeightTextBox_Leave(object sender, EventArgs e)
        {
            if (heightTextBox.Text == "")
                heightTextBox.Text = canvasHeight.ToString();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            int res;
            string input = widthTextBox.Text;
            if (int.TryParse(input, out res) && res > 0)
                canvasWidth = res;
            else if (input != "")
                widthTextBox.Text = canvasWidth.ToString();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
