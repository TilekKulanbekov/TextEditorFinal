namespace Texditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.closeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingBetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.fontname = new System.Windows.Forms.ComboBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.fontsize = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TotalLines = new System.Windows.Forms.ToolStripStatusLabel();
            this.ColumnNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.LineNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.autocompleteMenu2 = new AutocompleteMenuNS.AutocompleteMenu();
            this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.closeFileToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(266, 26);
            this.toolStripMenuItem1.Text = "Save As PDF";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(266, 26);
            this.toolStripMenuItem3.Text = "Print";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // closeFileToolStripMenuItem
            // 
            this.closeFileToolStripMenuItem.Name = "closeFileToolStripMenuItem";
            this.closeFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.closeFileToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.closeFileToolStripMenuItem.Text = "Close File";
            this.closeFileToolStripMenuItem.Click += new System.EventHandler(this.closeFileToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.themeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(751, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.findAndReplaceToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(253, 26);
            this.toolStripMenuItem2.Text = "Cut";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.tableToolStripMenuItem});
            this.insertToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.tableToolStripMenuItem.Text = "Table";
            this.tableToolStripMenuItem.Click += new System.EventHandler(this.tableToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testingBetsToolStripMenuItem});
            this.themeToolStripMenuItem.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // testingBetsToolStripMenuItem
            // 
            this.testingBetsToolStripMenuItem.Checked = true;
            this.testingBetsToolStripMenuItem.CheckOnClick = true;
            this.testingBetsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.testingBetsToolStripMenuItem.Name = "testingBetsToolStripMenuItem";
            this.testingBetsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.testingBetsToolStripMenuItem.Text = "Light Theme";
            this.testingBetsToolStripMenuItem.Click += new System.EventHandler(this.testingBetsToolStripMenuItem_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.AccessibleDescription = "";
            this.webBrowser1.AccessibleName = "";
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 28);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(15, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(751, 563);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(1);
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Location = new System.Drawing.Point(0, 58);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(756, 37);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "-";
            this.toolStrip2.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip2_ItemClicked);
            // 
            // fontname
            // 
            this.fontname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.fontname.FormattingEnabled = true;
            this.fontname.Location = new System.Drawing.Point(9, 63);
            this.fontname.Margin = new System.Windows.Forms.Padding(2);
            this.fontname.Name = "fontname";
            this.fontname.Size = new System.Drawing.Size(184, 28);
            this.fontname.TabIndex = 6;
            this.fontname.Text = "Select";
            this.fontname.SelectedIndexChanged += new System.EventHandler(this.fontname_SelectedIndexChanged);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(28, 29);
            this.toolStripLabel6.Text = "  |  ";
            this.toolStripLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(28, 29);
            this.toolStripLabel1.Text = "  |  ";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripLabel6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton9,
            this.toolStripLabel1,
            this.toolStripButton10,
            this.toolStripButton11});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 3);
            this.toolStrip1.Size = new System.Drawing.Size(751, 33);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "-";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.toolStripButton5.Size = new System.Drawing.Size(35, 33);
            this.toolStripButton5.Text = "Font color";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Indigo;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.toolStripButton6.Size = new System.Drawing.Size(35, 33);
            this.toolStripButton6.Text = "Background Color";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.AutoSize = false;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Padding = new System.Windows.Forms.Padding(25, 0, 10, 10);
            this.toolStripButton7.Size = new System.Drawing.Size(35, 33);
            this.toolStripButton7.Text = "Left Align";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.AutoSize = false;
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.toolStripButton8.Size = new System.Drawing.Size(35, 33);
            this.toolStripButton8.Text = "Centre Align";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.AutoSize = false;
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.toolStripButton9.Size = new System.Drawing.Size(35, 33);
            this.toolStripButton9.Text = "Right Align";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.AutoSize = false;
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.toolStripButton10.Size = new System.Drawing.Size(35, 33);
            this.toolStripButton10.Text = "Numbering";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.AutoSize = false;
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Padding = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.toolStripButton11.Size = new System.Drawing.Size(35, 33);
            this.toolStripButton11.Text = "Bullet";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // fontsize
            // 
            this.fontsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.fontsize.FormattingEnabled = true;
            this.fontsize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "12",
            "14",
            "18",
            "19",
            "20",
            "22",
            "24",
            "26",
            "27",
            "28",
            "29",
            "30",
            "32",
            "40",
            "45",
            "50",
            "55",
            "60",
            "72"});
            this.fontsize.Location = new System.Drawing.Point(196, 63);
            this.fontsize.Margin = new System.Windows.Forms.Padding(2);
            this.fontsize.Name = "fontsize";
            this.fontsize.Size = new System.Drawing.Size(87, 28);
            this.fontsize.TabIndex = 20;
            this.fontsize.Text = "Select";
            this.fontsize.SelectedIndexChanged += new System.EventHandler(this.fontSize2_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TotalLines,
            this.ColumnNumber,
            this.LineNumber});
            this.statusStrip1.Location = new System.Drawing.Point(0, 569);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(751, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TotalLines
            // 
            this.TotalLines.Name = "TotalLines";
            this.TotalLines.Size = new System.Drawing.Size(0, 17);
            // 
            // ColumnNumber
            // 
            this.ColumnNumber.Name = "ColumnNumber";
            this.ColumnNumber.Size = new System.Drawing.Size(0, 17);
            // 
            // LineNumber
            // 
            this.LineNumber.Name = "LineNumber";
            this.LineNumber.Size = new System.Drawing.Size(0, 17);
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[0];
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // autocompleteMenu2
            // 
            this.autocompleteMenu2.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu2.Colors")));
            this.autocompleteMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu2.ImageList = null;
            this.autocompleteMenu2.Items = new string[0];
            this.autocompleteMenu2.TargetControlWrapper = null;
            // 
            // findAndReplaceToolStripMenuItem
            // 
            this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            this.findAndReplaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.findAndReplaceToolStripMenuItem.Text = "Find and Replace";
            this.findAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.findAndReplaceToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.autocompleteMenu1.SetAutocompleteMenu(this.richTextBox1, this.autocompleteMenu1);
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 95);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(752, 476);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            this.richTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox1_KeyPress);
            this.richTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 591);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.fontsize);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.fontname);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Texditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ComboBox fontname;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ComboBox fontsize;
        private System.Windows.Forms.ToolStripMenuItem testingBetsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TotalLines;
        private System.Windows.Forms.ToolStripStatusLabel ColumnNumber;
        private System.Windows.Forms.ToolStripStatusLabel LineNumber;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu2;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

