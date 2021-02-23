using System;
using System.Collections.Generic;




namespace Projet_1_application_console
{
     //Class Question may initialize with Q: set question, R: response class, goodAnswer: 1,2,3,4
     //This is one Question 
     class Question
     {
        //variables
         String question;
         readonly Responses responses;

        //constructeur
         public Question(String Q, Responses R, int goodAnswer)
         {
             question = Q;
             responses = R;
             responses.SetGoodAnswer(goodAnswer);
         }

        //methode Ask (fonction)
         public void Ask()
         {
             Console.WriteLine(this.question);
             responses.PrintResponses();
         }
     };
     //This class may create a container of responses.
     //This is one 
     class Responses
     {
         readonly string response1;
         readonly string response2;
         readonly string response3;
         readonly string response4;
         string goodResponse;
         public Responses(String R1, String R2, String R3, String R4)
         {
             response1 = R1;
             response2 = R2;
             response3 = R3;
             response4 = R4;

         }
         public void SetGoodAnswer(int N)
         {
             switch (N)
             {
                 case 1:
                     goodResponse = response1;
                     break;
                 case 2:
                     goodResponse = response2;
                     break;
                 case 3:
                     goodResponse = response3;
                     break;
                 case 4:
                     goodResponse = response4;
                     break;
                 default:
                     goodResponse = response1;
                     break;
             }
         }
         public bool CheckResponse(String response)
         {
             if(goodResponse == response)
             {
                 return true;
             }
             else
             {
                 return false;
             }
         }
         public void PrintResponses()
         {
             Console.WriteLine(this.response1 + this.response2 + this.response3 + this.response4);
            while (Console.ReadKey(false).Key != ConsoleKey.Enter)
            {
                if(Console.ReadKey(false).Key == ConsoleKey.RightArrow)
                {

                }
            }
        }
     };
    
    class Program
    {

        private static List<KeyValuePair<string, string>> questions = new List<KeyValuePair<string, string>>
    {
        new KeyValuePair<string,string>("-Quelle est la bonne syntaxe pour afficher 'Hello World' en c#? ", "C : Console.WriteLine('Hello World')"),
        new KeyValuePair<string,string>("-Comment insère tu un commentaire en c#", "A : //Ceci est un commentaire"),
        new KeyValuePair<string,string>("-Quelle variable appelle une chaine de caractère ?", "C : string"),
        new KeyValuePair<string,string>("-Comment crée tu une variable numérique valant 5 ?", "D :int = x = 5;"),
    };
       

        static void Main(string[] args)
        {
           
            
            {
                {
                       //use example
                       Responses R1 = new Responses("A : Print'Hello World'", "B :System.outprintIn'HelloWorld'", "C : Console.WriteLine('Hello World')", "D : cout <<'HelloWorld'");
                       List<Question> questionsK = new List<Question>();
                       questionsK.Add(new Question("-Quelle est la bonne syntaxe pour afficher 'Hello World' en c#? ", R1, 4));

                       foreach(Question q in questionsK)
                       {
                           q.Ask();
                       }
                       

                    Console.WriteLine("Ecrit ton nom et ton prénom :) ");
                    string name1 = Console.ReadLine();
                    Console.WriteLine($"Bonjour {name1}, le test va commencer, il y a une réponse par question. " +
                        $" Ce test est chronométré tu auras le résultats à la fin" +
                        $"\nBonne chance ! ");
                    {
                        
                    }

                    // var questions = ShuffleQuestions();//mélange les questions

                    List<string> response1 = new List<string>() { "A : Print'Hello World'", "B :System.outprintIn'HelloWorld'", "C : Console.WriteLine('Hello World')", "D : cout <<'HelloWorld'" };
                    List<string> response2 = new List<string>() { "A : //Ceci est un commentaire", "B : #Ceci est un commentaire", "C : ##Ceci est un commentaire", " D : (Ceci est un commentaire)" };
                    List<string> response3 = new List<string>() { "A : Int", "B : Str", "C : string", "D : Mystring" };
                    List<string> response4 = new List<string>() { "A : x = 5;", "B : double x = 5;", "C : numx = 5;", "D :int = x = 5;" };
                    

                    List<List<string>> manyreponses = new List<List<string>>() { response1, response2, response3, response4 };
                    

                    int index = 0;
                    
                    foreach (var question in questions)
                    {
                        bool done = false;
                        while (!done)
                        {
                            Console.WriteLine(question.Key);

                            Console.WriteLine(manyreponses[index]); //chercher comment appeler pour chaque boucle une liste diférente
                            index++;

                            string answer = Console.ReadLine();

                            if (answer == question.Value)
                            {
                                Console.WriteLine("Bonne réponse \n*Prochaine question : ");
                                done = true;
                            }
                            else
                                Console.WriteLine("Mauvaise réponse\n*Prochaine question :");
                            done = true;


                        }
                    }

                    Console.ReadLine();

                    

                    


                    }
                }
            }
        }
    }

/*IEnumerable<KeyValuePair<string, string>> ShuffleQuestions()
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
}*/


/*
List<string> question = new List<string>();

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






