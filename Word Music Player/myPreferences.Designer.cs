namespace Word_Music_Player
{
    partial class myPreferences
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
            this.numericUpDownTabsToSpaces = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTabsToSpaces)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Convert Tabs to Spaces.";
            // 
            // numericUpDownTabsToSpaces
            // 
            this.numericUpDownTabsToSpaces.Location = new System.Drawing.Point(137, 25);
            this.numericUpDownTabsToSpaces.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTabsToSpaces.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTabsToSpaces.Name = "numericUpDownTabsToSpaces";
            this.numericUpDownTabsToSpaces.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownTabsToSpaces.TabIndex = 1;
            this.numericUpDownTabsToSpaces.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownTabsToSpaces.ValueChanged += new System.EventHandler(this.numericUpDownTabsToSpaces_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownTabsToSpaces);
            this.groupBox1.Location = new System.Drawing.Point(35, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // myPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 234);
            this.Controls.Add(this.groupBox1);
            this.Name = "myPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "myPreferences";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTabsToSpaces)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.NumericUpDown numericUpDownTabsToSpaces;
    }
}