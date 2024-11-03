namespace Word_Music_Player
{
    partial class Playlist
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
            this.listBoxPlaylist = new System.Windows.Forms.ListBox();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.buttonRemoveListIten = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearchMp3 = new System.Windows.Forms.TextBox();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.buttonSaveList = new System.Windows.Forms.Button();
            this.labelMusicPlaylist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxPlaylist
            // 
            this.listBoxPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxPlaylist.FormattingEnabled = true;
            this.listBoxPlaylist.Location = new System.Drawing.Point(11, 12);
            this.listBoxPlaylist.Name = "listBoxPlaylist";
            this.listBoxPlaylist.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxPlaylist.Size = new System.Drawing.Size(245, 407);
            this.listBoxPlaylist.TabIndex = 0;
            this.listBoxPlaylist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPlaylist_MouseClick);
            this.listBoxPlaylist.SelectedIndexChanged += new System.EventHandler(this.listBoxPlaylist_SelectedIndexChanged);
            this.listBoxPlaylist.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.listBoxPlaylist_Format);
            this.listBoxPlaylist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxPlaylist_KeyDown);
            this.listBoxPlaylist.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxPlaylist_MouseDoubleClick);
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFiles.Location = new System.Drawing.Point(11, 425);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(110, 29);
            this.buttonAddFiles.TabIndex = 1;
            this.buttonAddFiles.Text = "Add Music";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // buttonRemoveListIten
            // 
            this.buttonRemoveListIten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveListIten.Location = new System.Drawing.Point(146, 425);
            this.buttonRemoveListIten.Name = "buttonRemoveListIten";
            this.buttonRemoveListIten.Size = new System.Drawing.Size(110, 29);
            this.buttonRemoveListIten.TabIndex = 3;
            this.buttonRemoveListIten.Text = "Remove Music";
            this.buttonRemoveListIten.UseVisualStyleBackColor = true;
            this.buttonRemoveListIten.Click += new System.EventHandler(this.buttonRemoveListIten_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(11, 523);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(72, 13);
            this.labelSearch.TabIndex = 4;
            this.labelSearch.Text = "Search Music";
            // 
            // textBoxSearchMp3
            // 
            this.textBoxSearchMp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearchMp3.Location = new System.Drawing.Point(95, 520);
            this.textBoxSearchMp3.Name = "textBoxSearchMp3";
            this.textBoxSearchMp3.Size = new System.Drawing.Size(161, 20);
            this.textBoxSearchMp3.TabIndex = 5;
            this.textBoxSearchMp3.TextChanged += new System.EventHandler(this.textBoxSearchMp3_TextChanged);
            // 
            // buttonClearList
            // 
            this.buttonClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearList.Location = new System.Drawing.Point(11, 460);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.Size = new System.Drawing.Size(110, 29);
            this.buttonClearList.TabIndex = 6;
            this.buttonClearList.Text = "Clear List";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // buttonSaveList
            // 
            this.buttonSaveList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveList.Location = new System.Drawing.Point(146, 460);
            this.buttonSaveList.Name = "buttonSaveList";
            this.buttonSaveList.Size = new System.Drawing.Size(110, 29);
            this.buttonSaveList.TabIndex = 7;
            this.buttonSaveList.Text = "Save List";
            this.buttonSaveList.UseVisualStyleBackColor = true;
            this.buttonSaveList.Click += new System.EventHandler(this.buttonSaveList_Click);
            // 
            // labelMusicPlaylist
            // 
            this.labelMusicPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMusicPlaylist.AutoSize = true;
            this.labelMusicPlaylist.Location = new System.Drawing.Point(13, 496);
            this.labelMusicPlaylist.Name = "labelMusicPlaylist";
            this.labelMusicPlaylist.Size = new System.Drawing.Size(35, 13);
            this.labelMusicPlaylist.TabIndex = 8;
            this.labelMusicPlaylist.Text = "Music";
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(268, 552);
            this.ControlBox = false;
            this.Controls.Add(this.labelMusicPlaylist);
            this.Controls.Add(this.buttonSaveList);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.textBoxSearchMp3);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.buttonRemoveListIten);
            this.Controls.Add(this.buttonAddFiles);
            this.Controls.Add(this.listBoxPlaylist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Playlist";
            this.Text = "Playlist";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Playlist_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Playlist_FormClosed);
            this.Load += new System.EventHandler(this.Playlist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPlaylist;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.Button buttonRemoveListIten;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearchMp3;
        private System.Windows.Forms.Button buttonClearList;
        private System.Windows.Forms.Button buttonSaveList;
        private System.Windows.Forms.Label labelMusicPlaylist;
    }
}