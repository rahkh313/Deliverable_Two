using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_2_Fun_Recommendations_Raheel_Khan
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int response;
            int people;
            char doAgain;
            int[] activity; 
            activity = new int [3];
            string text;
            bool repeat1 = true;

            while (repeat1 == true)
            {

                Console.WriteLine("Hello user, what are you in the mood for?");
                Console.WriteLine("Here are your options (Type value 1 through 4):");
                Console.WriteLine("1). Action");
                Console.WriteLine("2). Chill Times");
                Console.WriteLine("3). Danger");
                Console.WriteLine("4). Good Food");
                response = Convert.ToInt32(Console.ReadLine());
                                
                Console.WriteLine("How many people are you bringing with you");

                people = Convert.ToInt32(Console.ReadLine());

                if (response == 1 && people == 0)
                {
                    Console.WriteLine("okay if you're in the mood for action, then you should go to Stock Car Racing and travel in sneakers");
                }

                if (response == 1 && people >=1 && people <= 4)
                {
                    Console.WriteLine("okay if you're in the mood for action, then you should go to Stock Car Racing and travel in sedan");
                }

                if (response == 1 && people >= 5 && people <= 10)
                {
                    Console.WriteLine("okay if you're in the mood for action, then you should go to Stock Car Racing and travel in a Volkswagen bus");
                }

                if (response == 1 && people >= 11)
                {
                    Console.WriteLine("okay if you're in the mood for action, then you should go to Stock Car Racing and travel in a an airplane");
                }
               


                if (response == 2 && people == 0)
                {
                    Console.WriteLine("okay if you're in the mood for Chilling, then you should go to Hiking and travel in sneakers");
                }

                if (response == 2 && people >=1 && people <= 4)
                {
                    Console.WriteLine("okay if you're in the mood for Chilling, then you should go to Hiking and travel in sedan");
                }

                if (response == 2 && people >= 5 && people <= 10)
                {
                    Console.WriteLine("okay if you're in the mood for Chilling, then you should go to Hiking and travel in a Volkswagen bus");
                }

                if (response == 2 && people >= 11)
                {
                    Console.WriteLine("okay if you're in the mood for Chilling, then you should go to Hiking and travel in a an airplane");
                }
              


                if (response == 3 && people == 0)
                {
                    Console.WriteLine("okay if you're in the mood for Danger, then you should go skydiving  and travel in sneakers");
                }

                if (response == 3 && people >=1 && people <= 4)
                {
                    Console.WriteLine("okay if you're in the mood for Danger, then you should go skydiving and travel in sedan");
                }

                if (response == 3 && people >= 5 && people <= 10)
                {
                    Console.WriteLine("okay if you're in the mood for Danger, then you should go skydiving and travel in a Volkswagen bus");
                }

                if (response == 3 && people >= 11)
                {
                    Console.WriteLine("okay if you're in the mood for Danger, then you should go skydiving and travel in a an airplane");
                }
                

                if (response == 4 && people == 0)
                {
                    Console.WriteLine("okay if you're in the mood for Good Food, then you should go to Taco Bell and travel in sneakers");
                }

                if (response == 4 && people >=1 && people <= 4)
                {
                    Console.WriteLine("okay if you're in the mood for Good Food, then you should go to Taco Bell and travel in sedan");
                }

                if (response == 4 && people >= 5 && people <= 10)
                {
                    Console.WriteLine("okay if you're in the mood for Good Food, then you should go to Taco Bell and travel in a Volkswagen bus");
                }

                if (response == 4 && people >= 11)
                {
                    Console.WriteLine("okay if you're in the mood for Good Food, then you should go to Taco Bell and travel in a an airplane");
                }
                else if(response > 4)
                {
                    Console.WriteLine("I'm sorry the input was not understood, please try again");
                    
                }

                Console.WriteLine("Would you like to run this program again? (Y or N)");
                doAgain = Convert.ToChar(Console.ReadLine());

                if (doAgain == 'y' || doAgain == 'Y')
                {
                    repeat1 = true;

                }

                else
                {
                    Console.WriteLine("Good Bye");
                    repeat1 = false;
                }









            }
        }
    }
}
