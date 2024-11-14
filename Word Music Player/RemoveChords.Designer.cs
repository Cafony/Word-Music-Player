namespace Word_Music_Player
{
    partial class RemoveChords
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelHelpRemoveChords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelHelpRemoveChords
            // 
            this.labelHelpRemoveChords.AutoSize = true;
            this.labelHelpRemoveChords.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHelpRemoveChords.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelpRemoveChords.Location = new System.Drawing.Point(398, 15);
            this.labelHelpRemoveChords.Name = "labelHelpRemoveChords";
            this.labelHelpRemoveChords.Size = new System.Drawing.Size(159, 22);
            this.labelHelpRemoveChords.TabIndex = 6;
            this.labelHelpRemoveChords.Text = "Remove Chords";
            this.labelHelpRemoveChords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveChords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.labelHelpRemoveChords);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RemoveChords";
            this.Size = new System.Drawing.Size(560, 320);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelHelpRemoveChords;
    }
}
