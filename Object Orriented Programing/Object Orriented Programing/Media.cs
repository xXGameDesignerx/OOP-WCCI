using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Orriented_Programing
{
    internal class Media : IRatable
    {
        public string Title;
        public List<string> Genres;
        public double Cost;
        public double Rating;

        public void Play()
        {
            Console.WriteLine("This media slaps!");
        }
        public void ChangeTitle(string newTitle)
        {
            Title = newTitle;
        }
        public void IncreaseRating(double change)
        {
            Rating += change;
        }
        public void DecreaseRating(double change)
        {
            Rating -= change;
        }
    }
    // absstract class example using media
    /*
    internal abstract class Media
    {
        // abstract - any children class needs to
        // provide their own functionality for these methods
        // classes declared abstract cannot have objects instantiated from them
        public abstract void Play();
        // must use override in absracts in
        // and put class as abstract for it to work
        // child methods that uses Media inside Game and Movie
        public override void Play()
        {

        }
    }
    */
    internal abstract class Media_ : IRatable
    {
        public string Title;
        public List<string> Genres;
        public double Cost;
        public double Rating;

        public void Play()
        {
            Console.WriteLine("This media slaps!");
        }
        public void ChangeTitle(string newTitle)
        {
            Title = newTitle;
        }
        public void IncreaseRating(double change)
        {
            Rating += change;
        }
        public void DecreaseRating(double change)
        {
            Rating -= change;
        }
    }
    
}
