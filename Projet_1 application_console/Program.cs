using System;
using System.Security.Cryptography;
using System.Text;


namespace Projet_1_application_console
{
    class Program
    {
        
        static void Main(string[] args)
        {

            {
                // Part A: create three-item tuple.
                Tuple<int, string, bool> tuple = new Tuple<int, string, bool>(1, "cat", true);
                // Part B: access tuple properties.
                if (tuple.Item1 == 1)
                {
                    Console.WriteLine(tuple.Item1);
                }
                if (tuple.Item2 == "dog")
                {
                    Console.WriteLine(tuple.Item2);
                }
                if (tuple.Item3)
                {
                    Console.WriteLine(tuple.Item3);
                }
            }
        }

    }
}


        /* string response, input;

                    response = "trois";

                    Console.WriteLine($" Question 1 : ");
                    input = (Console.ReadLine());

                    do
                    {
                        if (input == response)

                        {
                            input = (Console.ReadLine()).ToUpper();
                            Console.WriteLine($" Bonne réponse = {System.Drawing.Color.Green}");

                        }
                    }
                    while (input != response);
                    {
                        input = (Console.ReadLine()).ToUpper();
                        Console.WriteLine($" Mauvaise réponse = {System.Drawing.Color.Red}");
                    }*/


            

        

            
        
    
