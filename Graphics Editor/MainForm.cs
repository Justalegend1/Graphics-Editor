using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Editor
{
    public enum DrawingTools { Brush, Line, Star, Ellips, Eraser}
    public partial class MainForm : Form
    {
        public DrawingTools drawingTool;
        private bool fillItem;

        public MainForm()
        {
            InitializeComponent();
            ColorOfBrush = System.Drawing.Color.Black;
            WidthOfBrush = 3;
            NumberOfTop = 3;
            brushToolStripMenuItem_Click(new object(), new EventArgs());
            statusToolStripStatusLabel1.Text = "";
            pixelToolStripStatusLabel1.Text = "";
        }

        public Color ColorOfBrush { get; set; }
        public bool FillItem { get => fillItem; }
        public int WidthOfBrush { get; private set; }
        public int NumberOfTop { get; private set; }
        public DrawingTools DrawingTool { get => drawingTool; }
        public Canvas Canvas { get { return ActiveMdiChild as Canvas; } }

        #region ToolStrip1

        #region Zoom

        private void zoomInToolStripButton4_Click(object sender, EventArgs e)
        {
            Canvas?.ViewZoomIn();
        }

        private void zoomOutToolStripButton5_Click(object sender, EventArgs e)
        {
            Canvas?.ViewZoomOut();
        }

        private void resetZoomToolStripButton_Click(object sender, EventArgs e)
        {
            Canvas?.NormalZoom();
        }
        #endregion

        #region rotate

        private void rotateLeftToolStripButton_Click(object sender, EventArgs e)
        {
            Canvas?.RotateLeft90();
        }

        private void rotateRightToolStripButton_Click(object sender, EventArgs e)
        {
            Canvas?.RotateRight90();
        }

        private void FlipHorzontalToolStripButton_Click(object sender, EventArgs e)
        {
            Canvas?.FlipHorizontal();
        }

        private void FlipVerticalToolStripButton_Click(object sender, EventArgs e)
        {
            Canvas?.FlipVertical();
        }

        #endregion

        #endregion

        #region MenuStrip

        private void FileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            bool saveEnabled = this.ActiveMdiChild != null;
            saveAsToolStripMenuItem.Enabled = saveEnabled;
            saveToolStripMenuItem.Enabled = saveEnabled;
        }

        #region Файл

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Canvas canvas = new Canvas() { MdiParent = this };
            canvas.Show();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Canvas)ActiveMdiChild).SaveAs();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Canvas)ActiveMdiChild).Save();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpeg, *.jpg)|*.jpeg;*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Canvas canvas = new Canvas(openFileDialog1.FileName)
                {
                    MdiParent = this
                };
                try
                {
                    canvas.Show();
                }
                catch
                { }
            }
        }

        #endregion

        private void PaintToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            CanvasSizeToolStripMenuItem.Enabled = ActiveMdiChild != null;
        }

        #region Рисунок

        private void CanvasSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanvasSize canvasSize = new CanvasSize()
            {
                CanvasWidth = ((Canvas)ActiveMdiChild).CanvasWidth,
                CanvasHeight = ((Canvas)ActiveMdiChild).CanvasHeight
            };

            if (canvasSize.ShowDialog() == DialogResult.OK)
            {
                ((Canvas)ActiveMdiChild).CanvasWidth = canvasSize.CanvasWidth;
                ((Canvas)ActiveMdiChild).CanvasHeight = canvasSize.CanvasHeight;
            }
        }

        #endregion

        #region Окно

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void TileVericalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        #endregion

        #region Справка

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        #endregion

        #endregion

        #region ToolStrip2

        #region Инструменты

        private void brushToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip2.Items.Clear();
            toolStrip2.Items.AddRange(new ToolStripItem[] {
            colorsStripDropDownButton1,
            drawingToolStripDropDownButton,
            widthToolStripLabel1,
            brushWidthToolStripTextBox,});
            drawingToolStripDropDownButton.Image = brushToolStripMenuItem.Image;
            drawingTool = DrawingTools.Brush;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip2.Items.Clear();
            toolStrip2.Items.AddRange(new ToolStripItem[] {
            colorsStripDropDownButton1,
            drawingToolStripDropDownButton,
            widthToolStripLabel1,
            brushWidthToolStripTextBox,});
            drawingToolStripDropDownButton.Image = lineToolStripMenuItem.Image;
            drawingTool = DrawingTools.Line;
        }

        private void ellipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip2.Items.Clear();
            toolStrip2.Items.AddRange(new ToolStripItem[] {
            colorsStripDropDownButton1,
            drawingToolStripDropDownButton,
            widthToolStripLabel1,
            brushWidthToolStripTextBox,
            fillToolStripButton});
            drawingToolStripDropDownButton.Image = ellipsToolStripMenuItem.Image;
            drawingTool = DrawingTools.Ellips;
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            fillItem = fillToolStripButton.Checked;
        }

        private void starToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip2.Items.Clear();
            toolStrip2.Items.AddRange(new ToolStripItem[] {
            colorsStripDropDownButton1,
            drawingToolStripDropDownButton,
            widthToolStripLabel1,
            brushWidthToolStripTextBox,
            fillToolStripButton,
            numberOfTopToolStripLabel,
            numberOfTopToolStripTextBox});
            drawingToolStripDropDownButton.Image = starToolStripMenuItem.Image;
            drawingTool = DrawingTools.Star;
        }

        private void eraserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip2.Items.Clear();
            toolStrip2.Items.AddRange(new ToolStripItem[] {
            drawingToolStripDropDownButton,
            widthToolStripLabel1,
            brushWidthToolStripTextBox});
            drawingToolStripDropDownButton.Image = eraserToolStripMenuItem.Image;
            drawingTool = DrawingTools.Eraser;
        }

        #endregion

        #region Choice color

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorOfBrush = System.Drawing.Color.Red;
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorOfBrush = System.Drawing.Color.Blue;
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorOfBrush = System.Drawing.Color.Green;
        }

        private void OtherColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorOfBrush = colorDialog.Color;
            }
        }

        #endregion

        #region Items Width

        private void BrushWidthToolStripTextBox_Leave(object sender, EventArgs e)
        {
            if (brushWidthToolStripTextBox.Text == "")
                brushWidthToolStripTextBox.Text = WidthOfBrush.ToString();
        }

        private void brushWidthToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;           
        }

        private void brushWidthToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            int res;
            string input = brushWidthToolStripTextBox.Text;
            if (int.TryParse(input, out res)&&res>0)
                WidthOfBrush = res;
            else if (input != "")
                brushWidthToolStripTextBox.Text = WidthOfBrush.ToString();

        }

        private void numberOfTopToolStripTextBox_Leave(object sender, EventArgs e)
        {
            numberOfTopToolStripTextBox.Text = NumberOfTop.ToString();
        }

        private void numberOfTopToolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void numberOfTopToolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            int res;
            string input =  numberOfTopToolStripTextBox.Text;
            if (int.TryParse(input, out res))
            {
                if (res >= 3)
                    NumberOfTop = res;
            }
            else if (input != "")
                numberOfTopToolStripTextBox.Text = NumberOfTop.ToString();
        }

        #endregion

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
