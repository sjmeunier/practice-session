using PracticeSession.Core.Enums;
using System;

namespace PracticeSession.Core.Models
{
    public class PresetData
    {
        public string Name { get; set; }

        public float Volume { get; set; }
        public float Tempo { get; set; }
        public float Pitch { get; set; }

        public TimeSpan Cue { get; set; }
        public bool Loop { get; set; }
        public TimeSpan StartMarker { get; set; }
        public TimeSpan EndMarker { get; set; }


        public float LoEqValue { get; set; }
        public float MedEqValue { get; set; }
        public float HiEqValue { get; set; }

        public TimeStretchProfile TimeStretchProfile { get; set; }

        public bool SuppressVocals { get; set; }

        public InputChannelMode InputChannelMode { get; set; }

        public bool SwapLeftRightSpeakers { get; set; }


        public PresetData()
        {
            Cue = TimeSpan.Parse("00:00:00");
            Name = "";
            EndMarker = TimeSpan.Parse("00:00:00");
            HiEqValue = 0F;
            InputChannelMode = InputChannelMode.Both;
            LoEqValue = 0F;
            Loop = false;
            MedEqValue = 0F;
            Pitch = 0F;
            SuppressVocals = false;
            StartMarker = TimeSpan.Parse("00:00:00");
            SwapLeftRightSpeakers = false;
            Tempo = 1F;
            TimeStretchProfile = null;
            Volume = 0.75F;
        }
    }
}
