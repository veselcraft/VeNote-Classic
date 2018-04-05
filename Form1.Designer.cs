namespace VeNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.richTextBoxClient = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllВсёToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            resources.ApplyResources(this.openFileDialog1, "openFileDialog1");
            // 
            // saveFileDialog1
            // 
            resources.ApplyResources(this.saveFileDialog1, "saveFileDialog1");
            // 
            // richTextBoxClient
            // 
            this.richTextBoxClient.AccessibleDescription = null;
            this.richTextBoxClient.AccessibleName = null;
            resources.ApplyResources(this.richTextBoxClient, "richTextBoxClient");
            this.richTextBoxClient.BackgroundImage = null;
            this.richTextBoxClient.Name = "richTextBoxClient";
            this.richTextBoxClient.TextChanged += new System.EventHandler(this.richTextBoxClient_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleDescription = null;
            this.menuStrip1.AccessibleName = null;
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackgroundImage = null;
            this.menuStrip1.Font = null;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.FormatToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AccessibleDescription = null;
            this.fileToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.BackgroundImage = null;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.AccessibleDescription = null;
            this.NewToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.NewToolStripMenuItem, "NewToolStripMenuItem");
            this.NewToolStripMenuItem.BackgroundImage = null;
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.ribbonButtonNew_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.AccessibleDescription = null;
            this.openToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.BackgroundImage = null;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.openToolStripMenuItem.Click += new System.EventHandler(this.ribbonButtonOpen_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.AccessibleDescription = null;
            this.saveToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.BackgroundImage = null;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.ribbonButtonSave_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.AccessibleDescription = null;
            this.settingsToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.BackgroundImage = null;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.ribbonOrbMenuItemSettings_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AccessibleDescription = null;
            this.toolStripMenuItem2.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.AccessibleDescription = null;
            this.exitToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.BackgroundImage = null;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ribbonOrbMenuItemExit_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.AccessibleDescription = null;
            this.EditToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.EditToolStripMenuItem, "EditToolStripMenuItem");
            this.EditToolStripMenuItem.BackgroundImage = null;
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripMenuItem3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.toolStripMenuItem4,
            this.найтиToolStripMenuItem,
            this.SelectAllВсёToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.AccessibleDescription = null;
            this.UndoToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.UndoToolStripMenuItem, "UndoToolStripMenuItem");
            this.UndoToolStripMenuItem.BackgroundImage = null;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.ribbonButtonUndo_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.AccessibleDescription = null;
            this.redoToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.redoToolStripMenuItem, "redoToolStripMenuItem");
            this.redoToolStripMenuItem.BackgroundImage = null;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.ribbonButtonRedo_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AccessibleDescription = null;
            this.toolStripMenuItem3.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.AccessibleDescription = null;
            this.cutToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
            this.cutToolStripMenuItem.BackgroundImage = null;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.ribbonButtonCut_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.AccessibleDescription = null;
            this.copyToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.BackgroundImage = null;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.ribbonButtonCopy_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.AccessibleDescription = null;
            this.PasteToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.PasteToolStripMenuItem, "PasteToolStripMenuItem");
            this.PasteToolStripMenuItem.BackgroundImage = null;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.ribbonButtonPaste_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.AccessibleDescription = null;
            this.toolStripMenuItem4.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.AccessibleDescription = null;
            this.найтиToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.найтиToolStripMenuItem, "найтиToolStripMenuItem");
            this.найтиToolStripMenuItem.BackgroundImage = null;
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.найтиToolStripMenuItem.Click += new System.EventHandler(this.ribbonButtonFind_Click);
            // 
            // SelectAllВсёToolStripMenuItem
            // 
            this.SelectAllВсёToolStripMenuItem.AccessibleDescription = null;
            this.SelectAllВсёToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.SelectAllВсёToolStripMenuItem, "SelectAllВсёToolStripMenuItem");
            this.SelectAllВсёToolStripMenuItem.BackgroundImage = null;
            this.SelectAllВсёToolStripMenuItem.Name = "SelectAllВсёToolStripMenuItem";
            this.SelectAllВсёToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.SelectAllВсёToolStripMenuItem.Click += new System.EventHandler(this.ribbonButtonSelectAll_Click);
            // 
            // FormatToolStripMenuItem
            // 
            this.FormatToolStripMenuItem.AccessibleDescription = null;
            this.FormatToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.FormatToolStripMenuItem, "FormatToolStripMenuItem");
            this.FormatToolStripMenuItem.BackgroundImage = null;
            this.FormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem});
            this.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem";
            this.FormatToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.AccessibleDescription = null;
            this.FontToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.FontToolStripMenuItem, "FontToolStripMenuItem");
            this.FontToolStripMenuItem.BackgroundImage = null;
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.ribbonButtonFont_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.AccessibleDescription = null;
            this.HelpToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.HelpToolStripMenuItem, "HelpToolStripMenuItem");
            this.HelpToolStripMenuItem.BackgroundImage = null;
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.ShortcutKeyDisplayString = null;
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.AccessibleDescription = null;
            this.AboutToolStripMenuItem.AccessibleName = null;
            resources.ApplyResources(this.AboutToolStripMenuItem, "AboutToolStripMenuItem");
            this.AboutToolStripMenuItem.BackgroundImage = null;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeyDisplayString = null;
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.ribbonOrbOptionButton2_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.richTextBoxClient);
            this.Controls.Add(this.menuStrip1);
            this.Font = null;
            this.Icon = null;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBoxClient;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem SelectAllВсёToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиToolStripMenuItem;
    }
}

