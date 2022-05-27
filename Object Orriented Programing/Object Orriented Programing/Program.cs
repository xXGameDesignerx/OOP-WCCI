// using statements
// imports classes and functionality from other documents
using Object_Orriented_Programing;


Console.WriteLine("Hello, World!");

//OOP
//Object Orriented Programing
//4 pillars of OOP - Abstraction, Polymorphism, inheritance, encapsulation
//outline classes and objects at a macro level. Also outlines the features and relationships of clases and objects.
//objects: tangale items we can use/create. Also instances of classes.
//instances: objects are specific examples of classes.
//Properties: objects that are refrenced based on specific characteristics
//Method: functions used and manipulate the characteristics of the specific object.
//difference between methods and properties: both use dot operator, but properties use a parentheses after the method name. Methods do not use parentheses.
// property: ex. names.Count;
// method: ex. names.MyMethod();

// Main Method
int num = 15;
num++;
Console.WriteLine(num);
//Classes
//object types.
//Classes outline what properties and methods a particular object will have at its fingertips.
// this is where we provide specific food
//instance of the food class
// instatiation -. we create food object
// instance is an example of a food object

Food garfield = new Food();
Console.WriteLine(garfield.Name);
Console.WriteLine("What are you eating?");
string input = Console.ReadLine();
Food davis = new Food(input, "salty", "soft", true, 2, 7, 200, new List<string>{"rice", "seaweed", "fish"});
Console.WriteLine(davis.Portions);
// default way
davis.Eat();
// overloading way
davis.Eat(2);
Console.WriteLine(davis.Portions);
//static method
Console.WriteLine(Food.DisplayMessage());
// returning a private bool type
Console.WriteLine(davis.IsFoodTasty());


//Classes & Objects
// strongly typed programing language
//types[] variableName = ...
//          from 0 to 8
//          0   to    length - 1
string[] names = new string[9]; // creates an empty array with 9 slots

// names[i] is accessing the value at index i
// variable has a name and a value, array items have indexes and values
//              0, 1, 2, 3, 4, 5
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 }; // creates an list with items already in it
Console.WriteLine(numbers.Count);

// example with for loop and array
// 99.9% of all for lops will look almost identical to this.
// if using strings use narableName.Length ex: names.Length
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(i);
    Console.WriteLine(names[i]); // looping and print every item in the array
}

numbers.RemoveAt(3); // removes the fourth item in our list

// example with while loop and list
while (numbers.Count > 0)
{
    Console.WriteLine(numbers[0]); // prints the first item in the list
    numbers.RemoveAt(0);  // removes the first item in the list
}
Console.WriteLine(numbers.Count);

// strings can be thought of as character arrays
string str = "string";
// string -> 's' 't' 'r' 'i' 'n' 'g'
char c = str[3];

// Encapsulation in a sense that loz replaces the need for
// 3+ individual variables
//game class
//option 1
/*
Game loz = new Game();
Console.WriteLine("How many hours did you play?");
int hours = Int32.Parse(Console.ReadLine());
loz.Play(hours);
*/
//option 2
Game loz = new Game();
loz.Play();

// movie class
Movie sw = new Movie();
sw.Play();

sw.Title = "Star Wars";
loz.ChangeTitle(sw.Title);
sw.ChangeTitle("Star Wars: The Darkness");

// Polymorphism
// *many forms* 

Media med = new Media();
med = new Game(); // a game is transforming in a more genaric 'media' object
med.Title = "Wow!";
Console.WriteLine(med.GetType());

//Game game = new Media(); children cannot neccessarily hold parents


// OOP 4 pillars - APIE
// enhance what we can do with objects
// key features that c# and its classes implement

// Abstraction
// boiling a class/object down to its key features
// creating a generalized class over a specific one
// oreder is parent > children > instances
// take what is silmilar from both for a parent class
// ex: food is a parent class of lasagna/spaghetti

// Polymorphism
// idea child can act like parents
// we can treat a game like media
// ex: List<media> - this can contains games and movies
// ex: media obj = new game();


// Inheritence
// this uses : <- colon
// creating a child class from a parent class
// get access to a parent class's prperties and methods
// .... class : parent class
// child class can do everything the parent class can,
// but the parent class can not do what child class can.
// ex: media > both game and movie
// example:
// internal class Movie : Media
// {
//    // code goes in here
// }

// Encapsulation
// objects are more than the sum of its parts
// hiding irrelevent info from our programs
// classes wrap up variables 
//                         - variable/them - properies
// access modifiers hide them
// grouping variables together into one object

// Inferface
// console app that acts like a media collection
List<Media> collection = new List<Media>(); // list of all media objects

// if we want the user to look at the collection multiple times
// using while loop
bool isRunning = true;
while(isRunning)
{
    Console.Clear();
    Console.WriteLine("What type of media would you like to add to the collection?");
    Console.WriteLine("1 - Game \n2 - Movie");
    Console.WriteLine("3 - Display Media \n4 - Clasify Media \n5 - End Program");
    int selection = Int32.Parse(Console.ReadLine());
    switch (selection)
    {
        case 1:
            Game exampleGame = new Game();
            Console.WriteLine("what is the name of your game?");
            string gameTitle = Console.ReadLine();
            exampleGame.ChangeTitle(gameTitle);
            exampleGame.Play();
            collection.Add(exampleGame);
            break;
        case 2:
            Console.Clear();
            Movie exampleMovie = new Movie();
            Console.WriteLine("What is the name of your movie?");
            string movieTitle = Console.ReadLine(); 
            exampleMovie.ChangeTitle(movieTitle);
            collection.Add(exampleMovie);
            break;
        case 3:
            Console.Clear();
            Console.WriteLine(collection.Count);
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            foreach (Media media in collection)
            {
                if(media.GetType() == typeof(Game))
                {
                    Game gameFromShelf = (Game)media; // type casing
                    Console.WriteLine("Title: " + gameFromShelf.Title + 
                        " - Hours Played: " + gameFromShelf.TimePlayed + " - Game");
                }
                else if(media.GetType() == typeof(Movie))
                {
                    Console.WriteLine("Title: " + media.Title + "- Movie");
                }
                else
                {
                    Console.WriteLine();
                }

            }
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            break;
        // enum example
        case 4:
            Console.WriteLine("What movie would you like to classify?");
            int inputM = Int32.Parse(Console.ReadLine());
            Media FromCollection = collection[inputM];
            Console.WriteLine("What genre is this piece of media?");
            Console.WriteLine();
            inputM = Int32.Parse(Console.ReadLine());
            FromCollection.ClassifyMedia(inputM);
            Console.WriteLine("Press any key to continue.");
            Console.ReadLine();
            break;
        case 5:
            isRunning = false;
            break;
    }
}

// dictionary syntax and examples
// type name = value;
// <key, value> types
// any type of key we used can be used in a dictionary
Dictionary<Movie, string> movieDirectors = new Dictionary<Movie, string>();
//variable declaration, assignemnet, property assignment 
Movie DrStrange = new Movie();
DrStrange.Title = "Dr Strange and the Multiverse of Madness";

movieDirectors.Add(DrStrange, "Sam Raimi"); // key-value-pair
Console.WriteLine(movieDirectors[DrStrange]); // acessing a value for a given key
movieDirectors[DrStrange] = "Ted Rimi"; // update the value of our KVP(key-value-pair)
