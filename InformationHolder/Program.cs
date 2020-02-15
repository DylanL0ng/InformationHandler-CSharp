using System;

namespace InformationHolder
{
    class Program
    {
        static void Main(string[] args)
        {

            // Asks user for name
            writeLine("What is your name?");
            string name = Console.ReadLine().ToUpper();
            // Welcomes user
            welcomeName(name);

            // Wipes screen
            wipeScreen();

            // Asks user for age
            writeLine("How old are you?");
            double age = Math.Floor(Double.Parse((Console.ReadLine())));
            // Outputs a line dependent on age
            writeLine(determineStatus(age));

            wipeScreen();

            // Asks for favourite colour
            writeLine("What is your favourite colour out of these: Red, Green, Blue");
            string favouriteCol = Console.ReadLine().ToUpper();
            // Outputs a line dependent on favourite colour
            favColour(favouriteCol);

            wipeScreen();

            // Ask for gender
            writeLine("Finally, are you Male or Female");
            string gender = Console.ReadLine().ToUpper();

            wipeScreen();

            // Fake Loading Bar
            Loading();

            // Writes Data
            drawData(name , age, favouriteCol, gender);

            // Exits on user input
            writeLine("Press any key to exit");
            Console.ReadKey();
        }

        static void welcomeName(string arg)
        {
            Console.WriteLine("Welcome " + arg );
        }

        static string determineStatus(double age)
        {
            // Ternary operator to determine a response
            return age <= 15 ? $"Welcome you are classified as a Child, {age}" : $"Welcome you are classified as an Adult, {age}";
        }

        static void favColour(string colour)
        {
            // converts the colour to a lowercase to make it case insensitive
            string pickedColour = colour.ToLower();

            // switch statement to handle output
            switch (pickedColour)
            {
                case "green":
                    writeLine("You picked the best one");
                    break;
                case "blue":
                    writeLine("Atleast its not red");
                    break;
                case "red":
                    writeLine("Atleast its not blue");
                    break;
                default:
                    // Outputed if the user did not choose Red, Blue, Green
                    writeLine("You didn't answer correctly");

                    // Reasks the question
                    writeLine("What is your favourite colour out of these: Red, Green, Blue");
                    string favouriteCol = Console.ReadLine();
                    // Recalls this function
                    favColour(favouriteCol);
                    break;
            }
        }


        // Shorterned way to writeLine
        static void writeLine(string question)
        {
            Console.WriteLine(question);
        }

        static void Loading()
        {
            Console.WriteLine("Loading");
            Wait(1000);
            
            // Creates a for loop itterating 5 times
            for (int i = 0; i <= 5; i++)
            {
                Console.Clear();
                Console.WriteLine("*****");
                Wait(150);
                Console.Clear();
                Console.WriteLine("****");
                Wait(150);
                Console.Clear();
                Console.WriteLine("***");
                Wait(150);
                Console.Clear();
                Console.WriteLine("**");
                Wait(150);
                Console.Clear();
                Console.WriteLine("*");
            }
            Console.Clear();
            
        }

        // Draws data
        static void drawData(string name, double age, string favCol, string gender)
        {
            writeLine("Here are your details:");
            writeLine($"Name : {name}");
            writeLine($"Age : {age}");
            switch (favCol.ToLower())
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }
            writeLine($"Favourite Color : {favCol}");
            Console.ForegroundColor = ConsoleColor.White;
            writeLine($"Gender : {gender}");
        }

        // Waits for the variable amount of time in miliseconds
        static void Wait(int length)
        {
            System.Threading.Thread.Sleep(length);
        }


        static void wipeScreen()
        {
            Wait(1000);
            Console.Clear();
        }


    }
}
