using System;
using System.Collections.Generic;

namespace Projet_1_application_console
{
    class Program
    {
        private static List<KeyValuePair<string, string>> questions = new List<KeyValuePair<string, string>>
    {
        new KeyValuePair<string,string>("-Qu'est ce qu'une boucle", "ReponseA"),
        new KeyValuePair<string,string>("-Qu'est ce qu'un object", "ReponseB"),
        new KeyValuePair<string,string>("-Qu'est ce qu'une méthode", "ReponseC"),
        new KeyValuePair<string,string>("-Qu'est ce qu'une variable", "ReponseD"),
        new KeyValuePair<string,string>("-Qu'est ce qu'une énumération?", "ReponseE"),
    };
        

                
                

        static void Main(string[] args)
        {

            {

                Console.WriteLine("Ecrit ton nom et ton prénom :) ");
                string name1 = Console.ReadLine();
                Console.WriteLine($"Bonjour {name1}, le test va commencer, Bonne chance ! ");


                var questions = ShuffleQuestions();

                foreach (var question in questions)
                {
                    bool done = false;
                    while (!done)
                    {
                        Console.WriteLine(question.Key);

                        
                        string a = Console.ReadLine();

                        if (a == question.Value)
                        {
                            Console.WriteLine("It's True \n*Next Question is:");
                            done = true;
                        }
                        else
                            Console.WriteLine("It's False \n*Sorry ");
                    }
                }

                Console.ReadLine();
            }

             IEnumerable<KeyValuePair<string, string>> ShuffleQuestions()
            {
                var list = questions;
                var random = new Random();
                int items = list.Count;
                while (items > 1)
                {
                    items--;
                    int nextItem = random.Next(items + 1);
                    var value = list[nextItem];
                    list[nextItem] = list[items];
                    list[items] = value;
                }

                return list;
            }
        }

    }
}


/*   List<string> question = new List<string>();

   question.Add($"Question 1 : ... ");
   question.Add($"Question 2 : ... ");
   question.Add($"Question 3 : ... ");
   question.Add($"Question 4 : ... ");
   question.Add($"Question 5 : ... ");
   question.Add($"Question 6 : ... ");
   question.Add($"Question 7 : ... ");
   question.Add($"Question 8 : ... ");
   question.Add($"Question 9 : ... ");
   question.Add($"Question 10 : ... ");

   //Question1 : 
   const string R1 = "toto";
   const string R2 = "tata";
   const string R3 = "titi";
   const string R4 = "tutu";

   List<string> response = new List<string>();

   response.Add($" 1 : Tapez 1: {R1} \n2 :{R2} \n3 :{R3} \n4: {R4} ");
   response.Add($" 2 : ... ");
   response.Add($" 3 : ... ");
   response.Add($" 4 : ... ");
   response.Add($" 5 : ... ");
   response.Add($" 6 : ... ");
   response.Add($" 7 : ... ");
   response.Add($" 8 : ... ");
   response.Add($" 9 : ... ");
   response.Add($" 10 : ... ");




   //question.ForEach(Console.WriteLine); */






