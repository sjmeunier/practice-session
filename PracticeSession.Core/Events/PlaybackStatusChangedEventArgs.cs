using System;
using PracticeSession.Core.Enums;

namespace PracticeSession.Core.Events
{
    public class PlaybackStatusChangedEventArgs : EventArgs
    {
        public PlaybackStatusChangedEventArgs(PlaybackStatus playbackStatus)
        {
            PlaybackStatus = playbackStatus;
        }

        public PlaybackStatus PlaybackStatus { get; private set; }
    }
}
