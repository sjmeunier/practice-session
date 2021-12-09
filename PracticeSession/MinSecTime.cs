using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeSession
{
    public class MinSecTime
    {
        public int Minutes { get; set; }
        public double Seconds { get; set; }

        public MinSecTime(double totalSeconds)
        {
            Minutes = (int)totalSeconds / 60;
            Seconds = totalSeconds - (Minutes * 60);
        }
    }
}
