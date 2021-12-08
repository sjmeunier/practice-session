using BigMansStuff.NAudio.Ogg;
using NAudio.Wave;
using NAudio.WaveFormRenderer;
using PracticeSession.Core.Interfaces;
using System;
using System.Drawing;
using System.IO;

namespace PracticeSession.Core.Services
{
    public class AudioRenderService : IAudioRenderService
    {
        private WaveFormRenderer _waveFormRenderer;

        public AudioRenderService()
        {
            _waveFormRenderer = new WaveFormRenderer();
        }
        public Image RenderAudio(string filename, IPeakProvider peakProvider, WaveFormRendererSettings settings)
        {
            Image image;


            using (var waveStream = GetWaveStream(filename))
            {
                image = _waveFormRenderer.Render(waveStream, peakProvider, settings);
            }

            return image;
        }

        private WaveStream GetWaveStream(string filename)
        {
            WaveStream waveStream;

            string fileExt = Path.GetExtension(filename.ToLower());
            if (fileExt == Constants.MP3Extension)
            {
                waveStream = new Mp3FileReader(filename);
            }
            else if (fileExt == Constants.M4AExtension)
            {
                waveStream = new MediaFoundationReader(filename);
            }
            else if (fileExt == Constants.WAVExtension)
            {
                waveStream = new WaveFileReader(filename);
                if (waveStream.WaveFormat.Encoding != WaveFormatEncoding.Pcm)
                {
                    waveStream = WaveFormatConversionStream.CreatePcmStream(waveStream);
                    waveStream = new BlockAlignReductionStream(waveStream);
                }
                if (waveStream.WaveFormat.BitsPerSample != 16)
                {
                    var format = new WaveFormat(waveStream.WaveFormat.SampleRate,
                       16, waveStream.WaveFormat.Channels);
                    waveStream = new WaveFormatConversionStream(format, waveStream);
                }

            }
            else if (fileExt == Constants.OGGVExtension)
            {
                waveStream = new OggVorbisFileReader(filename);
                if (waveStream.WaveFormat.Encoding != WaveFormatEncoding.Pcm)
                {
                    waveStream = WaveFormatConversionStream.CreatePcmStream(waveStream);
                    waveStream = new BlockAlignReductionStream(waveStream);
                }
                if (waveStream.WaveFormat.BitsPerSample != 16)
                {
                    var format = new WaveFormat(waveStream.WaveFormat.SampleRate,
                       16, waveStream.WaveFormat.Channels);
                    waveStream = new WaveFormatConversionStream(format, waveStream);
                }

            }
            else if (fileExt == Constants.AIFFExtension)
            {
                waveStream = new AiffFileReader(filename);
            }
            else
            {
                throw new ApplicationException("Cannot create wave stream - Unknown file type: " + fileExt);
            }

            return waveStream;
        }
    }
}
