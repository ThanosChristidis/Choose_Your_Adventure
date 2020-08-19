using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        /*
            In this project, you’ll use logic and conditional statements to write a classic text-based Choose Your Own Adventure Game. 
            Depending on what choices your user makes, the program will have a different result. 
         */
        static void ChooseYourOwnAdventureStory()
        {
            string name;
            string noiseChoice = "";
            string doorChoice = "";
            string riddleAnswer = "";
            string keyChoice = "";

            while (noiseChoice != "NO" && noiseChoice != "YES")
            {
                
                Console.Write("\tWhat is your name?: ");
                name = Console.ReadLine();
                Console.WriteLine($"\tHello, {name}! Welcome to our story.");

                Console.WriteLine("\tIt begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?");
                Console.Write("\tType 'YES' or 'NO'.: ");
                noiseChoice = Console.ReadLine().ToUpper();
            }


            if (noiseChoice == "NO")
            {
                Console.WriteLine("Not much of an adventure if you don't leave your room!");
                Console.WriteLine("THE END.");
            }

            else if(noiseChoice=="YES")
            {
                while(doorChoice!="OPEN" && doorChoice != "KNOCK")
                {
                    Console.WriteLine("\tYou walk into the hallway and see a light coming from under a door down the hall.");
                    Console.Write("\tYou walk towards it.Do you open it or knock?Type 'OPEN' or 'KNOCK': ");
                    doorChoice = Console.ReadLine().ToUpper();
                }

                if (doorChoice == "KNOCK") 
                {   

                    while (riddleAnswer != "NOTHING")
                    {
                        Console.WriteLine("\tA voice behind the door speaks. It says, Answer this riddle:");
                        Console.WriteLine("\tPoor people have it. Rich people need it. If you eat it you die. What is it?");
                        Console.Write("\tType your answer: ");
                        riddleAnswer = Console.ReadLine().ToUpper();
                    }

                    if (riddleAnswer == "NOTHING") 
                    {
                        Console.WriteLine("\tThe door opens and NOTHING is there.You turn off the light and run back to your room and lock the door.");
                        Console.WriteLine("\tTHE END.");
                    }
                    else
                    {
                        Console.WriteLine("\tYou answered incorrectly. The door doesn't open.");
                        Console.WriteLine("\tTHE END.");
                    }
                }
                else if(doorChoice == "OPEN")
                {
                    while(keyChoice!="1" && keyChoice!="2" && keyChoice != "3")
                    {
                        Console.WriteLine("\tThe door is locked! See if one of your three keys will open it.");
                        Console.Write("\tEnter a number 1-3: ");
                        keyChoice = Console.ReadLine();
                    }

                    switch (keyChoice)
                    {
                       case "1":
                           Console.WriteLine("\tYou choose the first key. Lucky choice!The door opens and NOTHING is there.Strange...THE END.");
                       break;

                       case "2":
                            Console.WriteLine("\tYou choose the second key. The door doesn't open.THE END.");
                       break;

                       case "3":
                            Console.WriteLine("\tYou choose the third key. The door doesn't open.THE END.");
                       break;

                       default:
                            Console.WriteLine("\tPlease insert the suitable key from 1 to 3");
                       break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            ChooseYourOwnAdventureStory();
        }
    }
}
