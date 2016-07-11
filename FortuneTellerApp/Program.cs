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
            string fortune = "yes";          //condition for while statement
            string transport = "";           //variable for user transportation based on color choice
            string locale = "";               //variable that stores location based on siblings 
            Random rnd = new Random();       //random class number random number generator for retirement age
            int retire;                      //retire variable for random class storage 
            double monies = 10;              //variable to store amount of money received

           Console.WriteLine('\t'+'\t' + "Welcome to the Fortune Teller App");
            Console.WriteLine("Here all shall be revealed " + '\n');

            
                while (fortune == "yes")
                {
                    Console.WriteLine("What is your first name?");
                    string firstName = Console.ReadLine().ToLower();
                    char[] first = firstName.ToCharArray();     //converts firstName to array and splits into chars                  

                    Console.WriteLine("What is your last name?");
                    string lastName = Console.ReadLine().ToLower();
                    char[] last = lastName.ToCharArray();       //converts lastName to array and splits into chars

                    Console.WriteLine("How old are you?");
                    int age = int.Parse(Console.ReadLine());

                    if (age % 2 != 0)                 //If statement that checks if user number is odd
                    {
                        retire = rnd.Next(1, 13);     //random int from 1-13
                    }
                    else
                    {
                        retire = rnd.Next(14, 26);    //randomn int from 14-26
                    }

                    Console.WriteLine("What month were you born?");
                    string month = Console.ReadLine().ToLower();
                    char[] birthmonth = month.ToCharArray();    //converts month to array and splits into chars

                    //contain method checks last and first array for same char from birthmonth array                
                    if (last.Contains(birthmonth[0]) == true || first.Contains(birthmonth[0]) == true)
                    {
                        monies = 1000;

                    }
                    else if (last.Contains(birthmonth[1]) == true || first.Contains(birthmonth[1]) == true)
                    {
                        monies = 20000;
                    }
                    else if (last.Contains(birthmonth[2]) == true || first.Contains(birthmonth[2]) == true)
                    {
                        monies = 1000000;
                    }
                    else
                    {
                        monies = 5;
                    }




                    Console.WriteLine("What is your favorite color in ROYGBIV? Type 'help' if you do not now the ROYGBIV scale ");
                    string color = Console.ReadLine().ToLower();

                    if (color == "help")   //if user types'help' 
                    {
                        Console.WriteLine("ROYGBIV makes up the colors of the rainbow Red, Orange, Yellow, Green, Blue, Indigo, and Violet");

                        Console.WriteLine('\n' + "What is your favorite color in ROYGBIV? Type 'help' if you do not understand");
                        color = Console.ReadLine().ToLower();

                        switch (color)  //switch statement that adds a argument to transport based on color
                        {
                            case "red":
                                transport = "Porsche";
                                break;
                            case "orange":
                                transport = "Speed Boat";
                                break;
                            case "yellow":
                                transport = "Magic School Bus";
                                break;
                            case "green":
                                transport = "Tank";
                                break;
                            case "blue":
                                transport = "Submarine";
                                break;
                            case "indigo":
                                transport = "Dragon";
                                break;
                            case "violet":
                                transport = "Space Ship";
                                break;
                            default:
                                Console.WriteLine("ROYGBIV stands for the colors of the rainbow. Red, orange, yellow, green, blue, indigo, and violet");

                                Console.WriteLine("What is your favorite color in ROYGBIV? Type 'help' if you do not understand ");
                                color = Console.ReadLine().ToLower();
                                break;

                        }
                    }
                    else
                    {
                        switch (color)
                        {
                            case "red":
                                transport = "Porsche";
                                break;
                            case "orange":
                                transport = "Speed Boat";
                                break;
                            case "yellow":
                                transport = "Magic School Bus";
                                break;
                            case "green":
                                transport = "Tank";
                                break;
                            case "blue":
                                transport = "Submarine";
                                break;
                            case "indigo":
                                transport = "Dragon";
                                break;
                            case "violet":
                                transport = "Space Ship";
                                break;
                            default:
                                Console.WriteLine("ROYGBIV stands for the colors of the rainbow. Red, orange, yellow, green, blue, indigo, and violet");

                                Console.WriteLine('\n' + "What is your favorite color in ROYGBIV? Type 'help' if you do not understand ");
                                color = Console.ReadLine().ToLower();
                                break;

                        }

                    }



                    Console.WriteLine("How many siblings do you have?");
                    int sibs = int.Parse(Console.ReadLine());

                    switch (sibs)         //switch statement that stores argument to variable locale based on sibs amount 
                    {
                        case 0:
                            locale = "Tropical Island Paradise";
                            break;

                        case 1:
                            locale = "a Haunted Mansion";
                            break;

                        case 2:
                            locale = "a Castle";
                            break;

                        default:
                            locale = "a Space Shuttle";
                            break;
                    }






                    Console.WriteLine(firstName + " " + lastName + " will retire in " + retire + " years with $" + monies + " in the bank, a vacation home in " + '\n' + locale + " traveling in style with a " + transport);

                    Console.WriteLine("Would you care to read another fortune?");
                    fortune = Console.ReadLine().ToLower();
                }
            
        }
    }
}
