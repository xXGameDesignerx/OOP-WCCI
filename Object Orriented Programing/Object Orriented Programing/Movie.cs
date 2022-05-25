﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Orriented_Programing
{
    internal class Movie : Media
    {
        public decimal Rating;
        public List<string> Cast;
        public List<string> Crew;
        public double Duration; // in seconds
        public bool AwardWinning;
        public bool InTheatres;

        public void Play()
        {
            Console.WriteLine("Wow, I wish Tom Cruise was in this!");
        }
    }
}
