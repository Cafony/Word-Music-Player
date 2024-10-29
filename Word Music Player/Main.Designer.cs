namespace Word_Music_Player
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panelDown = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonChordEditor = new System.Windows.Forms.Button();
            this.buttonPlaylist = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transposeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panelTranspose = new System.Windows.Forms.Panel();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chordEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelTranspose.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDown
            // 
            this.panelDown.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDown.Location = new System.Drawing.Point(0, 622);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(1064, 139);
            this.panelDown.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 81);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(765, 535);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelRight.Location = new System.Drawing.Point(783, 84);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(269, 542);
            this.panelRight.TabIndex = 2;
            // 
            // buttonChordEditor
            // 
            this.buttonChordEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonChordEditor.Location = new System.Drawing.Point(949, 52);
            this.buttonChordEditor.Name = "buttonChordEditor";
            this.buttonChordEditor.Size = new System.Drawing.Size(75, 23);
            this.buttonChordEditor.TabIndex = 3;
            this.buttonChordEditor.Text = "Chord Editor";
            this.buttonChordEditor.UseVisualStyleBackColor = true;
            this.buttonChordEditor.Click += new System.EventHandler(this.buttonChordEditor_Click);
            // 
            // buttonPlaylist
            // 
            this.buttonPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlaylist.Location = new System.Drawing.Point(844, 52);
            this.buttonPlaylist.Name = "buttonPlaylist";
            this.buttonPlaylist.Size = new System.Drawing.Size(75, 23);
            this.buttonPlaylist.TabIndex = 4;
            this.buttonPlaylist.Text = "Playlist";
            this.buttonPlaylist.UseVisualStyleBackColor = true;
            this.buttonPlaylist.Click += new System.EventHandler(this.buttonPlaylist_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.transposeToolStripMenuItem,
            this.playlistToolStripMenuItem,
            this.chordEditorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // transposeToolStripMenuItem
            // 
            this.transposeToolStripMenuItem.Name = "transposeToolStripMenuItem";
            this.transposeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.transposeToolStripMenuItem.Text = "Transpose";
            this.transposeToolStripMenuItem.Click += new System.EventHandler(this.transposeToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panelTranspose
            // 
            this.panelTranspose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTranspose.Controls.Add(this.button1);
            this.panelTranspose.Controls.Add(this.buttonUp);
            this.panelTranspose.Location = new System.Drawing.Point(3, 0);
            this.panelTranspose.Name = "panelTranspose";
            this.panelTranspose.Size = new System.Drawing.Size(208, 50);
            this.panelTranspose.TabIndex = 6;
            this.panelTranspose.Visible = false;
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            this.playlistToolStripMenuItem.Click += new System.EventHandler(this.playlistToolStripMenuItem_Click);
            // 
            // chordEditorToolStripMenuItem
            // 
            this.chordEditorToolStripMenuItem.Name = "chordEditorToolStripMenuItem";
            this.chordEditorToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.chordEditorToolStripMenuItem.Text = "Chord Editor";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelTop.Controls.Add(this.panelTranspose);
            this.panelTop.Location = new System.Drawing.Point(12, 27);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(765, 50);
            this.panelTop.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(63, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonUp
            // 
            this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
            this.buttonUp.Location = new System.Drawing.Point(108, 10);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.buttonPlaylist);
            this.Controls.Add(this.buttonChordEditor);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1080, 750);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelTranspose.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button buttonChordEditor;
        private System.Windows.Forms.Button buttonPlaylist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem transposeToolStripMenuItem;
        public System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panelTranspose;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chordEditorToolStripMenuItem;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUp;
    }
}

