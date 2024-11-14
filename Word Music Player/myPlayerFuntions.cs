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
        private static int _streamTempo;        
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
            _streamTempo = BassFx.TempoCreate(_streamInitial, BassFlags.FxFreeSource | BassFlags.Decode);
            _stream = BassMix.CreateSplitStream(_streamTempo, BassFlags.Default, null);

        }

        #region PLAY STOP PAUSE STREAM
        public bool IfStreamIsNull()
        {
            return _stream == 0;
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

        #endregion

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
                Bass.ChannelSetAttribute(_streamTempo, ChannelAttribute.Pitch, pitch);
            }
        }

        // Function to change the tempo without changing pitch
        public void SpeedMP3(float tempoChange)
        {
            if (_stream != 0)
            {
                // (tempoChange percentage,-10 for 10% slower, 20 for 20% faster)
                Bass.ChannelSetAttribute(_streamTempo, ChannelAttribute.Tempo, tempoChange);
            }
        }

        #endregion

        #region PLAY MONO

        public void PlayLeft()
        {
            Bass.StreamFree(_stream);
            int[] splitterChannel = new int[] { 0, 0, -1 };
            _stream = BassMix.CreateSplitStream(_streamTempo, BassFlags.Default, splitterChannel);
            Bass.ChannelPlay(_stream);
        }
              
        public void PlayRight()
        {              
            Bass.StreamFree(_stream);
            int[] splitterChannel = new int[] { 1, 1, -1 };
            _stream = BassMix.CreateSplitStream(_streamTempo,BassFlags.Default, splitterChannel);
            Bass.ChannelPlay(_stream);
        }

        public void playStereo()
        {
            Bass.StreamFree(_stream);
            _stream = BassMix.CreateSplitStream(_streamTempo, BassFlags.Default, null);
            Bass.ChannelPlay(_stream);
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
                //Bass.FXReset(_streamEQ);
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
