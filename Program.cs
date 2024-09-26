using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
// start with introduction on how to play
Console.WriteLine("WELCOME TO JERRY'S JOURNEY! In this short text-based rpg you click the \"ENTER\" key to move onto the next line. " +
"MAKE SURE TO ANSWER THE NPC'S QUESTIONS! (marked with ???: or \"Jerry:\")");
//add console.readline between lines as a "buffer" so all the text isn't thrown at the player all at once
Console.ReadLine();
// set-up setting/atmosphere 
Console.WriteLine("You walk down a dirt path, hungry and tired");
Console.ReadLine();
Console.WriteLine("you look up at rustic orange sunset and see billowing smoke in the distance");
Console.ReadLine();
Console.WriteLine("\"There must be civilization near, just a bit further\" you think to yourself");
Console.ReadLine();
Console.WriteLine("finally after lord knows how long you make it to the orgin of the smoke, it's a random fire?");
Console.ReadLine();

// "Jerry's" first line
Console.WriteLine("???:\"Hey you there! Do you know where you are?!\"");

// first user interaction
string input = Console.ReadLine();

// Repeat what was said to the user
Console.Write("???: Did you really just say \"");
Console.Write(input);
Console.Write("\"");
// 2nd interaction/optional response from the user, still works if you just click "enter"
string input2 = Console.ReadLine();

Console.ReadLine();
Console.WriteLine("???:\"Well I'll be darned, I never would've expected a tourist around these parts\"");
Console.ReadLine();

//forced user dialouge (no need to type it themselves)
Console.WriteLine("You:\"I'm not a tourist, I'm just lost\"");
Console.ReadLine();

// ask what month they got lost (in numbers)
// convert the input string as a number to do math with it
Console.Write("???:\"lost? since when? (month #)\"");
// third interaction
string input3 = Console.ReadLine();

int usertime = int.Parse(Console.ReadLine());

// uses the calender on users computer to figure out what month it is
int currentday = DateTime.Now.Month;
// uses inputs and math to create a variable that evauluate how many "months" the user has been lost
int number = currentday - usertime;

// finally outputs a response using the "number" variable that I created 
Console.WriteLine($"So you've been here for {number} months?");
Console.ReadLine();
Console.WriteLine("what's your name anyway?");

// creates a name based on user input
string username = Console.ReadLine();
//uses string interpolation to relay what the user typed in as their name
Console.WriteLine($"Jerry: \"Well nice to meet you, {username}, I'm Jerry. I've lived in here for years now.\"");
Console.ReadLine();
Console.WriteLine("Jerry: \" I must warn you though, be careful of the woods ahead, strange things are known to happen at night\"");
Console.ReadLine();
Console.WriteLine("Will you go into the woods?");
// final decision that results in one of 2 endings 

var intothewoods = Console.ReadLine();
{
    
    if (intothewoods == "yes")
    {
        Console.WriteLine("Jerry: \"Be careful traveller! I can't promise that i'll help you in there!\"" +
            "Jerry kills you.");  
    }
    else if (intothewoods != "yes")
    {
        Console.WriteLine($"Jerry:\"Smart choice, that place is scary.\"");
    }
}
Console.ReadLine();
// thank you :)
Console.WriteLine("Thanks for playing JERRY'S JOURNEY! I hope you had fun"); 
