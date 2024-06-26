﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Race
{
    public class Lap
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Lap(int min, int sec)
        {
            Minutes = min;
            Seconds = sec;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1:00}", Minutes,Seconds);
        }

        public int getTimeInSecunds() 
        {
            return Minutes * 60 + Seconds;
        }

    }
}
