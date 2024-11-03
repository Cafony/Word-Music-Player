using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManagedBass;
using ManagedBass.DirectX8;
using ManagedBass.Fx;
using ManagedBass.Mix;

namespace Word_Music_Player
{
    internal class myPlayerFuntions
    {
        private static  int _stream;
        private static int _mixer;
        private static int _streamInitial;
        private static  int _mono;
        private static int _streamEQ;
        private float _fGainValue;
        private float _freqValue;
        
        //private int splitter;
        
        //private bool _isPlaying;


        public myPlayerFuntions()
        {
        }

        public void CreateStream(string filePath)
        {
            Bass.Free();
            Bass.Init();            
            _streamInitial = Bass.CreateStream(filePath, 0, 0, BassFlags.Decode);                       
            _stream = BassFx.TempoCreate(_streamInitial, BassFlags.FxFreeSource);

        }

        public void PlayStream()
        {   
            Bass.ChannelPlay(_stream);            
        }

        public void FreeStream() { Bass.Free(); }
        public void PauseStream() 
        {
            Bass.ChannelPause(_stream);
            //Bass.ChannelPause(_mixer);
        }
        public void StopMP3() 
        {
                Bass.ChannelStop(_stream);  
                Bass.ChannelSetPosition(_stream, 0);
         
        }

        

        #region TRACKBAR POSITION
        public void trackbarScrollPosition(int barPositionValeu, int barPositionMaximum)
        {
            long length = Bass.ChannelGetLength(_stream, PositionFlags.Bytes);
            long newPosition = (long)((double)barPositionValeu/barPositionMaximum*length);

            Bass.ChannelSetPosition(_stream, newPosition, PositionFlags.Bytes);                
        }

        public void trackbarPosition (TrackBar trackbarValueInput, int trackbarMaximum)
        {
            long position = Bass.ChannelGetPosition(_stream, PositionFlags.Bytes);
            long length = Bass.ChannelGetLength (_stream, PositionFlags.Bytes);                

            if (length > 0)
            {
                double percentage = (double)position / length;
                int trackbarValue = (int)(percentage * trackbarMaximum);
                trackbarValueInput.Value = trackbarValue;
            }            
        }


        #endregion

        #region TRANSPOSE AND SPEED SLOWDOWN

        // Function to change the pitch of the MP3 playback
        public void PitchMP3(float pitch)
        {
            if (_stream != 0)
            {

                // (pitch is in semitones, e.g., 2.0 means 2 semitones up)
                Bass.ChannelSetAttribute(_stream, ChannelAttribute.Pitch, pitch);
            }
        }

        // Function to change the tempo without changing pitch
        public void SpeedMP3(float tempoChange)
        {
            if (_stream != 0)
            {
                // (tempoChange percentage,-10 for 10% slower, 20 for 20% faster)
                Bass.ChannelSetAttribute(_stream, ChannelAttribute.Tempo, tempoChange);
            }
        }

        #endregion

        #region PLAY MONO
        public void PlayMono1(bool useLeftChannel, bool stereo = false)
        {
            // Ensure the stream is already created
            if (_stream == 0)
            {
                MessageBox.Show("Load the music file first.");
                return;
            }

            // Free any previous mixer
            if (_mixer != 0)
            {
                Bass.StreamFree(_mixer);
            }

            if (!stereo)
            {

            }
            else
            {

            // Create a mono mixer to duplicate the left channel in both left and right outputs
            _mixer = BassMix.CreateMixerStream(44100, 2, BassFlags.Decode);
            BassMix.MixerAddChannel(_mixer, _stream, BassFlags.MixerChanMatrix);
            // Set the matrix to copy left channel to both stereo outputs
            float[,] matrix = new float[2, 2];
            matrix[0, 0] = 1.0f; // Left -> Left
            matrix[1, 0] = 1.0f; // Left -> Right
            BassMix.ChannelSetMatrix(_stream, matrix);
            }

            // Play the mixed stream
            


            // Play the mixer stream
            //Bass.ChannelPlay(_mixer, false);
        }

        public void PlayMono(bool useLeftChannel, bool stereo = false)
        {
            // Create a mono stream
        }

        public void PlayLeft()
        {

            if (_mono != 0)
            {
                // Set up the mix matrix for stereo to mono conversion
                float[,] matrix = new float[1, 2];
                matrix[0, 0] = 0.5f; // Left channel
                matrix[0, 1] = 0.5f; // Right channel

                // Apply the mix matrix
                if (BassMix.ChannelSetMatrix(_stream, matrix))
                {
                    MessageBox.Show("Stereo to Mono conversion successful!");

                    // Play the mono stream
                    Bass.ChannelPlay(_stream);
                }
                else
                {
                    MessageBox.Show("Failed to set mix matrix");
                }
            }
            else
            {
                MessageBox.Show("Failed to create mono stream");
            }
        }


        // Function to play only the right channel
        public void PlayRight()
        {
            Bass.ChannelSetAttribute(_stream, ChannelAttribute.Volume, 1.0f);  // Set right channel volume to max
            Bass.ChannelSetAttribute(_stream, ChannelAttribute.Pan, 1.0f);     // Pan to right channel
        }

        public void playStereo()
        {
            // Revert back to the stereo matrix (normal stereo)
            float[,] matrix = { { 1.0f, 0.0f },  // Left speaker plays the left channel
                        { 0.0f, 1.0f }   // Right speaker plays the right channel
                      };

            // Apply the stereo matrix to the playing stream
            BassMix.ChannelSetMatrix(_mixer, matrix);
        }

        public void PlayMono4(bool useLeftChannel, bool stereo = false)
        {
            // Ensure the stream is already created
            if (_stream == 0)
            {
                MessageBox.Show("Load the music file first.");
                return;
            }

            // Free any previous mixer
            if (_mixer != 0)
            {
                Bass.StreamFree(_mixer);
            }

            // Create a mono mixer to handle channel output
            _mixer = BassMix.CreateMixerStream(44100, 2, BassFlags.Default); // Create a stereo mixer

            if (_mixer == 0)
            {
                // Handle error if mixer creation fails
                MessageBox.Show("Error: Cant create Mixer" + Bass.LastError);
                return;
            }

            if (stereo)
            {
                // Add stereo stream to mixer (default behavior)
                BassMix.MixerAddChannel(_mixer, _stream, BassFlags.Default);
            }
            else
            {
                // Split the required channel (left or right)
                int[] splitterChannel = useLeftChannel ? new int[] { 0, -1 } : new int[] { 1, -1 }; // Left: 0, Right: 1
                var splitter = BassMix.CreateSplitStream(_stream, BassFlags.Decode, splitterChannel);

                if (splitter == 0)
                {
                    // Handle error if splitter creation fails
                    MessageBox.Show("Error: " + Bass.LastError);
                    return;
                }

                // Add the selected channel to both sides of the mixer
                BassMix.MixerAddChannel(_mixer, splitter, BassFlags.Mono | BassFlags.SpeakerLeft);
                BassMix.MixerAddChannel(_mixer, splitter, BassFlags.Mono | BassFlags.SpeakerRight);
            }

            // Play the mixer stream
            Bass.ChannelPlay(_mixer);
        }

        #endregion

        #region EQUALIZATION
        public void Equalizer_ON_OFF(bool on_off)
        {
            if (on_off == true)
            {
                _streamEQ = Bass.ChannelSetFX(_stream, EffectType.DXParamEQ, 0);
                Equalizer(_fGainValue, _freqValue);
            }
            else
            {
                Bass.ChannelRemoveFX(_stream, _streamEQ);
            }
        }

        public void TrackbarValuesEQ(float tracbarGain, float trackbarFre)
        {
            _fGainValue = tracbarGain;
            _freqValue = trackbarFre;
        }
        public void Equalizer(float fGain, float freq)
        {

            if (_stream != 0)
            {
                DXParamEQParameters _para = new DXParamEQParameters();
                //Gain value for the Band (-15... 0... 15).                
                _para.fGain = fGain;
                // Frequency from 80hz to 16000hz.
                _para.fCenter = freq;
                // Range from 1 to 36.Default 18 semitones
                _para.fBandwidth = 18;
                Bass.FXSetParameters(_streamEQ, _para);
            }
        }
        #endregion

        #region VOLUME BUTTON

        public static void volumeControl(float volume)
        {
            // Volume levels 0 to 64 max
            //Bass.ChannelSetAttribute(_stream, ChannelAttribute.MusicVolumeGlobal, volume);
            Bass.ChannelSetAttribute(_stream, ChannelAttribute.Volume, volume);


            #endregion

        }
    }
}
