using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Timers;

namespace AsmaPojetConsoleQuiz
{
    class Program
    {
        
        private static System.Timers.Timer aTimer;
       
       


        static void Main(string[] args)
        {
            int score = 0;
            List<string> bonReponse = new List<string>();




            Dictionary<string, Dictionary<string,bool>> question = new Dictionary<string, Dictionary<string, bool>>();
            question.Add("question1", new Dictionary<string, bool>() {
   
               { "java", true},
               { "c#", false},
               { "C", false  },



             }) ;
            question.Add("question2", new Dictionary<string, bool>() {


             { "c", true},
             { "B", false },
             { "orienté objet", false},



        });





            foreach (KeyValuePair<string, Dictionary<string, bool>> group in question)
            {

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
               
                    Console.WriteLine("|________________________________________________________|");
                
               
                    
                Console.WriteLine($"|                   {group.Key}                              ");



               


                int i = 1;
                while (i<3) { 
                foreach (KeyValuePair<string, bool> member in group.Value)
                {
                    Console.WriteLine("|-----------------------------------------------------|");
                    Console.WriteLine($"  {i} - {member.Key}                                  ");
                      i++;


                }
                }
                Console.WriteLine("|-----------------------------------------------------|");
                Console.WriteLine("|   Ta reponse:                                       |");
                string choix = Console.ReadLine();
                bool p;
                Console.WriteLine("|                                                     |");

                Console.WriteLine("|_____________________________________________________|");
                Console.WriteLine("                                                       ");
                Console.ResetColor();


                // On récupère juste les clefs.
                Dictionary<string, bool>.KeyCollection myKeyCollection = group.Value.Keys;
            
               bool output;
                if (group.Value.TryGetValue(choix, out output) == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Bonne réponse");
                    Console.ForegroundColor = ConsoleColor.White;
                    bonReponse.Add(choix);
                    score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Mauvais réponse");
                    Console.ForegroundColor = ConsoleColor.White;
                 }
                
 
            }

            Console.WriteLine("Votre Score est " + score);
            foreach (string l in bonReponse)
            {
                Console.WriteLine("les bon réponses que vous avez choisi sont : ");
                Console.WriteLine(l);
            }



          

        }
    }
}
