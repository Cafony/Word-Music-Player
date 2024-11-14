namespace Word_Music_Player
{
    partial class Help_Shortcuts
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelHelpTopShortCuts = new System.Windows.Forms.Panel();
            this.labelHelpShortcuts = new System.Windows.Forms.Label();
            this.panelHelpTopShortCuts.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Items.AddRange(new object[] {
            "TRANSPORT BAR SHORTCUTS",
            "    - F1 to play your music",
            "    - F2 to rewind music",
            "    - F3 to forward music",
            "    - F4 to Stop"});
            this.listBox1.Location = new System.Drawing.Point(72, 145);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(441, 120);
            this.listBox1.TabIndex = 0;
            // 
            // panelHelpTopShortCuts
            // 
            this.panelHelpTopShortCuts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelHelpTopShortCuts.Controls.Add(this.labelHelpShortcuts);
            this.panelHelpTopShortCuts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHelpTopShortCuts.Location = new System.Drawing.Point(0, 0);
            this.panelHelpTopShortCuts.Name = "panelHelpTopShortCuts";
            this.panelHelpTopShortCuts.Size = new System.Drawing.Size(610, 50);
            this.panelHelpTopShortCuts.TabIndex = 5;
            // 
            // labelHelpShortcuts
            // 
            this.labelHelpShortcuts.AutoSize = true;
            this.labelHelpShortcuts.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHelpShortcuts.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHelpShortcuts.Location = new System.Drawing.Point(483, 14);
            this.labelHelpShortcuts.Name = "labelHelpShortcuts";
            this.labelHelpShortcuts.Size = new System.Drawing.Size(101, 22);
            this.labelHelpShortcuts.TabIndex = 6;
            this.labelHelpShortcuts.Text = "Shortcuts";
            this.labelHelpShortcuts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Help_Shortcuts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.panelHelpTopShortCuts);
            this.Controls.Add(this.listBox1);
            this.Name = "Help_Shortcuts";
            this.Size = new System.Drawing.Size(610, 360);
            this.panelHelpTopShortCuts.ResumeLayout(false);
            this.panelHelpTopShortCuts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panelHelpTopShortCuts;
        private System.Windows.Forms.Label labelHelpShortcuts;
    }
}
