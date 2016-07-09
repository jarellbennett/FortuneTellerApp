using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fortune = "yes";
            Console.WriteLine('\t' + "Welcome to the Fortune Teller App");
            Console.WriteLine("Here all will be revealed " + '\n');

            while(fortune == "yes")
            {
                Console.WriteLine("What is your first name?");
                string firstName = Console.ReadLine();

                Console.WriteLine("What is your last name?");
                string lastName = Console.ReadLine();

                Console.WriteLine("How old are you?");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("What month were you born?");
                string month = Console.ReadLine();

                Console.WriteLine("What is your favorite color in ROYGBIV? Type 'help' if you do not now the ROYGBIV scale ");
                string color = Console.ReadLine().ToLower();

                if (color == "help")
                {
                    Console.WriteLine("ROYGBIV makes up the colors of the rainbow Red, Orange, Yellow, Green, Blue, Indigo, and Violet");
                }
                else
                {
                    switch (color)
                    {
                        case "red":
                            
                            break;
                        case "orange":
                            break;
                        case "yellow":
                            break;
                        case "green":
                            break;
                        case "blue":
                            break;
                        case "indigo":
                            break;
                        case "violet":
                            break;
                        default:
                            Console.WriteLine("ROYGBIV stands for the colors of the rainbow. Red, orange, yellow, green, blue, indigo, and violet");
                            break;

                    }

                }
                


                Console.WriteLine("How many siblings do you have?");
                int sibs = int.Parse(Console.ReadLine());



                





                Console.WriteLine(firstName + " " + lastName + " will retire in " +  "");
                Console.WriteLine("Would you care to read another fortune?");
                fortune = Console.ReadLine().ToLower();
            }
        }
    }
}
