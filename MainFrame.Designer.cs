namespace LocalizationEditorNET9
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            menu = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            saveMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            saveAsMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            importMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            exportMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            exitMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            copyMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            pasteMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            duplicateMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            escapingCharactersMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            findMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            hideTranslatedMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutMenuBtn = new System.Windows.Forms.ToolStripMenuItem();
            statusbar = new System.Windows.Forms.StatusStrip();
            status = new System.Windows.Forms.ToolStripStatusLabel();
            rowCount = new System.Windows.Forms.ToolStripStatusLabel();
            nativeCulture = new System.Windows.Forms.ToolStripStatusLabel();
            toolbar = new System.Windows.Forms.ToolStrip();
            openToolBtn = new System.Windows.Forms.ToolStripButton();
            saveToolBtn = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            copyToolBtn = new System.Windows.Forms.ToolStripButton();
            pasteToolBtn = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            importToolBtn = new System.Windows.Forms.ToolStripButton();
            exportToolBtn = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            cultureCombo = new System.Windows.Forms.ToolStripComboBox();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            hideTranslatedToolBtn = new System.Windows.Forms.ToolStripButton();
            findToolBtn = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            aboutToolBtn = new System.Windows.Forms.ToolStripButton();
            openDlg = new System.Windows.Forms.OpenFileDialog();
            saveDlg = new System.Windows.Forms.SaveFileDialog();
            importDlg = new System.Windows.Forms.OpenFileDialog();
            namespaceEdit = new System.Windows.Forms.TextBox();
            keyEdit = new System.Windows.Forms.TextBox();
            pathEdit = new System.Windows.Forms.TextBox();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            translationEdit = new System.Windows.Forms.TextBox();
            dataGrid = new System.Windows.Forms.DataGridView();
            colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNamespace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTranslation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            exportDlg = new System.Windows.Forms.SaveFileDialog();
            menu.SuspendLayout();
            statusbar.SuspendLayout();
            toolbar.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackColor = System.Drawing.Color.Transparent;
            menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, helpToolStripMenuItem });
            menu.Location = new System.Drawing.Point(0, 0);
            menu.Name = "menu";
            menu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menu.Size = new System.Drawing.Size(933, 24);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openMenuBtn, saveMenuBtn, saveAsMenuBtn, toolStripMenuItem2, importMenuBtn, exportMenuBtn, toolStripMenuItem1, exitMenuBtn });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openMenuBtn
            // 
            openMenuBtn.Image = (System.Drawing.Image)resources.GetObject("openMenuBtn.Image");
            openMenuBtn.Name = "openMenuBtn";
            openMenuBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            openMenuBtn.Size = new System.Drawing.Size(193, 22);
            openMenuBtn.Text = "Open...";
            openMenuBtn.Click += OnOpen;
            // 
            // saveMenuBtn
            // 
            saveMenuBtn.Image = (System.Drawing.Image)resources.GetObject("saveMenuBtn.Image");
            saveMenuBtn.Name = "saveMenuBtn";
            saveMenuBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S;
            saveMenuBtn.Size = new System.Drawing.Size(193, 22);
            saveMenuBtn.Text = "Save";
            saveMenuBtn.Click += OnSave;
            // 
            // saveAsMenuBtn
            // 
            saveAsMenuBtn.Image = (System.Drawing.Image)resources.GetObject("saveAsMenuBtn.Image");
            saveAsMenuBtn.Name = "saveAsMenuBtn";
            saveAsMenuBtn.Size = new System.Drawing.Size(193, 22);
            saveAsMenuBtn.Text = "Save As...";
            saveAsMenuBtn.Click += OnSaveAs;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(190, 6);
            // 
            // importMenuBtn
            // 
            importMenuBtn.Image = (System.Drawing.Image)resources.GetObject("importMenuBtn.Image");
            importMenuBtn.Name = "importMenuBtn";
            importMenuBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.O;
            importMenuBtn.Size = new System.Drawing.Size(193, 22);
            importMenuBtn.Text = "Import...";
            importMenuBtn.Click += OnImport;
            // 
            // exportMenuBtn
            // 
            exportMenuBtn.Image = (System.Drawing.Image)resources.GetObject("exportMenuBtn.Image");
            exportMenuBtn.Name = "exportMenuBtn";
            exportMenuBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.S;
            exportMenuBtn.Size = new System.Drawing.Size(193, 22);
            exportMenuBtn.Text = "Export...";
            exportMenuBtn.Click += OnExport;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // exitMenuBtn
            // 
            exitMenuBtn.Name = "exitMenuBtn";
            exitMenuBtn.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X;
            exitMenuBtn.Size = new System.Drawing.Size(193, 22);
            exitMenuBtn.Text = "Exit";
            exitMenuBtn.Click += OnExit;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { copyMenuBtn, pasteMenuBtn, duplicateMenuBtn, toolStripMenuItem3, escapingCharactersMenuBtn });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // copyMenuBtn
            // 
            copyMenuBtn.Image = (System.Drawing.Image)resources.GetObject("copyMenuBtn.Image");
            copyMenuBtn.Name = "copyMenuBtn";
            copyMenuBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C;
            copyMenuBtn.Size = new System.Drawing.Size(191, 22);
            copyMenuBtn.Text = "Copy";
            copyMenuBtn.Click += OnCopy;
            // 
            // pasteMenuBtn
            // 
            pasteMenuBtn.Image = (System.Drawing.Image)resources.GetObject("pasteMenuBtn.Image");
            pasteMenuBtn.Name = "pasteMenuBtn";
            pasteMenuBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            pasteMenuBtn.Size = new System.Drawing.Size(191, 22);
            pasteMenuBtn.Text = "Paste";
            pasteMenuBtn.Click += OnPaste;
            // 
            // duplicateMenuBtn
            // 
            duplicateMenuBtn.Name = "duplicateMenuBtn";
            duplicateMenuBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D;
            duplicateMenuBtn.Size = new System.Drawing.Size(191, 22);
            duplicateMenuBtn.Text = "Duplicate";
            duplicateMenuBtn.Click += OnDuplicate;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new System.Drawing.Size(188, 6);
            // 
            // escapingCharactersMenuBtn
            // 
            escapingCharactersMenuBtn.Name = "escapingCharactersMenuBtn";
            escapingCharactersMenuBtn.Size = new System.Drawing.Size(191, 22);
            escapingCharactersMenuBtn.Text = "Escaping Characters";
            escapingCharactersMenuBtn.ToolTipText = "Removes escaping characters on copy/paste actions.";
            escapingCharactersMenuBtn.Click += OnReplaceNewLine;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { findMenuBtn, hideTranslatedMenuBtn });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            viewToolStripMenuItem.Text = "View";
            // 
            // findMenuBtn
            // 
            findMenuBtn.Image = (System.Drawing.Image)resources.GetObject("findMenuBtn.Image");
            findMenuBtn.Name = "findMenuBtn";
            findMenuBtn.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F;
            findMenuBtn.Size = new System.Drawing.Size(164, 22);
            findMenuBtn.Text = "Find...";
            findMenuBtn.Click += OnShowFind;
            // 
            // hideTranslatedMenuBtn
            // 
            hideTranslatedMenuBtn.Image = (System.Drawing.Image)resources.GetObject("hideTranslatedMenuBtn.Image");
            hideTranslatedMenuBtn.Name = "hideTranslatedMenuBtn";
            hideTranslatedMenuBtn.Size = new System.Drawing.Size(164, 22);
            hideTranslatedMenuBtn.Text = "Hide Translated";
            hideTranslatedMenuBtn.Click += OnHideTranslated;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutMenuBtn });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMenuBtn
            // 
            aboutMenuBtn.Image = (System.Drawing.Image)resources.GetObject("aboutMenuBtn.Image");
            aboutMenuBtn.Name = "aboutMenuBtn";
            aboutMenuBtn.Size = new System.Drawing.Size(180, 22);
            aboutMenuBtn.Text = "About";
            aboutMenuBtn.Click += OnAbout;
            // 
            // statusbar
            // 
            statusbar.BackColor = System.Drawing.Color.Black;
            statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { status, rowCount, nativeCulture });
            statusbar.Location = new System.Drawing.Point(0, 463);
            statusbar.Name = "statusbar";
            statusbar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusbar.Size = new System.Drawing.Size(933, 22);
            statusbar.TabIndex = 1;
            statusbar.Text = "statusStrip1";
            // 
            // status
            // 
            status.BackColor = System.Drawing.Color.Transparent;
            status.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            status.ForeColor = System.Drawing.SystemColors.InfoText;
            status.Name = "status";
            status.Size = new System.Drawing.Size(785, 17);
            status.Spring = true;
            status.Text = "Ready";
            status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rowCount
            // 
            rowCount.BackColor = System.Drawing.Color.Transparent;
            rowCount.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            rowCount.Name = "rowCount";
            rowCount.Size = new System.Drawing.Size(38, 17);
            rowCount.Text = "Rows";
            // 
            // nativeCulture
            // 
            nativeCulture.BackColor = System.Drawing.Color.Transparent;
            nativeCulture.BorderStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            nativeCulture.Margin = new System.Windows.Forms.Padding(8, 3, 0, 2);
            nativeCulture.Name = "nativeCulture";
            nativeCulture.Size = new System.Drawing.Size(85, 17);
            nativeCulture.Text = "Native Culture";
            // 
            // toolbar
            // 
            toolbar.BackColor = System.Drawing.Color.Transparent;
            toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolBtn, saveToolBtn, toolStripSeparator5, copyToolBtn, pasteToolBtn, toolStripSeparator1, importToolBtn, exportToolBtn, toolStripSeparator2, toolStripLabel1, cultureCombo, toolStripSeparator4, hideTranslatedToolBtn, findToolBtn, toolStripSeparator3, aboutToolBtn });
            toolbar.Location = new System.Drawing.Point(0, 24);
            toolbar.Name = "toolbar";
            toolbar.Size = new System.Drawing.Size(933, 25);
            toolbar.TabIndex = 2;
            toolbar.Text = "toolStrip1";
            toolbar.ItemClicked += toolbar_ItemClicked;
            // 
            // openToolBtn
            // 
            openToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            openToolBtn.Image = (System.Drawing.Image)resources.GetObject("openToolBtn.Image");
            openToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            openToolBtn.Name = "openToolBtn";
            openToolBtn.Size = new System.Drawing.Size(23, 22);
            openToolBtn.Text = "Open";
            openToolBtn.Click += OnOpen;
            // 
            // saveToolBtn
            // 
            saveToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            saveToolBtn.Image = (System.Drawing.Image)resources.GetObject("saveToolBtn.Image");
            saveToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            saveToolBtn.Name = "saveToolBtn";
            saveToolBtn.Size = new System.Drawing.Size(23, 22);
            saveToolBtn.Text = "Save";
            saveToolBtn.Click += OnSave;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // copyToolBtn
            // 
            copyToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            copyToolBtn.Image = (System.Drawing.Image)resources.GetObject("copyToolBtn.Image");
            copyToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            copyToolBtn.Name = "copyToolBtn";
            copyToolBtn.Size = new System.Drawing.Size(23, 22);
            copyToolBtn.Text = "Copy to Clipboard";
            copyToolBtn.Click += OnCopy;
            // 
            // pasteToolBtn
            // 
            pasteToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            pasteToolBtn.Image = (System.Drawing.Image)resources.GetObject("pasteToolBtn.Image");
            pasteToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            pasteToolBtn.Name = "pasteToolBtn";
            pasteToolBtn.Size = new System.Drawing.Size(23, 22);
            pasteToolBtn.Text = "Paste from Clipboard";
            pasteToolBtn.Click += OnPaste;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // importToolBtn
            // 
            importToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            importToolBtn.Image = (System.Drawing.Image)resources.GetObject("importToolBtn.Image");
            importToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            importToolBtn.Name = "importToolBtn";
            importToolBtn.Size = new System.Drawing.Size(23, 22);
            importToolBtn.Text = "Import";
            importToolBtn.Click += OnImport;
            // 
            // exportToolBtn
            // 
            exportToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            exportToolBtn.Image = (System.Drawing.Image)resources.GetObject("exportToolBtn.Image");
            exportToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            exportToolBtn.Name = "exportToolBtn";
            exportToolBtn.Size = new System.Drawing.Size(23, 22);
            exportToolBtn.Text = "Export";
            exportToolBtn.Click += OnExport;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            toolStripLabel1.Text = "Culture:";
            // 
            // cultureCombo
            // 
            cultureCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cultureCombo.Name = "cultureCombo";
            cultureCombo.Size = new System.Drawing.Size(111, 25);
            cultureCombo.SelectedIndexChanged += OnCultureChanged;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // hideTranslatedToolBtn
            // 
            hideTranslatedToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            hideTranslatedToolBtn.Image = (System.Drawing.Image)resources.GetObject("hideTranslatedToolBtn.Image");
            hideTranslatedToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            hideTranslatedToolBtn.Name = "hideTranslatedToolBtn";
            hideTranslatedToolBtn.Size = new System.Drawing.Size(23, 22);
            hideTranslatedToolBtn.Text = "Hide Translated";
            hideTranslatedToolBtn.ToolTipText = "Hide Translated";
            hideTranslatedToolBtn.Click += OnHideTranslated;
            // 
            // findToolBtn
            // 
            findToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            findToolBtn.Image = (System.Drawing.Image)resources.GetObject("findToolBtn.Image");
            findToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            findToolBtn.Name = "findToolBtn";
            findToolBtn.Size = new System.Drawing.Size(23, 22);
            findToolBtn.Text = "Find Text";
            findToolBtn.Click += OnShowFind;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // aboutToolBtn
            // 
            aboutToolBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            aboutToolBtn.Image = (System.Drawing.Image)resources.GetObject("aboutToolBtn.Image");
            aboutToolBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            aboutToolBtn.Name = "aboutToolBtn";
            aboutToolBtn.Size = new System.Drawing.Size(23, 22);
            aboutToolBtn.Text = "About";
            aboutToolBtn.Click += OnAbout;
            // 
            // openDlg
            // 
            openDlg.DefaultExt = "manifest";
            openDlg.Filter = "Localization Manifest|*.manifest|All Files|*.*";
            // 
            // saveDlg
            // 
            saveDlg.DefaultExt = "manifest";
            saveDlg.Filter = "Localization Manifest|*.manifest|All Files|*.*";
            saveDlg.OverwritePrompt = false;
            // 
            // importDlg
            // 
            importDlg.DefaultExt = "xlsx";
            importDlg.Filter = "Excel Files|*.xlsx|All Files|*.*";
            importDlg.Title = "Import";
            // 
            // namespaceEdit
            // 
            namespaceEdit.BackColor = System.Drawing.Color.Black;
            namespaceEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            namespaceEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            namespaceEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            namespaceEdit.ForeColor = System.Drawing.SystemColors.Info;
            namespaceEdit.Location = new System.Drawing.Point(4, 3);
            namespaceEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            namespaceEdit.Name = "namespaceEdit";
            namespaceEdit.PlaceholderText = "Namespace";
            namespaceEdit.ReadOnly = true;
            namespaceEdit.Size = new System.Drawing.Size(458, 16);
            namespaceEdit.TabIndex = 0;
            namespaceEdit.TabStop = false;
            // 
            // keyEdit
            // 
            keyEdit.BackColor = System.Drawing.Color.Black;
            keyEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            keyEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            keyEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            keyEdit.ForeColor = System.Drawing.SystemColors.Info;
            keyEdit.Location = new System.Drawing.Point(470, 3);
            keyEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            keyEdit.Name = "keyEdit";
            keyEdit.ReadOnly = true;
            keyEdit.Size = new System.Drawing.Size(459, 16);
            keyEdit.TabIndex = 1;
            keyEdit.TabStop = false;
            // 
            // pathEdit
            // 
            pathEdit.BackColor = System.Drawing.Color.Black;
            pathEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(pathEdit, 2);
            pathEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            pathEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            pathEdit.ForeColor = System.Drawing.SystemColors.Info;
            pathEdit.Location = new System.Drawing.Point(4, 25);
            pathEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pathEdit.Name = "pathEdit";
            pathEdit.PlaceholderText = "Context will be shown here. (a.k.a where does the text originate from)";
            pathEdit.ReadOnly = true;
            pathEdit.Size = new System.Drawing.Size(925, 16);
            pathEdit.TabIndex = 2;
            pathEdit.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pathEdit, 0, 1);
            tableLayoutPanel1.Controls.Add(keyEdit, 1, 0);
            tableLayoutPanel1.Controls.Add(namespaceEdit, 0, 0);
            tableLayoutPanel1.Controls.Add(translationEdit, 0, 2);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 267);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(933, 196);
            tableLayoutPanel1.TabIndex = 3;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // translationEdit
            // 
            translationEdit.BackColor = System.Drawing.Color.Black;
            translationEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(translationEdit, 2);
            translationEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            translationEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            translationEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            translationEdit.Location = new System.Drawing.Point(4, 47);
            translationEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            translationEdit.MaxLength = 65535;
            translationEdit.Multiline = true;
            translationEdit.Name = "translationEdit";
            translationEdit.PlaceholderText = "Your localization goes here.";
            translationEdit.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            translationEdit.Size = new System.Drawing.Size(925, 146);
            translationEdit.TabIndex = 3;
            translationEdit.Enter += OnTranslationFocused;
            translationEdit.KeyDown += OnTranslationKeyDown;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.ColumnHeadersHeight = 24;
            dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colNumber, colNamespace, colKey, colSource, colTranslation });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Unicode MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.GridColor = System.Drawing.SystemColors.Control;
            dataGrid.Location = new System.Drawing.Point(0, 49);
            dataGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGrid.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGrid.ShowEditingIcon = false;
            dataGrid.Size = new System.Drawing.Size(933, 218);
            dataGrid.TabIndex = 0;
            dataGrid.CellContentClick += dataGrid_CellContentClick;
            dataGrid.SelectionChanged += OnSelectedIndexChanged;
            dataGrid.SortCompare += OnSortCompare;
            // 
            // colNumber
            // 
            colNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SteelBlue;
            colNumber.DefaultCellStyle = dataGridViewCellStyle2;
            colNumber.HeaderText = "#";
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            colNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            colNumber.Width = 48;
            // 
            // colNamespace
            // 
            colNamespace.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            colNamespace.HeaderText = "Namespace";
            colNamespace.Name = "colNamespace";
            colNamespace.ReadOnly = true;
            colNamespace.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            colNamespace.Width = 128;
            // 
            // colKey
            // 
            colKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            colKey.HeaderText = "Key";
            colKey.Name = "colKey";
            colKey.ReadOnly = true;
            colKey.Width = 192;
            // 
            // colSource
            // 
            colSource.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colSource.HeaderText = "Source";
            colSource.Name = "colSource";
            colSource.ReadOnly = true;
            colSource.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTranslation
            // 
            colTranslation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            colTranslation.HeaderText = "Translation";
            colTranslation.Name = "colTranslation";
            colTranslation.ReadOnly = true;
            colTranslation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // exportDlg
            // 
            exportDlg.DefaultExt = "xlsx";
            exportDlg.Filter = "Excel Files|*.xlsx|All Files|*.*";
            exportDlg.OverwritePrompt = false;
            exportDlg.Title = "Export";
            // 
            // MainFrame
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(933, 485);
            Controls.Add(dataGrid);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolbar);
            Controls.Add(statusbar);
            Controls.Add(menu);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(371, 255);
            Name = "MainFrame";
            Text = "Localization Editor // .NET9";
            Load += MainFrame_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            statusbar.ResumeLayout(false);
            statusbar.PerformLayout();
            toolbar.ResumeLayout(false);
            toolbar.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuBtn;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripMenuItem openMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem saveMenuBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem importMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem exportMenuBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton openToolBtn;
        private System.Windows.Forms.ToolStripButton saveToolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton importToolBtn;
        private System.Windows.Forms.ToolStripButton exportToolBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton aboutToolBtn;
        private System.Windows.Forms.OpenFileDialog openDlg;
        private System.Windows.Forms.SaveFileDialog saveDlg;
        private System.Windows.Forms.OpenFileDialog importDlg;
        private System.Windows.Forms.TextBox pathEdit;
        private System.Windows.Forms.TextBox keyEdit;
        private System.Windows.Forms.TextBox namespaceEdit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripStatusLabel rowCount;
        private System.Windows.Forms.TextBox translationEdit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem findMenuBtn;
        private System.Windows.Forms.ToolStripComboBox cultureCombo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ToolStripStatusLabel nativeCulture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton findToolBtn;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem escapingCharactersMenuBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton copyToolBtn;
        private System.Windows.Forms.ToolStripButton pasteToolBtn;
        private System.Windows.Forms.ToolStripMenuItem duplicateMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuBtn;
        private System.Windows.Forms.ToolStripMenuItem hideTranslatedMenuBtn;
        private System.Windows.Forms.ToolStripButton hideTranslatedToolBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamespace;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTranslation;
        private System.Windows.Forms.SaveFileDialog exportDlg;
    }
}

