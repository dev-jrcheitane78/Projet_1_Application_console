using System;
using System.Collections.Generic;

namespace Projet_1_application_console
{
    class Program
    {
        
        static void Main()

        {
            

            //List<Tuple< (int, string), (string[]), (string,bool), (string, bool), (string, bool)>> ResponseFalse = new List<Tuple<(int, string), (new string[]{"bravo", true }), (string, bool), (string, bool), (string, bool)>> ();
            Tuple<object[], object[], object[], object[], object[]>[] AnswersResponse = {
                Tuple.Create(new object[] {1, "question 1:"  }, new object[] {"question 2", true },new object[] {"question 3", false },new object[] {"question 4", false },new object[] {"question 5", false })
            };
            /*ResponseFalse.(new Tuple<(int, string), (string, bool), (string, bool), (string, bool), (string, bool)>(( 1, "Qu'est ce qu'une variable"), ("bravo", true), ("refalse", false), ("rerefalse", false), ("rerererefalse", false)));
            ResponseFalse.Add(new Tuple<(int, string), (string, bool), (string, bool), (string, bool), (string, bool)>(( 1, "Qu'est ce qu'une constante"), ("bravo", true), ("refalse", false), ("rerefalse", false), ("rerererefalse", false)));
            ResponseFalse.Add(new Tuple<(int, string), (string, bool), (string, bool), (string, bool), (string, bool)>(( 1, "Qu'est ce qu'une fonction"), ("bravo", true), ("refalse", false), ("rerefalse", false), ("rerererefalse", false)));
            ResponseFalse.Add(new Tuple<(int, string), (string, bool), (string, bool), (string, bool), (string, bool)>(( 1, "Qu'est ce qu'une classes"), ("bravo", true), ("refalse", false), ("rerefalse", false), ("rerererefalse", false)));
            ResponseFalse.Add(new Tuple<(int, string), (string, bool), (string, bool), (string, bool), (string, bool)>(( 1, "Qu'est ce qu'une methode"), ("bravo", true), ("refalse", false), ("rerefalse", false), ("rerererefalse", false)));
            ResponseFalse.Add(new Tuple<(int, string), (string, bool), (string, bool), (string, bool), (string, bool)>(( 1, "Qu'est ce qu'une constante"), ("bravo", true), ("refalse", false), ("rerefalse", false), ("rerererefalse", false)));
            ResponseFalse.Add(new Tuple<(int, string), (string, bool), (string, bool), (string, bool), (string, bool)>(( 1, "Qu'est ce qu'une boucle"), ("bravo", true), ("refalse", false), ("rerefalse", false), ("rerererefalse", false)));
            ResponseFalse.Add(new Tuple<(int, string), (string, bool), (string, bool), (string, bool), (string, bool)>(( 1, "Qu'est ce qu'une condition"), ("bravo", true), ("refalse", false), ("rerefalse", false), ("rerererefalse", false)));
            ResponseFalse.Add(new Tuple<(int, string), (string, bool), (string, bool), (string, bool), (string, bool)>(( 1, "Qu'est ce qu'un objet"), ("bravo", true), ("refalse", false), ("rerefalse", false), ("rerererefalse", false)));
            ResponseFalse.Add(new Tuple<(int, string), (string, bool), (string, bool), (string, bool), (string, bool)>(( 1, "Qu'est ce qu'une emuneration"), ("bravo", true), ("refalse", false), ("rerefalse", false), ("rerererefalse", false)));*/

            void affichageTable ()
            {

                foreach (var item in AnswersResponse)
                {
                    Console.WriteLine($"{item.Item2[1].GetType()}" );
                    Console.WriteLine($"{item.Item2[0]}");
                }

                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" _____________________________________________________ ");
                Console.WriteLine($"| {AnswersResponse}                         |");
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
