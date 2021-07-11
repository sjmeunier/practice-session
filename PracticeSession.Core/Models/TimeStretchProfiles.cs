using System.Collections.Generic;

namespace PracticeSession.Core.Models
{
    public class TimeStretchProfiles
    {
        public static readonly Dictionary<string, TimeStretchProfile> Profiles =
            new Dictionary<string, TimeStretchProfile>()
            {
                {
                    "AutomaticAA",
                    new TimeStretchProfile()
                    {
                        Id = "AutomaticAA",
                        UseAAFilter = true,
                        AAFilterLength = 128,
                        SeekWindow = 0,
                        Sequence = 0,
                        Overlap = 0,
                        Description = "Automatic with AA Filter"
                    }
                },
                {
                    "RockPop1",
                    new TimeStretchProfile()
                    {
                        Id = "RockPop1",
                        UseAAFilter = true,
                        AAFilterLength = 192,
                        SeekWindow = 90,
                        Sequence = 30,
                        Overlap = 30,
                        Description = "Rock/Pop 1 with Strong AA Filter"
                    }
                },
                {
                    "RockPop2",
                    new TimeStretchProfile()
                    {
                        Id = "RockPop2",
                        UseAAFilter = true,
                        AAFilterLength = 64,
                        SeekWindow = 120,
                        Sequence = 60,
                        Overlap = 60,
                        Description = "Rock/Pop 2 with Soft AA Filter"
                    }
                },
                {
                    "SpeechAA",
                    new TimeStretchProfile()
                    {
                        Id = "SpeechAA",
                        UseAAFilter = true,
                        AAFilterLength = 128,
                        SeekWindow = 40,
                        Sequence = 10,
                        Overlap = 10,
                        Description = "Speech 1 with AA Filter"
                    }
                },
                {
                    "Optimum",
                    new TimeStretchProfile()
                    {
                        Id = "Optimum",
                        UseAAFilter = true,
                        AAFilterLength = 128,
                        SeekWindow = 80,
                        Sequence = 20,
                        Overlap = 20,
                        Description = "Optimum for Music and Speech"
                    }
                }
            };

        public static string DefaultProfile = "Optimum";
    }
}
