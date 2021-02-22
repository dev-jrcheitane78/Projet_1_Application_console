using System;
using System.Collections.Generic;

namespace Projet1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]>questionAnswer = new List<string[]>();
        

        //Liste des questions et réponses, la bonne réponse est toujours la réponse 4
        string[] items1 = {"Question 1"};
        string[] items2 = {"Réponse 1"};
        string[] items3 = {"Réponse 2"};
        string[] items4 = {"Réponse 3"};
        string[] items5 = {"Vrai"};

        string[] items6 = { "Question 2" };
        string[] items7 = { "Réponse 1" };
        string[] items8 = { "Réponse 2" };
        string[] items9 = { "Réponse 3" };
        string[] items10 = { "vrai" };

            //Pose les 10 questions, et calcul le score sur 10
            int i = 0;
            while(i <2) 
            {


                Console.WriteLine("Test en C#");
                Console.WriteLine(items1[0]);
                string answer = Console.ReadLine();
                    if (answer == "vrai")
                    {
                        int result = +1;
                        i++;
                        //Affiche le résultat et i
                        Console.WriteLine("result = " + result + ", i = " + i);
                    }

                    else
                    {
                        //Anonce la fin du test et donne le résultat
                        Console.WriteLine("Fin du test, votre résultat est de /10");
                    }
            }
        }
        }
    }

