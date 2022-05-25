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


// Inheritence


// Encapsulation
// objects are more than the sum of its parts
// hiding irrelevent info from our programs
// classes wrap up variables 
//                         - variable/them - properies
// access modifiers hide them
// grouping variables together into one object

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