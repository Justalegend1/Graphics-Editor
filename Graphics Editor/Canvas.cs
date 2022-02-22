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
using System.IO;

namespace Graphics_Editor
{
    public partial class Canvas : Form
    {
        private int oldX;
        private int oldY;
        private Bitmap bitmap;
        private FileInfo path;
        private bool isSaved=true;
        private bool readOnly;

        public Canvas()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            SetBitmap(bitmap);
        }

        public Canvas(Bitmap bitmap)
        {
            InitializeComponent();
            SetBitmap(bitmap);
        }

        public Canvas(string path)
        {
            InitializeComponent();

            LoadFile(path);
        }

        private MainForm mainForm { get => this.ParentForm as MainForm; }
        private double zoomWidth
        {
            get
            { return (double)pictureBox1.Width / pictureBox1.Image.Width; }
        }
        private double zoomHeight
        {
            get
            { return (double)pictureBox1.Height / pictureBox1.Image.Height; }
        }
        public string Path { get => path?.FullName; }
        public Bitmap Bitmap
        {
            get => pictureBox1.Image as Bitmap;
        }
        public int CanvasWidth
        {
            get => pictureBox1.Width;
            set
            {
                pictureBox1.Width = value;
                Bitmap newBitmap = new Bitmap(value, pictureBox1.Height);
                Graphics graphics = Graphics.FromImage(newBitmap);
                graphics.Clear(Color.White);
                graphics.DrawImage(bitmap, 0, 0);
                SetBitmap(newBitmap);
            }
        }
        public int CanvasHeight
        {
            get => pictureBox1.Height;
            set
            {
                pictureBox1.Height = value;
                Bitmap newBitmap = new Bitmap(pictureBox1.Width, value);
                Graphics graphics = Graphics.FromImage(newBitmap);
                graphics.Clear(Color.White);
                graphics.DrawImage(bitmap, 0, 0);
                SetBitmap(newBitmap);
            }
        }
        public bool ReadOnly { get => readOnly; set => readOnly = value; }
        public bool IsNormalSize { get { return bitmap.Size == pictureBox1.Size; } }

        #region Zoom

        public void NormalZoom()
        {
            pictureBox1.Width = pictureBox1.Image.Width;
            pictureBox1.Height = pictureBox1.Image.Height;
        }

        public void ViewZoomOut()
        {
            pictureBox1.Width = pictureBox1.Width / 2;
            pictureBox1.Height = pictureBox1.Height / 2;
        }

        public void ViewZoomIn()
        {
            pictureBox1.Width = pictureBox1.Width * 2;
            pictureBox1.Height = pictureBox1.Height * 2;
        }

        #endregion

        #region Rotate

        public void RotateLeft90()
        {
            bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
            SetBitmap(bitmap);
            isSaved = false;
        }

        public void RotateRight90()
        {
            bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
            SetBitmap(bitmap);
            isSaved = false;
        }

        public void FlipHorizontal()
        {
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Refresh();
            isSaved = false;
        }

        public void FlipVertical()
        {
            bitmap.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Refresh();
            isSaved = false;
        }

        #endregion

        #region effects

        public async void ProcessEmbossAsync()
        {


            
                int dispX = 1, dispY = 1,
                    red, green, blue;
                for (int i = 0; i < bitmap.Height - 1; i++)
                {
                    for (int j = 0; j < bitmap.Width - 1; j++)
                    {
                            System.Drawing.Color
                        pixel1 = bitmap.GetPixel(j, i),
                        pixel2 = bitmap.GetPixel(j + dispX, i + dispY);
                            red = Math.Min(Math.Abs((int)pixel1.R - (int)pixel2.R) + 128, 255);
                            green = Math.Min(Math.Abs((int)pixel1.G - (int)pixel2.G) + 128, 255);
                            blue = Math.Min(Math.Abs((int)pixel1.B - (int)pixel2.B) + 128, 255);
                            bitmap.SetPixel(j, i, Color.FromArgb(red, green, blue));
                        
                    }
                    if (i % 10 == 0)
                    {
                        Invoke(new Action(() =>
                        {

                            mainForm.statusToolStripStatusLabel1.Text = $"{(int)((double)i / bitmap.Height * 100)}%";
                            mainForm.Refresh();
                            pictureBox1.Invalidate();
                            pictureBox1.Refresh();
                        }));
                    }
                }
                Invoke(new Action(() =>
                {
                    mainForm.statusToolStripStatusLabel1.Text = "";
                    pictureBox1.Invalidate();
                }));
                isSaved = false;
        }

        public async void ProcessSharpenAsync()
        {
           // await Task.Run(() =>
            //{
                int dX = 1, dY = 1,
                red, green, blue;
                for (int i = dX; i < bitmap.Height - dX; i++)
                {
                    for (int j = dY; j < bitmap.Width - dY; j++)
                    {
                        red = (int)(bitmap.GetPixel(j, i).R + 0.5 * (int)(bitmap.GetPixel(j, i).R - (int)bitmap.GetPixel(j - dX, i - dY).R));
                        green = (int)(bitmap.GetPixel(j, i).G + 0.5 * (int)(bitmap.GetPixel(j, i).G - (int)bitmap.GetPixel(j - dX, i - dY).G));
                        blue = (int)(bitmap.GetPixel(j, i).B + 0.5 * (int)(bitmap.GetPixel(j, i).B - (int)bitmap.GetPixel(j - dX, i - dY).B));
                        red = Math.Min(Math.Max(red, 0), 255);
                        green = Math.Min(Math.Max(green, 0), 255);
                        blue = Math.Min(Math.Max(blue, 0), 255);
                        bitmap.SetPixel(j, i, Color.FromArgb(red, green, blue));
                    }
                    if (i % 10 == 0)
                    {
                        Invoke(new Action(() =>
                        {
                            mainForm.statusToolStripStatusLabel1.Text = $"{(int)((double)i / bitmap.Height * 100)}%";
                            mainForm.Refresh();
                            pictureBox1.Invalidate();
                            pictureBox1.Refresh();
                        }));
                    }
                }
                //TODO: информирование пользователя о стадии выполнения
                Invoke(new Action(() =>
                {
                    mainForm.statusToolStripStatusLabel1.Text = "";
                    pictureBox1.Invalidate();
                }));
                isSaved = false;
            //});
        }

        public async void ProcessSmoothAsync()
        {
            //await Task.Run(() =>
            //{
                int dX = 1, dY = 1,
                red, green, blue;
                for (int i = dX; i < bitmap.Height - dX; i++)
                {
                    for (int j = dY; j < bitmap.Width - dY; j++)
                    {
                        red = (int)(((int)bitmap.GetPixel(j - 1, i - 1).R
                            + (int)bitmap.GetPixel(j - 1, i).R
                            + (int)bitmap.GetPixel(j - 1, i + 1).R
                            + (int)bitmap.GetPixel(j, i - 1).R
                            + (int)bitmap.GetPixel(j, i).R
                            + (int)bitmap.GetPixel(j, i + 1).R
                            + (int)bitmap.GetPixel(j + 1, i - 1).R
                            + (int)bitmap.GetPixel(j + 1, i).R
                            + (int)bitmap.GetPixel(j + 1, i + 1).R) / 9);
                        green = (int)(((int)bitmap.GetPixel(j - 1, i - 1).G
                           + (int)bitmap.GetPixel(j - 1, i).G
                           + (int)bitmap.GetPixel(j - 1, i + 1).G
                           + (int)bitmap.GetPixel(j, i - 1).G
                           + (int)bitmap.GetPixel(j, i).G
                           + (int)bitmap.GetPixel(j, i + 1).G
                           + (int)bitmap.GetPixel(j + 1, i - 1).G
                           + (int)bitmap.GetPixel(j + 1, i).G
                           + (int)bitmap.GetPixel(j + 1, i + 1).G) / 9);
                        blue = (int)(((int)bitmap.GetPixel(j - 1, i - 1).B
                           + (int)bitmap.GetPixel(j - 1, i).B
                           + (int)bitmap.GetPixel(j - 1, i + 1).B
                           + (int)bitmap.GetPixel(j, i - 1).B
                           + (int)bitmap.GetPixel(j, i).B
                           + (int)bitmap.GetPixel(j, i + 1).B
                           + (int)bitmap.GetPixel(j + 1, i - 1).B
                           + (int)bitmap.GetPixel(j + 1, i).B
                           + (int)bitmap.GetPixel(j + 1, i + 1).B) / 9);
                        red = Math.Min(Math.Max(red, 0), 255);
                        green = Math.Min(Math.Max(green, 0), 255);
                        blue = Math.Min(Math.Max(blue, 0), 255);
                        bitmap.SetPixel(j, i, Color.FromArgb(red, green, blue));
                    }
                    if (i % 10 == 0)
                    {
                        Invoke(new Action(() =>
                        {
                            mainForm.statusToolStripStatusLabel1.Text = $"{(int)((double)i / bitmap.Height * 100)}%";
                            mainForm.Refresh();
                            pictureBox1.Invalidate();
                            pictureBox1.Refresh();
                        }));
                    }
                }
                Invoke(new Action(() =>
                {
                    mainForm.statusToolStripStatusLabel1.Text = "";
                    pictureBox1.Invalidate();
                }));
                isSaved = false;
            //});
        }

        public async void ProcessDiffuseAsync()
        {
           // await Task.Run(() =>
           //{
                Random random = new Random();
                int red, green, blue,
                    dx, dy;
                for (int i = 3; i < bitmap.Height - 2; i++)
                {
                    for (int j = 3; j < bitmap.Width - 2; j++)
                    {
                        dx = random.Next(4) - 2;
                        dy = random.Next(4) - 2;
                        red = bitmap.GetPixel(j + dx, i + dy).R;
                        green = bitmap.GetPixel(j + dx, i + dy).G;
                        blue = bitmap.GetPixel(j + dx, i + dy).B;
                        bitmap.SetPixel(j, i, Color.FromArgb(red, green, blue));
                    }
                    if (i % 10 == 0)
                    {
                        Invoke(new Action(() =>
                        {
                            mainForm.statusToolStripStatusLabel1.Text = $"{(int)((double)i / bitmap.Height * 100)}%";
                            mainForm.Refresh();
                            pictureBox1.Invalidate();
                            pictureBox1.Refresh();
                        }));
                    }
                }
                Invoke(new Action(() =>
                {
                    mainForm.statusToolStripStatusLabel1.Text = "";
                    pictureBox1.Invalidate();
                }));
                isSaved = false;
            //});
        }

        #endregion

        #region Save/Load

        public virtual bool SaveAs()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpg)|*.jpg";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                if (saveFile.FilterIndex == 1)
                    bitmap.Save(saveFile.FileName, ImageFormat.Bmp);
                else if (saveFile.FilterIndex == 2)
                    bitmap.Save(saveFile.FileName, ImageFormat.Jpeg);
                LoadFile(saveFile.FileName);
                return true;
            }
            return false;
        }

        public virtual bool Save()
        {
            string path = null;
            if (this.path == null)
            {
                SaveForm saveForm = new SaveForm();
                if (saveForm.ShowDialog() == DialogResult.OK)
                    path = Environment.CurrentDirectory + "\\" + saveForm.FileName + ".bmp";
                else return false;
            }
            else path = this.path.FullName;
            if (System.IO.Path.GetExtension(path) == ".jpg")
                bitmap.Save(path, ImageFormat.Jpeg);
            else bitmap.Save(path, ImageFormat.Bmp);
            LoadFile(path);
            return true;
        }

        public virtual void LoadFile(string path)
        {
            try
            {
                var newBitmap = new Bitmap(path);
                SetBitmap(new Bitmap(newBitmap));
                newBitmap.Dispose();
                this.path = new FileInfo(path);
                this.Text = System.IO.Path.GetFileNameWithoutExtension(this.path.FullName);
                isSaved = true;
            }
            catch 
            {
                MessageBox.Show("Ошибка в формате файла");
                //this.Dispose();
                this.Close();
                
            }
        }

        #endregion

        #region Mouse

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldX = (int)(e.X / zoomWidth);
            oldY = (int)(e.Y / zoomHeight);
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int currentX = (int)(e.X / zoomWidth),
                currentY = (int)(e.Y / zoomHeight);
            mainForm.pixelToolStripStatusLabel1.Text = $"X:{currentX} Y:{currentY}";
            if (e.Button == MouseButtons.Left && !readOnly)
            {
                switch (mainForm.DrawingTool)
                {
                    case DrawingTools.Brush:
                        Graphics graphics = Graphics.FromImage(bitmap);
                        graphics.DrawLine(new Pen(mainForm.ColorOfBrush, mainForm.WidthOfBrush), oldX, oldY, currentX, currentY);
                        oldX = currentX;
                        oldY = currentY;
                        pictureBox1.Invalidate();
                        isSaved = false;
                        break;
                    case DrawingTools.Line:
                        var tempbmp = new Bitmap(bitmap);
                        graphics = Graphics.FromImage(tempbmp);
                        graphics.DrawLine(new Pen(mainForm.ColorOfBrush, mainForm.WidthOfBrush), oldX, oldY, currentX, currentY);
                        pictureBox1.Image = tempbmp;
                        pictureBox1.Invalidate();
                        break;
                    case DrawingTools.Ellips:
                        tempbmp = new Bitmap(bitmap);
                        graphics = Graphics.FromImage(tempbmp);
                        var pen = new Pen(mainForm.ColorOfBrush, mainForm.WidthOfBrush);
                        var newX = currentX - oldX;
                        var newY= currentY - oldY;
                        if (!mainForm.FillItem)
                            graphics.DrawEllipse(pen, oldX, oldY, newX, newY);
                        else graphics.FillEllipse(pen.Brush, oldX, oldY, newX, newY);
                        pictureBox1.Image = tempbmp;
                        pictureBox1.Invalidate();
                        break;
                    case DrawingTools.Star:
                        tempbmp = new Bitmap(bitmap);
                        graphics = Graphics.FromImage(tempbmp);
                        pen = new Pen(mainForm.ColorOfBrush, mainForm.WidthOfBrush);
                        newX = Math.Abs(currentX - oldX);
                        newY = Math.Abs(currentY - oldY);
                        int radius = (newX > newY ? newX : newY);
                        if (!mainForm.FillItem)
                            graphics.DrawStar(pen, oldX, oldY, radius, mainForm.NumberOfTop);
                        else graphics.FillStar(pen.Brush, oldX, oldY, radius, mainForm.NumberOfTop);
                        pictureBox1.Image = tempbmp;
                        pictureBox1.Invalidate();
                        break;
                    case DrawingTools.Eraser:
                        graphics = Graphics.FromImage(bitmap);
                        newX = currentX- mainForm.WidthOfBrush;
                        newY = currentY- mainForm.WidthOfBrush;
                        graphics.FillEllipse(new Pen(Color.White, 1).Brush, newX, newY, mainForm.WidthOfBrush*2, mainForm.WidthOfBrush*2);
                        pictureBox1.Invalidate();
                        break;
                }
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !readOnly)
            {
                switch (mainForm.DrawingTool)
                {
                    case DrawingTools.Line:
                        Graphics graphics = Graphics.FromImage(bitmap);
                        graphics.DrawLine(new Pen(mainForm.ColorOfBrush, mainForm.WidthOfBrush), oldX, oldY, (int)(e.X / zoomWidth), (int)(e.Y / zoomHeight));
                        pictureBox1.Image = bitmap;
                        pictureBox1.Invalidate();
                        break;
                    case DrawingTools.Ellips:
                        graphics = Graphics.FromImage(bitmap);
                        var pen = new Pen(mainForm.ColorOfBrush, mainForm.WidthOfBrush);
                        var newX = (int)(e.X / zoomWidth) - oldX;
                        var newY = (int)(e.Y / zoomHeight) - oldY;
                        if (!mainForm.FillItem)
                            graphics.DrawEllipse(pen, oldX, oldY, newX, newY);
                        else graphics.FillEllipse(pen.Brush, oldX, oldY, newX, newY);
                        pictureBox1.Image = bitmap;
                        pictureBox1.Invalidate();
                        break;

                    case DrawingTools.Star:
                        graphics = Graphics.FromImage(bitmap);
                        pen = new Pen(mainForm.ColorOfBrush, mainForm.WidthOfBrush);
                        newX = Math.Abs((int)(e.X / zoomWidth) - oldX);
                        newY = Math.Abs((int)(e.Y / zoomHeight) - oldY);
                        int radius = (newX > newY ? newX : newY);
                        if (!mainForm.FillItem)
                            graphics.DrawStar(pen, oldX, oldY, radius, mainForm.NumberOfTop);
                        else graphics.FillStar(pen.Brush, oldX, oldY, radius, mainForm.NumberOfTop);
                        pictureBox1.Image = bitmap;
                        pictureBox1.Invalidate();
                        break;
                }
            }
        }

        #endregion

        public void UpdateImage()
        {
            pictureBox1.Invalidate();
            pictureBox1.Refresh();
        }

        public void SetBitmap(Bitmap bitmap)
        {
            if (bitmap == null)
                throw new ArgumentNullException(nameof(bitmap));

            this.bitmap = new Bitmap(bitmap);
            pictureBox1.Width = this.bitmap.Width;
            pictureBox1.Height = this.bitmap.Height;
            pictureBox1.Image = this.bitmap;
            isSaved = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            if (!isSaved)
            {
                ExitSaveForm saveForm = new ExitSaveForm(this.Name);
                
                switch (saveForm.ShowSaveDialog())
                {
                    case SaveDialogResult.SaveAndExit:
                        e.Cancel = !this.Save();
                        break;
                    case SaveDialogResult.Exit:
                        break;
                    default: e.Cancel = true; break;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
