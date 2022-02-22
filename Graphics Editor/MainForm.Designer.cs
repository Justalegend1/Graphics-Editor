namespace Graphics_Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CanvasSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVericalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pixelToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.zoomInToolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.zoomOutToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.rotateRightToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rotateLeftToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.colorsStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drawingToolStripDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.brushToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eraserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.brushWidthToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.numberOfTopToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.numberOfTopToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filelToolStripMenuItem,
            this.paintToolStripMenuItem,
            this.окноToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.окноToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(977, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filelToolStripMenuItem
            // 
            this.filelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.ExitToolStripMenuItem});
            this.filelToolStripMenuItem.Name = "filelToolStripMenuItem";
            this.filelToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.filelToolStripMenuItem.Text = "&Файл";
            this.filelToolStripMenuItem.DropDownOpening += new System.EventHandler(this.FileToolStripMenuItem_DropDownOpening);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.newToolStripMenuItem.Text = "&Новый холст";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.openToolStripMenuItem.Text = "&Открыть...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(288, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.saveToolStripMenuItem.Text = "&Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.saveAsToolStripMenuItem.Text = "Сохранить &как...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(288, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.ExitToolStripMenuItem.Text = "&Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // paintToolStripMenuItem
            // 
            this.paintToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CanvasSizeToolStripMenuItem});
            this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
            this.paintToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.paintToolStripMenuItem.Text = "&Рисунок";
            this.paintToolStripMenuItem.DropDownOpening += new System.EventHandler(this.PaintToolStripMenuItem_DropDownOpening);
            // 
            // CanvasSizeToolStripMenuItem
            // 
            this.CanvasSizeToolStripMenuItem.Name = "CanvasSizeToolStripMenuItem";
            this.CanvasSizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.CanvasSizeToolStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.CanvasSizeToolStripMenuItem.Text = "&Размер холста";
            this.CanvasSizeToolStripMenuItem.Click += new System.EventHandler(this.CanvasSizeToolStripMenuItem_Click);
            // 
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVericalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.окноToolStripMenuItem.Text = "&Окно";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.cascadeToolStripMenuItem.Text = "&Каскадом";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVericalToolStripMenuItem
            // 
            this.tileVericalToolStripMenuItem.Name = "tileVericalToolStripMenuItem";
            this.tileVericalToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.tileVericalToolStripMenuItem.Text = "&Слева направо";
            this.tileVericalToolStripMenuItem.Click += new System.EventHandler(this.TileVericalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.tileHorizontalToolStripMenuItem.Text = "Сверху &вниз";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.arrangeIconsToolStripMenuItem.Text = "&Упорядочить значки";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.справкаToolStripMenuItem.Text = "&О программе";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.AboutToolStripMenuItem.Text = "&О программе...";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelToolStripStatusLabel1,
            this.statusToolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 600);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(977, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pixelToolStripStatusLabel1
            // 
            this.pixelToolStripStatusLabel1.Name = "pixelToolStripStatusLabel1";
            this.pixelToolStripStatusLabel1.Size = new System.Drawing.Size(47, 20);
            this.pixelToolStripStatusLabel1.Text = "pixels";
            // 
            // statusToolStripStatusLabel1
            // 
            this.statusToolStripStatusLabel1.Name = "statusToolStripStatusLabel1";
            this.statusToolStripStatusLabel1.Size = new System.Drawing.Size(49, 20);
            this.statusToolStripStatusLabel1.Text = "Status";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripButton4,
            this.zoomOutToolStripButton5,
            this.rotateRightToolStripButton,
            this.rotateLeftToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(8, 0, 1, 0);
            this.toolStrip1.Size = new System.Drawing.Size(977, 30);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // zoomInToolStripButton4
            // 
            this.zoomInToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomInToolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("zoomInToolStripButton4.Image")));
            this.zoomInToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomInToolStripButton4.Name = "zoomInToolStripButton4";
            this.zoomInToolStripButton4.Size = new System.Drawing.Size(29, 27);
            this.zoomInToolStripButton4.Text = "Приблизить";
            this.zoomInToolStripButton4.Click += new System.EventHandler(this.zoomInToolStripButton4_Click);
            // 
            // zoomOutToolStripButton5
            // 
            this.zoomOutToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.zoomOutToolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("zoomOutToolStripButton5.Image")));
            this.zoomOutToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.zoomOutToolStripButton5.Name = "zoomOutToolStripButton5";
            this.zoomOutToolStripButton5.Size = new System.Drawing.Size(29, 27);
            this.zoomOutToolStripButton5.Text = "Отдалить";
            this.zoomOutToolStripButton5.Click += new System.EventHandler(this.zoomOutToolStripButton5_Click);
            // 
            // rotateRightToolStripButton
            // 
            this.rotateRightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotateRightToolStripButton.Image = global::Graphics_Editor.Properties.Resources.RotateRight;
            this.rotateRightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotateRightToolStripButton.Name = "rotateRightToolStripButton";
            this.rotateRightToolStripButton.Size = new System.Drawing.Size(29, 27);
            this.rotateRightToolStripButton.Text = "Поворот направо";
            this.rotateRightToolStripButton.Click += new System.EventHandler(this.rotateRightToolStripButton_Click);
            // 
            // rotateLeftToolStripButton
            // 
            this.rotateLeftToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rotateLeftToolStripButton.Image = global::Graphics_Editor.Properties.Resources.RotateLeft;
            this.rotateLeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rotateLeftToolStripButton.Name = "rotateLeftToolStripButton";
            this.rotateLeftToolStripButton.Size = new System.Drawing.Size(29, 27);
            this.rotateLeftToolStripButton.Text = "Поворот налево";
            this.rotateLeftToolStripButton.Click += new System.EventHandler(this.rotateLeftToolStripButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(23, 23);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorsStripDropDownButton1,
            this.drawingToolStripDropDownButton,
            this.widthToolStripLabel1,
            this.brushWidthToolStripTextBox,
            this.fillToolStripButton,
            this.numberOfTopToolStripLabel,
            this.numberOfTopToolStripTextBox});
            this.toolStrip2.Location = new System.Drawing.Point(0, 58);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Padding = new System.Windows.Forms.Padding(8, 0, 1, 0);
            this.toolStrip2.Size = new System.Drawing.Size(977, 30);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // colorsStripDropDownButton1
            // 
            this.colorsStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorsStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.otherColorToolStripMenuItem});
            this.colorsStripDropDownButton1.Image = global::Graphics_Editor.Properties.Resources.ColorPalette;
            this.colorsStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colorsStripDropDownButton1.Name = "colorsStripDropDownButton1";
            this.colorsStripDropDownButton1.Size = new System.Drawing.Size(37, 27);
            this.colorsStripDropDownButton1.Text = "Цвета";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redToolStripMenuItem.Image")));
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.redToolStripMenuItem.Text = "Красный";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.RedToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("blueToolStripMenuItem.Image")));
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.blueToolStripMenuItem.Text = "Синий";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.BlueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("greenToolStripMenuItem.Image")));
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.greenToolStripMenuItem.Text = "Зеленый";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.GreenToolStripMenuItem_Click);
            // 
            // otherColorToolStripMenuItem
            // 
            this.otherColorToolStripMenuItem.Name = "otherColorToolStripMenuItem";
            this.otherColorToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.otherColorToolStripMenuItem.Text = "Другой...";
            this.otherColorToolStripMenuItem.Click += new System.EventHandler(this.OtherColorToolStripMenuItem_Click);
            // 
            // drawingToolStripDropDownButton
            // 
            this.drawingToolStripDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawingToolStripDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brushToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.ellipsToolStripMenuItem,
            this.starToolStripMenuItem,
            this.eraserToolStripMenuItem});
            this.drawingToolStripDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("drawingToolStripDropDownButton.Image")));
            this.drawingToolStripDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawingToolStripDropDownButton.Name = "drawingToolStripDropDownButton";
            this.drawingToolStripDropDownButton.Size = new System.Drawing.Size(37, 27);
            this.drawingToolStripDropDownButton.Text = "Инструменты";
            // 
            // brushToolStripMenuItem
            // 
            this.brushToolStripMenuItem.Image = global::Graphics_Editor.Properties.Resources.Brush;
            this.brushToolStripMenuItem.Name = "brushToolStripMenuItem";
            this.brushToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.brushToolStripMenuItem.Text = "Перо";
            this.brushToolStripMenuItem.Click += new System.EventHandler(this.brushToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Image = global::Graphics_Editor.Properties.Resources.Line;
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.lineToolStripMenuItem.Text = "Линия";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // ellipsToolStripMenuItem
            // 
            this.ellipsToolStripMenuItem.Image = global::Graphics_Editor.Properties.Resources.Ellipse;
            this.ellipsToolStripMenuItem.Name = "ellipsToolStripMenuItem";
            this.ellipsToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.ellipsToolStripMenuItem.Text = "Эллипс";
            this.ellipsToolStripMenuItem.Click += new System.EventHandler(this.ellipsToolStripMenuItem_Click);
            // 
            // starToolStripMenuItem
            // 
            this.starToolStripMenuItem.Image = global::Graphics_Editor.Properties.Resources.Star;
            this.starToolStripMenuItem.Name = "starToolStripMenuItem";
            this.starToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.starToolStripMenuItem.Text = "Звезда";
            this.starToolStripMenuItem.Click += new System.EventHandler(this.starToolStripMenuItem_Click);
            // 
            // eraserToolStripMenuItem
            // 
            this.eraserToolStripMenuItem.Image = global::Graphics_Editor.Properties.Resources.Eraser;
            this.eraserToolStripMenuItem.Name = "eraserToolStripMenuItem";
            this.eraserToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.eraserToolStripMenuItem.Text = "Ластик";
            this.eraserToolStripMenuItem.Click += new System.EventHandler(this.eraserToolStripMenuItem_Click);
            // 
            // widthToolStripLabel1
            // 
            this.widthToolStripLabel1.Name = "widthToolStripLabel1";
            this.widthToolStripLabel1.Size = new System.Drawing.Size(70, 27);
            this.widthToolStripLabel1.Text = "&Ширина:";
            // 
            // brushWidthToolStripTextBox
            // 
            this.brushWidthToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brushWidthToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.brushWidthToolStripTextBox.MaxLength = 3;
            this.brushWidthToolStripTextBox.Name = "brushWidthToolStripTextBox";
            this.brushWidthToolStripTextBox.Size = new System.Drawing.Size(30, 30);
            this.brushWidthToolStripTextBox.Text = "3";
            this.brushWidthToolStripTextBox.Leave += new System.EventHandler(this.BrushWidthToolStripTextBox_Leave);
            this.brushWidthToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.brushWidthToolStripTextBox_KeyPress);
            this.brushWidthToolStripTextBox.TextChanged += new System.EventHandler(this.brushWidthToolStripTextBox_TextChanged);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.CheckOnClick = true;
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillToolStripButton.Image")));
            this.fillToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(125, 27);
            this.fillToolStripButton.Text = "Заливка фигуры";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // numberOfTopToolStripLabel
            // 
            this.numberOfTopToolStripLabel.Name = "numberOfTopToolStripLabel";
            this.numberOfTopToolStripLabel.Size = new System.Drawing.Size(149, 27);
            this.numberOfTopToolStripLabel.Text = "&Количество вершин";
            // 
            // numberOfTopToolStripTextBox
            // 
            this.numberOfTopToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberOfTopToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numberOfTopToolStripTextBox.MaxLength = 3;
            this.numberOfTopToolStripTextBox.Name = "numberOfTopToolStripTextBox";
            this.numberOfTopToolStripTextBox.Size = new System.Drawing.Size(30, 30);
            this.numberOfTopToolStripTextBox.Text = "3";
            this.numberOfTopToolStripTextBox.Leave += new System.EventHandler(this.numberOfTopToolStripTextBox_Leave);
            this.numberOfTopToolStripTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberOfTopToolStripTextBox_KeyPress);
            this.numberOfTopToolStripTextBox.TextChanged += new System.EventHandler(this.numberOfTopToolStripTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 626);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Graphics Editor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CanvasSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVericalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton zoomInToolStripButton4;
        private System.Windows.Forms.ToolStripButton zoomOutToolStripButton5;
        private System.Windows.Forms.ToolStripButton rotateLeftToolStripButton;
        private System.Windows.Forms.ToolStripButton rotateRightToolStripButton;
        private System.Windows.Forms.ToolStripDropDownButton colorsStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel widthToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox brushWidthToolStripTextBox;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton drawingToolStripDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem brushToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ellipsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.ToolStripLabel numberOfTopToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox numberOfTopToolStripTextBox;
        private System.Windows.Forms.ToolStripMenuItem eraserToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel pixelToolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel statusToolStripStatusLabel1;
    }
}

