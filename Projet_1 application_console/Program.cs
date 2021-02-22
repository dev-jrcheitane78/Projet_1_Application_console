using System;
using System.Collections.Generic;

namespace Projet_1_application_console
{
    class Program
    {
        
        static void Main()

        {
           /* Dictionary<string, string> QuestionsReponse = new Dictionary<string, string>();
            QuestionsReponse.Add("Le mot string est un : " , "chaine de caractere");
            QuestionsReponse.Add("Le mot integer est un : ", "nombre");
            QuestionsReponse.Add("Le mot float est un : "  , "nombre a virgule");
            QuestionsReponse.Add("Le mot bool est un : "   , "Boolean");
            QuestionsReponse.Add("Le mot char est un : "   , "charactère");*/

            List<Tuple< (int, string), (string, bool), (string,bool), (string, bool), (string, bool)>> ResponseFalse = new List<Tuple<(int, string), (string, bool), (string, bool), (string, bool), (string, bool)>> ();
            ResponseFalse.Add(new Tuple<(int, string), (string, bool), (string, bool), (string, bool), (string, bool)>((1, "Qu'est ce qu'une variable"), ("bravo", true), ("refalse", false), ("rerefalse", false), ("rerererefalse", false)));
            ResponseFalse.Add(new Tuple<(int, string), (string, bool), (string, bool), (string, bool), (string, bool)>((1, "Qu'est ce qu'une constante"), ("bravo", true), ("refalse", false), ("rerefalse", false), ("rerererefalse", false)));

            void affichageTable ()
            {
                

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" _____________________________________________________ ");
                Console.WriteLine($"| {ResponseFalse[1]}                         |");
                Console.WriteLine("|-----------------------------------------------------|");
                Console.WriteLine("|  A. Je sais pas                 B. Ca marche bien   |");
                Console.WriteLine("|                                                     |");
                Console.WriteLine("|  C. Le formateur est cool       D. Me soul pas...   |");
                Console.WriteLine("|                                                     |");
                Console.WriteLine("|-----------------------------------------------------|");
                Console.WriteLine("|                                                     |");
                Console.WriteLine("|   Ta reponse:                                       |");
                Console.WriteLine("|                                                     |");
                Console.WriteLine("|_____________________________________________________|");
                Console.WriteLine("                                                       ");

                string valueUser = Console.ReadLine();
            }

            affichageTable();
  
            Console.ResetColor();

            

            Console.Read();
        }
    }
        
}
