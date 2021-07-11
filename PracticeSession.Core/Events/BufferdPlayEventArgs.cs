using System;

namespace PracticeSession.Core.Events
{
    /// <summary>
    /// Custom Event Arguments class that is used by PlayPositionChanged event
    /// </summary>
    public class BufferedPlayEventArgs : EventArgs
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="playTime"></param>
        public BufferedPlayEventArgs(TimeSpan playTime)
        {
            this.PlayTime = playTime;
        }

        /// <summary>
        /// The current PlayTime of the buffer being played
        /// </summary>
        public TimeSpan PlayTime;
    }
}
