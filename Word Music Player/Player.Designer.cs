namespace Word_Music_Player
{
    partial class Player
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
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonOpenMp3 = new System.Windows.Forms.Button();
            this.trackBarPosition = new System.Windows.Forms.TrackBar();
            this.trackBarTranspose = new System.Windows.Forms.TrackBar();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.checkBoxRight = new System.Windows.Forms.CheckBox();
            this.checkBoxStereo = new System.Windows.Forms.CheckBox();
            this.checkBoxLeft = new System.Windows.Forms.CheckBox();
            this.checkBoxEqualizer = new System.Windows.Forms.CheckBox();
            this.trackBarEqGain = new System.Windows.Forms.TrackBar();
            this.trackBarFreq = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelGain = new System.Windows.Forms.Label();
            this.labelFreq = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelTranspose = new System.Windows.Forms.Label();
            this.labelTransposeValue = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelSpeedValue = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranspose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStop
            // 
            this.buttonStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStop.Location = new System.Drawing.Point(12, 109);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 0;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPlay.Location = new System.Drawing.Point(12, 61);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 42);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonOpenMp3
            // 
            this.buttonOpenMp3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpenMp3.Location = new System.Drawing.Point(12, 32);
            this.buttonOpenMp3.Name = "buttonOpenMp3";
            this.buttonOpenMp3.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenMp3.TabIndex = 2;
            this.buttonOpenMp3.Text = "Open Mp3";
            this.buttonOpenMp3.UseVisualStyleBackColor = true;
            this.buttonOpenMp3.Click += new System.EventHandler(this.buttonOpenMp3_Click);
            // 
            // trackBarPosition
            // 
            this.trackBarPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarPosition.Location = new System.Drawing.Point(129, 32);
            this.trackBarPosition.Maximum = 100;
            this.trackBarPosition.Name = "trackBarPosition";
            this.trackBarPosition.Size = new System.Drawing.Size(623, 45);
            this.trackBarPosition.TabIndex = 3;
            this.trackBarPosition.Scroll += new System.EventHandler(this.trackBarPosition_Scroll);
            // 
            // trackBarTranspose
            // 
            this.trackBarTranspose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarTranspose.Location = new System.Drawing.Point(129, 87);
            this.trackBarTranspose.Maximum = 6;
            this.trackBarTranspose.Minimum = -6;
            this.trackBarTranspose.Name = "trackBarTranspose";
            this.trackBarTranspose.Size = new System.Drawing.Size(203, 45);
            this.trackBarTranspose.TabIndex = 4;
            this.trackBarTranspose.Scroll += new System.EventHandler(this.trackBarTranspose_Scroll);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trackBarSpeed.Location = new System.Drawing.Point(549, 83);
            this.trackBarSpeed.Maximum = 50;
            this.trackBarSpeed.Minimum = -50;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(203, 45);
            this.trackBarSpeed.TabIndex = 5;
            this.trackBarSpeed.Scroll += new System.EventHandler(this.trackBarSpeed_Scroll);
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarVolume.Location = new System.Drawing.Point(949, 87);
            this.trackBarVolume.Maximum = 64;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(119, 45);
            this.trackBarVolume.TabIndex = 6;
            this.trackBarVolume.TickFrequency = 10;
            this.trackBarVolume.Value = 30;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // checkBoxRight
            // 
            this.checkBoxRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRight.AutoSize = true;
            this.checkBoxRight.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxRight.Location = new System.Drawing.Point(1032, 46);
            this.checkBoxRight.Name = "checkBoxRight";
            this.checkBoxRight.Size = new System.Drawing.Size(36, 31);
            this.checkBoxRight.TabIndex = 7;
            this.checkBoxRight.Text = "Right";
            this.checkBoxRight.UseVisualStyleBackColor = true;
            this.checkBoxRight.CheckedChanged += new System.EventHandler(this.checkBoxRight_CheckedChanged);
            // 
            // checkBoxStereo
            // 
            this.checkBoxStereo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxStereo.AutoSize = true;
            this.checkBoxStereo.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxStereo.Checked = true;
            this.checkBoxStereo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxStereo.Location = new System.Drawing.Point(984, 46);
            this.checkBoxStereo.Name = "checkBoxStereo";
            this.checkBoxStereo.Size = new System.Drawing.Size(42, 31);
            this.checkBoxStereo.TabIndex = 8;
            this.checkBoxStereo.Text = "Stereo";
            this.checkBoxStereo.UseVisualStyleBackColor = true;
            this.checkBoxStereo.CheckedChanged += new System.EventHandler(this.checkBoxStereo_CheckedChanged);
            // 
            // checkBoxLeft
            // 
            this.checkBoxLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxLeft.AutoSize = true;
            this.checkBoxLeft.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxLeft.Location = new System.Drawing.Point(949, 46);
            this.checkBoxLeft.Name = "checkBoxLeft";
            this.checkBoxLeft.Size = new System.Drawing.Size(29, 31);
            this.checkBoxLeft.TabIndex = 9;
            this.checkBoxLeft.Text = "Left";
            this.checkBoxLeft.UseVisualStyleBackColor = true;
            this.checkBoxLeft.CheckedChanged += new System.EventHandler(this.checkBoxLeft_CheckedChanged);
            // 
            // checkBoxEqualizer
            // 
            this.checkBoxEqualizer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEqualizer.AutoSize = true;
            this.checkBoxEqualizer.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.checkBoxEqualizer.Location = new System.Drawing.Point(862, 12);
            this.checkBoxEqualizer.Name = "checkBoxEqualizer";
            this.checkBoxEqualizer.Size = new System.Drawing.Size(50, 31);
            this.checkBoxEqualizer.TabIndex = 10;
            this.checkBoxEqualizer.Text = "On / Off";
            this.checkBoxEqualizer.UseVisualStyleBackColor = true;
            this.checkBoxEqualizer.CheckedChanged += new System.EventHandler(this.checkBoxEqualizer_CheckedChanged);
            // 
            // trackBarEqGain
            // 
            this.trackBarEqGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarEqGain.Location = new System.Drawing.Point(783, 49);
            this.trackBarEqGain.Maximum = 15;
            this.trackBarEqGain.Minimum = -15;
            this.trackBarEqGain.Name = "trackBarEqGain";
            this.trackBarEqGain.Size = new System.Drawing.Size(144, 45);
            this.trackBarEqGain.TabIndex = 11;
            this.trackBarEqGain.Scroll += new System.EventHandler(this.trackBarEqGain_Scroll);
            // 
            // trackBarFreq
            // 
            this.trackBarFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarFreq.Location = new System.Drawing.Point(783, 97);
            this.trackBarFreq.Maximum = 5000;
            this.trackBarFreq.Minimum = 100;
            this.trackBarFreq.Name = "trackBarFreq";
            this.trackBarFreq.Size = new System.Drawing.Size(144, 45);
            this.trackBarFreq.TabIndex = 12;
            this.trackBarFreq.TickFrequency = 100;
            this.trackBarFreq.Value = 2000;
            this.trackBarFreq.Scroll += new System.EventHandler(this.trackBarFrequency_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelGain
            // 
            this.labelGain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGain.AutoSize = true;
            this.labelGain.Location = new System.Drawing.Point(789, 37);
            this.labelGain.Name = "labelGain";
            this.labelGain.Size = new System.Drawing.Size(29, 13);
            this.labelGain.TabIndex = 13;
            this.labelGain.Text = "Gain";
            // 
            // labelFreq
            // 
            this.labelFreq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFreq.AutoSize = true;
            this.labelFreq.Location = new System.Drawing.Point(789, 81);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(57, 13);
            this.labelFreq.TabIndex = 14;
            this.labelFreq.Text = "Frequency";
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(949, 122);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(42, 13);
            this.labelVolume.TabIndex = 15;
            this.labelVolume.Text = "Volume";
            // 
            // labelTranspose
            // 
            this.labelTranspose.AutoSize = true;
            this.labelTranspose.Location = new System.Drawing.Point(138, 119);
            this.labelTranspose.Name = "labelTranspose";
            this.labelTranspose.Size = new System.Drawing.Size(57, 13);
            this.labelTranspose.TabIndex = 17;
            this.labelTranspose.Text = "Transpose";
            // 
            // labelTransposeValue
            // 
            this.labelTransposeValue.AutoSize = true;
            this.labelTransposeValue.Location = new System.Drawing.Point(224, 121);
            this.labelTransposeValue.Name = "labelTransposeValue";
            this.labelTransposeValue.Size = new System.Drawing.Size(13, 13);
            this.labelTransposeValue.TabIndex = 18;
            this.labelTransposeValue.Text = "0";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(556, 114);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(38, 13);
            this.labelSpeed.TabIndex = 19;
            this.labelSpeed.Text = "Speed";
            // 
            // labelSpeedValue
            // 
            this.labelSpeedValue.AutoSize = true;
            this.labelSpeedValue.Location = new System.Drawing.Point(643, 114);
            this.labelSpeedValue.Name = "labelSpeedValue";
            this.labelSpeedValue.Size = new System.Drawing.Size(13, 13);
            this.labelSpeedValue.TabIndex = 20;
            this.labelSpeedValue.Text = "0";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(141, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(57, 13);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "labelName";
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1080, 144);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelSpeedValue);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelTransposeValue);
            this.Controls.Add(this.labelTranspose);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelFreq);
            this.Controls.Add(this.labelGain);
            this.Controls.Add(this.trackBarFreq);
            this.Controls.Add(this.trackBarEqGain);
            this.Controls.Add(this.checkBoxEqualizer);
            this.Controls.Add(this.checkBoxLeft);
            this.Controls.Add(this.checkBoxStereo);
            this.Controls.Add(this.checkBoxRight);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.trackBarTranspose);
            this.Controls.Add(this.trackBarPosition);
            this.Controls.Add(this.buttonOpenMp3);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Player";
            this.Text = "Player";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranspose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEqGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFreq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonOpenMp3;
        private System.Windows.Forms.TrackBar trackBarPosition;
        private System.Windows.Forms.TrackBar trackBarTranspose;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.CheckBox checkBoxRight;
        private System.Windows.Forms.CheckBox checkBoxStereo;
        private System.Windows.Forms.CheckBox checkBoxLeft;
        private System.Windows.Forms.CheckBox checkBoxEqualizer;
        private System.Windows.Forms.TrackBar trackBarEqGain;
        private System.Windows.Forms.TrackBar trackBarFreq;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelGain;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelTranspose;
        private System.Windows.Forms.Label labelTransposeValue;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelSpeedValue;
        private System.Windows.Forms.Label labelName;
    }
}