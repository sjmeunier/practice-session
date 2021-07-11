using System;
using PracticeSession.Core.Enums;
using PracticeSession.Core.Events;
using PracticeSession.Core.Models;

namespace PracticeSession.Core.Interfaces
{
    public interface IAudioPlaybackService
    {
        public event EventHandler PlayTimeChanged;
        public event EventHandler<PlaybackStatusChangedEventArgs> PlaybackStatusChanged;
        public event EventHandler CueWaitPulsed;

        public TimeSpan FilePlayDuration { get; }
        public float Tempo { get; set; }

        public float Pitch { get; set; }
        public float Volume { get; set; }
        public float EqualizerLoBand { get; set; }
        public float EqualizerMedBand { get; set; }
        public float EqualizerHiBand { get; set; }

        public InputChannelMode InputChannelMode { get; set; }
        public bool SwapLeftRightSpeakers { get; set; }
        public TimeStretchProfile TimeStretchProfile { get; set; }
        public PlaybackStatus PlaybackStatus { get; }

        public TimeSpan CurrentPlayTime { get; set; }
        public bool Loop { get; set; }
        public TimeSpan StartMarker { get; set; }
        public TimeSpan EndMarker { get; set; }
        public TimeSpan Cue { get; set; }
        public bool SuppressVocals { get; set; }

        public void Stop();
        public void Pause();
        public void Play();
        public void ResetCurrentPlayTime();
        public void LoadFile(string filename);

    }
}
