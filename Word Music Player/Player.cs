using ManagedBass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Music_Player
{
    public partial class Player : Form
    {

        public static  string _filePath;

        public bool _isPlaying;
        myPlayerFuntions _myPlayerFuntions;
        
        
        
        public Player()
        {
            InitializeComponent();
            _myPlayerFuntions = new myPlayerFuntions();
            
        
        }

        private void ResetPlayerValues()
        {
            trackBarTranspose.Value = 0;
            labelTransposeValue.Text = "0";
            trackBarEqGain.Value = 0;
            labelGain.Text = "0";
            trackBarSpeed.Value = 0;
            trackBarSpeed.Text = "0";   
            buttonPlay.Text = "Play";
            checkBoxStereo.Checked = true;
        }

        // Play File that was send from Playlist

        #region PLAY FILE MUSIC
        private void buttonOpenMp3_Click(object sender, EventArgs e)
        {
            ResetPlayerValues();            

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;
            openFile.Title = "Open";
            openFile.Filter = "Musicas |*.mp3;*.wma;*.wav";

            if (openFile.ShowDialog() == DialogResult.OK)
            {                  
                    _filePath = openFile.FileName;
                    _myPlayerFuntions.CreateStream(_filePath);                      
            }

        }

        public void FileToPlay(string file)
        {
                _filePath = file;

            if(!_isPlaying)
            {
                labelName.Text = _filePath;
                _myPlayerFuntions.CreateStream(_filePath);
            }
            else
            {
                _myPlayerFuntions.StopMP3();
                _isPlaying = false;
            }
        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            labelName.Text = _filePath;           

               
                if (!_isPlaying)
                {
                    checkBoxStereo.Checked = true;
                    _myPlayerFuntions.PlayStream();                    
                    _isPlaying = true;
                    buttonPlay.Text = "Pause";                  

                }
                else 
                {
                    _myPlayerFuntions.PauseStream();
                    _isPlaying = false;
                    buttonPlay.Text = "Play";
                   
                }

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {

                _myPlayerFuntions.StopMP3();
                buttonPlay.Text = "Play";
                _isPlaying = false;
                trackBarPosition.Value = 0;

        }

        private void trackBarPosition_Scroll(object sender, EventArgs e)
        {
            if(_isPlaying)
            {
                    _myPlayerFuntions.trackbarScrollPosition(trackBarPosition.Value, trackBarPosition.Maximum);
            }
        }

        #endregion  

        private void timer1_Tick(object sender, EventArgs e)
        {
            
         _myPlayerFuntions.trackbarPosition(trackBarPosition,trackBarPosition.Maximum);
            
        }

        #region MONO LEFT STERO MONO RIGHT
        private void checkBoxLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLeft.Checked)
            {
                // Play left channel
                //_myPlayerFuntions.PlayMono(true);
                _myPlayerFuntions.PlayLeft();
                checkBoxRight.Checked = false;
                checkBoxStereo.Checked = false;
            }
        }

        private void checkBoxStereo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStereo.Checked)
            {

                checkBoxRight.Checked = false;
                checkBoxLeft.Checked = false;
                checkBoxStereo.Checked = true;
                _myPlayerFuntions.PlayMono(false, true);
            }
        }

        private void checkBoxRight_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxRight.Checked)
            {

                // Play Right Channel
                _myPlayerFuntions.PlayMono(false);
                checkBoxLeft.Checked = false;
                checkBoxStereo.Checked = false;
            }

        }
        #endregion

        #region TRACKBARS TRANSPOSE SPEED

        private void trackBarTranspose_Scroll(object sender, EventArgs e)
        {
            labelName.Text=_isPlaying.ToString();

            if (_isPlaying)
            {
                trackBarTranspose.Value = 0;
                MessageBox.Show("No music playing");
            }
            else
            {
                _myPlayerFuntions.PitchMP3(trackBarTranspose.Value);
                labelTransposeValue.Text=trackBarTranspose.Value.ToString();
            }
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            if (!_isPlaying)
            {
                _myPlayerFuntions.SpeedMP3(trackBarSpeed.Value);
                labelSpeedValue.Text=trackBarSpeed.Value.ToString();
            }
            else
            {
                trackBarSpeed.Value = 0;
                MessageBox.Show("No music playing");
            }
        }
        #endregion

        #region EQUALIZATION
        private void trackBarEqGain_Scroll(object sender, EventArgs e)
        {
            if (_isPlaying)
            {
                int fGain = trackBarEqGain.Value;
                int freq =  trackBarFreq.Value;
                labelGain.Text = "Gain:" + fGain.ToString() + " db";
                _myPlayerFuntions.Equalizer(fGain, freq);
            }
            else
            {
                trackBarEqGain.Value = 0;
                MessageBox.Show("No music playing");
            }
        }


        private void checkBoxEqualizer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEqualizer.Checked)
            {
                float fGain = (float)trackBarEqGain.Value;
                float freq = (float)trackBarFreq.Value;

                // Send Values To myPlayer Class
                _myPlayerFuntions.TrackbarValuesEQ(fGain, freq);
                _myPlayerFuntions.Equalizer_ON_OFF(true);
                _myPlayerFuntions.Equalizer(fGain, freq);

            }
            else
            {
                _myPlayerFuntions.Equalizer_ON_OFF(false);
            }
        }

        private void trackBarFrequency_Scroll(object sender, EventArgs e)
        {
            int fGain = trackBarEqGain.Value;
            int freq = trackBarFreq.Value;

            labelFreq.Text = "Frequency: "+trackBarFreq.Value.ToString()+" Hz";
            


            labelGain.Text = fGain.ToString();
            _myPlayerFuntions.Equalizer(fGain, freq);
        }
        #endregion

    }
}
