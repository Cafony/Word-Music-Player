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
            this.panelDown = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.buttonChordEditor = new System.Windows.Forms.Button();
            this.buttonPlaylist = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.panelRight.Location = new System.Drawing.Point(783, 81);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(284, 542);
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 761);
            this.Controls.Add(this.buttonPlaylist);
            this.Controls.Add(this.buttonChordEditor);
            this.Controls.Add(this.panelRight);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button buttonChordEditor;
        private System.Windows.Forms.Button buttonPlaylist;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

