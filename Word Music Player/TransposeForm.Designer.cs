namespace Word_Music_Player
{
    partial class TransposeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransposeForm));
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDown = new System.Windows.Forms.Button();
            this.labelTransposeTitle = new System.Windows.Forms.Label();
            this.buttonUp = new System.Windows.Forms.Button();
            this.labelTransposeValue = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(54, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Só funciona com os acordes em CIFRA !\r\n";
            // 
            // buttonDown
            // 
            this.buttonDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonDown.Image")));
            this.buttonDown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDown.Location = new System.Drawing.Point(112, 131);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(94, 31);
            this.buttonDown.TabIndex = 8;
            this.buttonDown.Text = "Down";
            this.buttonDown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // labelTransposeTitle
            // 
            this.labelTransposeTitle.AutoSize = true;
            this.labelTransposeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransposeTitle.Location = new System.Drawing.Point(72, 45);
            this.labelTransposeTitle.Name = "labelTransposeTitle";
            this.labelTransposeTitle.Size = new System.Drawing.Size(155, 20);
            this.labelTransposeTitle.TabIndex = 7;
            this.labelTransposeTitle.Text = "Transpose Chords";
            // 
            // buttonUp
            // 
            this.buttonUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
            this.buttonUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUp.Location = new System.Drawing.Point(112, 84);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(94, 31);
            this.buttonUp.TabIndex = 6;
            this.buttonUp.Text = "Up";
            this.buttonUp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // labelTransposeValue
            // 
            this.labelTransposeValue.AutoSize = true;
            this.labelTransposeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransposeValue.Location = new System.Drawing.Point(233, 45);
            this.labelTransposeValue.Name = "labelTransposeValue";
            this.labelTransposeValue.Size = new System.Drawing.Size(19, 20);
            this.labelTransposeValue.TabIndex = 10;
            this.labelTransposeValue.Text = "0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(517, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(478, 448);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // TransposeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 508);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelTransposeValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.labelTransposeTitle);
            this.Controls.Add(this.buttonUp);
            this.Name = "TransposeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transpose";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Label labelTransposeTitle;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Label labelTransposeValue;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}