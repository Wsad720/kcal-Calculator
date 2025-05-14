using System.Diagnostics;

namespace Kcal_Calculator
{
    internal class Program
    {
        static void Main()
        {
            int kcal = 0;
            Console.WriteLine("Hello, pleas select gender: [M/W]");
            string additionalstring = Console.ReadLine();
            int additionalint;

            if (additionalstring.ToLower() == "w")
            {
                kcal = 1450;
            }
            else if(additionalstring.ToLower() == "m")
            {
                kcal = 1700;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Please write a good phrase :P");

                Console.ResetColor();

                Main();
            }

            Console.Clear();
            Console.WriteLine("What old are you?:");
            additionalint = int.Parse(Console.ReadLine());

            if(additionalint < 10)
            {
                kcal += 200;

            }
            else if(additionalint > 9 && additionalint < 20)
            {
                kcal += 150;
            }
            else if (additionalint > 19 && additionalint < 35)
            {
                kcal += 0;
            }
            else if (additionalint > 34 && additionalint < 50)
            {
                kcal -= 100;
            }
            else if (additionalint > 49)
            {
                kcal -= 200;
            }

            Console.Clear();
            Console.WriteLine("please enter from 1 to 3 level of movement ie: 1- little, 2- medium, 3 much:");

            additionalint = int.Parse(Console.ReadLine());

            if(additionalint == 1)
            {
                kcal += 0;
            }
            else if(additionalint == 2)
            {
                kcal += 400;
            }
            else if (additionalint == 3)
            {
                kcal += 700;
            }

            Console.Clear();

            Console.WriteLine("please enter your height:");

            additionalint = int.Parse(Console.ReadLine());

            if (additionalint < 150)
            {
                kcal -= 100;
            }
            else if( additionalint > 150 && additionalint < 180)
            {
                kcal += 0;
            }
            else if (additionalint > 180)
            {
                kcal += 150;
            }

            Console.Clear();

            Console.WriteLine("your daily kcal requirement: " + kcal + " kcal.");

            Console.ReadLine();


        }
    }
}
