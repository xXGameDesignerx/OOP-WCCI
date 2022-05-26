using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Orriented_Programing
{
    internal class Game : Media
    {
        // properites and methods
        // these below are variables
        public int Copies;
        public bool IsCoop;
        public int TimePlayed;
        // this is a perfect opportunity for a child class
        // - properties that exist on some but not all
        public int MaxLevel;
        public List<string> Inventory;

        // constructors, how can we create this object?
        /*
        public Game(string title)
        {
            // this.Title = Title;
            Title = title;
        }
        */
        // methods, what actions can we do with this object?
        public void Play()
        {
            Console.WriteLine("How many hours did you play?");
            int hours = Int32.Parse(Console.ReadLine());
            TimePlayed += hours; 
        }
        public void Play(int hours)
        {
            TimePlayed += hours;
        }
    }
    internal abstract class Game_ : Media_
    {
        public int Copies;
        public bool IsCoop;
        public int TimePlayed;

        public int MaxLevel;
        public List<string> Inventory;

        public abstract void Play()
        {
            Console.WriteLine("How many hours did you play?");
            int hours = Int32.Parse(Console.ReadLine());
            TimePlayed += hours;
        }
        public abstract void Play(int hours)
        {
            TimePlayed += hours;
        }
    }
}
