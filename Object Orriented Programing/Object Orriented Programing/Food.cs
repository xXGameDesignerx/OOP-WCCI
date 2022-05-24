using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Orriented_Programing
{
    // this class will represent all food items in our program
    internal class Food
    {
        // properties (characteristics)
        // property declaration
        // accessModifier proteryType propertyName
        public string Name;
        // flavor
        public string Flavor;
        // texture
        public string Texture;
        // tasty
        private bool IsTasty;
        // portions
        public int Portions;
        // cost
        public float Cost;
        // calories
        public int Calories;
        // ingredients
        public List<string> Ingredients;

        // methods (functions / capabilities)
        // bundled set of code that performs action on some kind of 
        // inputs and return some outputs based on these actions
        // RETURN - when something is being handed to use we use returned to us.
        // Also a function returns a string

        // constructor
        // Method that instantiates our object,
        // either based on default value or the values we provide to that method

        // (inputs, parameters) 
        // inputs are the values that we provide to a method/function in order for it to run
        // outputs are values that a method/function hands to us to use
        // (we use this term with operators)

        // method templete
        // accessModifier optionalModifier returnType methodName(inputType inputName)
        // {
        //    code to run
        // }

        // aM (access Modifiers)- same as our properties
        // oM (optional modifiers) - additional keywords that change how our methods work and can be called
        //          - static - you can thaa method without needing to create an object first
        // returnType - what TYPE of data is this method going to RETURN for us to use
        //          - void - indicates to us that the method does not return anything
        // mH (methodName) - name of the method
        // inputType InputName - variable declaration
        // code we'd like to run - code. if we have a return type,
        // we must include the 'return' keyword somewhere.

        // default constructor/empty constructor
        // Method overloading - multiple methods have the same name but different inputs
        public Food()
         {
            Name = "lasagna";
            Flavor = "Sour";
            Texture = "Hard";
            IsTasty = true;
            Portions = 4;
            Cost = 5;
            Calories = 500;
            Ingredients = new List<string>() {"pasta", "tomato sause", "lemon"}; 
         }

        public Food(string name, string flavor, string texture, bool isTasty, int portions, float cost, int calories, List<string>ingredients)
        {
            Name = name;
            Flavor = flavor;
            Texture = texture;
            IsTasty = isTasty;
            Portions = portions;
            Cost = cost;
            Calories = calories;
            Ingredients = ingredients;
        }
        // performs and action, does not require an object
        public void Eat()
        {
            Portions--; // decreases by 1
        }
        // performs and action, does not require an object
        public void Eat(int numToEat)
        {
            numToEat -= numToEat;
        }
        // performs and action, does not require an object
        public static string DisplayMessage()
        {
            return "I love food";
        }
        // returns a value, must be used on an object
        public bool IsFoodTasty()
        {
            return IsTasty;
        }
    }

}
