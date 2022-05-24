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


//Classes
//object types.
//Classes outline what properties and methods a particular object will have at its fingertips.


//Classes vs. objects

