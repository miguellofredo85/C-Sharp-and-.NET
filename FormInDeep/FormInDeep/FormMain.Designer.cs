namespace FormInDeep
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnThread = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mDeveloper = new System.Windows.Forms.ToolStripMenuItem();
            this.mVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.comboMenu = new System.Windows.Forms.ToolStripComboBox();
            this.mSearch = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1047, 168);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "FormSecond";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnThread
            // 
            this.btnThread.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThread.Location = new System.Drawing.Point(160, 428);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(133, 47);
            this.btnThread.TabIndex = 2;
            this.btnThread.Text = "FormSecond Thread";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.comboMenu,
            this.mSearch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileNew,
            this.mFileOpen,
            this.toolStripSeparator1,
            this.mFileClose});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 28);
            this.menuFile.Text = "File";
            // 
            // mFileNew
            // 
            this.mFileNew.Name = "mFileNew";
            this.mFileNew.ShortcutKeyDisplayString = "";
            this.mFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mFileNew.Size = new System.Drawing.Size(224, 26);
            this.mFileNew.Text = "New";
            this.mFileNew.Click += new System.EventHandler(this.mFileNew_Click);
            // 
            // mFileOpen
            // 
            this.mFileOpen.Name = "mFileOpen";
            this.mFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mFileOpen.Size = new System.Drawing.Size(224, 26);
            this.mFileOpen.Text = "Open";
            this.mFileOpen.Click += new System.EventHandler(this.mFileOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(125, 6);
            // 
            // mFileClose
            // 
            this.mFileClose.Name = "mFileClose";
            this.mFileClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.mFileClose.Size = new System.Drawing.Size(224, 26);
            this.mFileClose.Text = "Close";
            this.mFileClose.Click += new System.EventHandler(this.mFileClose_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpAbout});
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(55, 28);
            this.menuHelp.Text = "Help";
            // 
            // mHelpAbout
            // 
            this.mHelpAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDeveloper,
            this.mVersion});
            this.mHelpAbout.Name = "mHelpAbout";
            this.mHelpAbout.Size = new System.Drawing.Size(133, 26);
            this.mHelpAbout.Text = "About";
            // 
            // mDeveloper
            // 
            this.mDeveloper.Name = "mDeveloper";
            this.mDeveloper.Size = new System.Drawing.Size(161, 26);
            this.mDeveloper.Text = "Developer";
            this.mDeveloper.Click += new System.EventHandler(this.mDeveloper_Click);
            // 
            // mVersion
            // 
            this.mVersion.Name = "mVersion";
            this.mVersion.Size = new System.Drawing.Size(161, 26);
            this.mVersion.Text = "Version";
            this.mVersion.Click += new System.EventHandler(this.mVersion_Click);
            // 
            // comboMenu
            // 
            this.comboMenu.Items.AddRange(new object[] {
            "English",
            "Portuguese",
            "Spanish"});
            this.comboMenu.Name = "comboMenu";
            this.comboMenu.Size = new System.Drawing.Size(121, 28);
            this.comboMenu.SelectedIndexChanged += new System.EventHandler(this.comboMenu_SelectedIndexChanged);
            // 
            // mSearch
            // 
            this.mSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mSearch.Name = "mSearch";
            this.mSearch.Size = new System.Drawing.Size(100, 28);
            this.mSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mSearch_KeyUp);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 532);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnThread;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem mFileNew;
        private System.Windows.Forms.ToolStripMenuItem mFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mFileClose;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem mHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem mDeveloper;
        private System.Windows.Forms.ToolStripMenuItem mVersion;
        private System.Windows.Forms.ToolStripComboBox comboMenu;
        private System.Windows.Forms.ToolStripTextBox mSearch;
    }
}

