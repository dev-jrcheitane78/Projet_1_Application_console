using System;
using System.Collections.Generic;
using System.Linq;

namespace Projet_1_Application_console
{
    class Program
    {
        static void Main(string[] args)
        {
            String choix;
            int score = 0;
            // Créer un dictionnaire  
            Dictionary<string, string> questions = new Dictionary<string, string>();

            questions.Add("CLR signifie __________ ?", "Common Language Runtime");

             
            questions.Add("GAC signifie __________ ?", "Global Assembly Cache");
            questions.Add("Garbage collector (GC) comprend _______ générations.", "Trois");

            // Créer un dictionnaire  
            Dictionary<string, string> reponse= new Dictionary<string, string>();
            reponse.Add("A", "Common Language Runtime");
            reponse.Add("B", "Common Local Runtime");
            reponse.Add("C", "Common Local Realtime");
            reponse.Add("D", "Common Local Runtime");



            // Parcourir le dictionnaire
            foreach (KeyValuePair<string, string> question in questions)
            {


                Console.WriteLine("question:"+question.Key);

                foreach (KeyValuePair<string, string> rp in reponse)
                {
                    Console.WriteLine("{0} - {1}",rp.Key,rp.Value);


                }
                Console.WriteLine("choisir le bon réponse:A/B/C ou D");
                
                
               choix = Console.ReadLine();
              
               

                if (question.Value == reponse[choix]) {
                    score += 1;
                
                }


            }
            Console.WriteLine("score" + score);


            }



    }
}
