using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesser
{
    class Guesser
    {

        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object

        /*Write a console application that keeps on asking the user to enter a string to guess a
        certain name. At any trial, if the user’s guess is wrong the system should print out a
        message like, “Sorry, wrong guess, please enter a new one:”, and a congratulation
        message if it is the correct name.
        There should be a maximum amount of tries; once the number of maximum guesses is reached, the
        program should inform the user that they have run out of trials and exit. To exit you can use the
        instruction: Environment.Exit(0);*/

        const int MaxTrials = 10;


        static void Main(string[] args)
        {
            /* TO DO: here is where you add your  code! */


            for (int i = 0; i < MaxTrials; i++)
            {
                Console.WriteLine("Guess the name, before you run out of trials");

                switch (Console.ReadLine())
                {
                    case "Henning":
                        Console.WriteLine("You gussed the name, the program will close after 4 seconds");
                        System.Threading.Thread.Sleep(4000);
                        Environment.Exit(0);
                        break;
                        


                    default:
                        int k = 1 + i;
                        Console.WriteLine("Sorry, wrong guess, you have used " + k + " out of " + MaxTrials + " trials");
                        
                        if (k==MaxTrials)
                        {
                            Console.WriteLine("You ran out of gusses, better luck next time, the program will close after 4 seconds");
                            System.Threading.Thread.Sleep(4000);
                        }
                        
                        break; 


                }

              




            }
        }
    }
}
