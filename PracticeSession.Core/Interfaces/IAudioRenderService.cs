using System.Drawing;
using NAudio.WaveFormRenderer;

namespace PracticeSession.Core.Interfaces
{
    public interface IAudioRenderService
    {
        Image RenderAudio(string filename, IPeakProvider peakProvider, WaveFormRendererSettings settings);
    }
}
