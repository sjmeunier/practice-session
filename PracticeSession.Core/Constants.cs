namespace PracticeSession.Core
{
    public class Constants
    {
        public const string MP3Extension = ".mp3";
        public const string M4AExtension = ".m4a";
        public const string WAVExtension = ".wav";
        public const string OGGVExtension = ".ogg";
        public const string FLACExtension = ".flac";
        public const string AIFFExtension = ".aiff";

        public const int BusyQueuedBuffersThreshold = 3;

        public const int BufferSamples = 5 * 2048; // floats, not bytes
    }
}
