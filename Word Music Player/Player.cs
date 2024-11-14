using ManagedBass;
using ManagedBass.Fx;
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
        private float _volume;
        public bool _isPlaying;
        myPlayerFuntions _myPlayerFuntions;
        
        
        
        public Player()
        {            
            InitializeComponent();
            Bass.Init();            
            _myPlayerFuntions = new myPlayerFuntions();          
        }

        public void ResetPlayerValues()
        {
            trackBarTranspose.Value = 0;
            labelTransposeValue.Text = "0";
                        
            trackBarSpeed.Value = 0;
            trackBarSpeed.Text = "0";   
            
            buttonPlay.Text = "Play";
            checkBoxStereo.Checked = true;
            
            labelGain.Text = "0";
            checkBoxEqualizer.Checked = false;
            trackBarEqGain.Value = 0;

        }

        // Play File that was send from Playlist

        #region PLAY FILE MUSIC VOLUME
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
                    labelMusicName.Text = _filePath;
            }

        }
        public void PlayForward()
        {
            try
            {
                if (trackBarPosition.Value < trackBarPosition.Maximum)
                {
                    trackBarPosition.Value += 2;

                    if(trackBarPosition.Value > trackBarPosition.Maximum)
                    {
                        trackBarPosition.Value = trackBarPosition.Maximum;
                    }

                    _myPlayerFuntions.trackbarScrollPosition(trackBarPosition.Value, trackBarPosition.Maximum);
                 
                }         
            }
            catch { return; }
        }
        public void PlayBackward()
        {
            try
            {
                if (trackBarPosition.Value > trackBarPosition.Minimum)
                {
                    trackBarPosition.Value -= 2;

                    if (trackBarPosition.Value < trackBarPosition.Minimum)
                    {
                        trackBarPosition.Value = trackBarPosition.Minimum;
                    }

                    _myPlayerFuntions.trackbarScrollPosition(trackBarPosition.Value, trackBarPosition.Maximum);

                }
            }
            catch { return ; }
        }

        public void trackBarPosition_Scroll(object sender, EventArgs e)
        {
            if (!_myPlayerFuntions.IfStreamIsNull())
            {
                if(_isPlaying)
                {
                        _myPlayerFuntions.trackbarScrollPosition(trackBarPosition.Value, trackBarPosition.Maximum);
                }
            }
        }

        public  void buttonPlay_Click(object sender, EventArgs e)
        {
            // Check if there is a stream 
            if (!_myPlayerFuntions.IfStreamIsNull())
            {

                if (!_isPlaying)
                {
                    buttonPlay.Text = "Pause";                  
                    checkBoxStereo.Checked = true;
                    _myPlayerFuntions.PlayStream();                    
                    _isPlaying = true;

                }
                else 
                {
                    buttonPlay.Text = "Play";                   
                    _myPlayerFuntions.PauseStream();
                    _isPlaying = false;
                }
            }
            else
            {
                MessageBox.Show("No music is playing");
            }
        }

        public void buttonStop_Click(object sender, EventArgs e)
        {

                _myPlayerFuntions.StopMP3();
                buttonPlay.Text = "Play";
                _isPlaying = false;
                trackBarPosition.Value = 0;

        }
        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            // Define value by percentage
            _volume = (float)trackBarVolume.Value / trackBarVolume.Maximum;            
            myPlayerFuntions.volumeControl(_volume);            
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
                //_myPlayerFuntions.PlayMono4(false);
                _myPlayerFuntions.PlayLeft();
                checkBoxRight.Checked = false;
                checkBoxStereo.Checked = false;
            }
        }

        private void checkBoxStereo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStereo.Checked)
            {
                _myPlayerFuntions.playStereo();
                checkBoxRight.Checked = false;
                checkBoxLeft.Checked = false;
                checkBoxStereo.Checked = true;
            }
        }

        private void checkBoxRight_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxRight.Checked)
            {
                // Play Right Channel
                _myPlayerFuntions.PlayRight();
                checkBoxLeft.Checked = false;
                checkBoxStereo.Checked = false;
            }

        }
        #endregion

        #region TRACKBARS TRANSPOSE SPEED

        private void trackBarTranspose_Scroll(object sender, EventArgs e)
        {
            //labelMusicName.Text=_isPlaying.ToString();
            
            if (!_isPlaying)
            {
                _myPlayerFuntions.PitchMP3(trackBarTranspose.Value);
                labelTransposeValue.Text=trackBarTranspose.Value.ToString();
            }
            else
            {
                trackBarTranspose.Value = 0;
                MessageBox.Show("No music playing");
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
            if (!_isPlaying)
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
            if (checkBoxEqualizer.Checked==true)
            {               
                float fGain = (float)trackBarEqGain.Value;
                float freq = (float)trackBarFreq.Value;

                // Send Values To myPlayer Class
                _myPlayerFuntions.TrackbarValuesEQ(fGain, freq);
                _myPlayerFuntions.Equalizer_ON_OFF(true);
                _myPlayerFuntions.Equalizer(fGain, freq);                           
            }
            else if(checkBoxEqualizer.Checked==false)
            {
                float fGain = 0f;
                float freq = (float)trackBarFreq.Value;

                // Send Values To myPlayer Class
                _myPlayerFuntions.TrackbarValuesEQ(fGain, freq);
                _myPlayerFuntions.Equalizer_ON_OFF(false);
                _myPlayerFuntions.Equalizer(fGain, freq);
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

        private void labelFreq_Click(object sender, EventArgs e)
        {

        }
    }
}