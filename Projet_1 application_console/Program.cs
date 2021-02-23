using System;
using System.Text;
using System.Collections.Generic;

namespace Projet_1_application_console
{
    class Program
    {
        static void Main()

        {
            

            Tuple<object[], object[], object[], object[], object[]>[] AnswersResponse = {
                Tuple.Create(new object[] {1, "Question 1: Quelle est la bonne sythaxe pour afficher 'Hello World' en C# ?"  }, 
                new object[] { "Console.WriteLine('Hello World');", true  },
                new object[] { "Print'Hello World", false},
                new object[] { "System.outprintIn'HelloWorld'", false },
                new object[] { "cout <<'HelloWorld'", false }),
                Tuple.Create(new object[] {2, "Question 2: Comment insère tu un commentaire d'un ligne en c#"  },
                new object[] { "#Ceci est un commentaire", false }, 
                new object[] { "// Ceci est un commentaire", true },
                new object[] { "##Ceci est un commentaire", false },
                new object[] { "(Ceci est un commentaire)", false }),
                Tuple.Create(new object[] {3, "Question 3: Quelle variable appelle une chaine de caractère ?"  }, 
                new object[] { "Mystring", false },
                new object[] { "Str", false},
                new object[] { "string", true  },
                new object[] { "Int", false }),
                Tuple.Create(new object[] {4, "Question 4: Comment crée tu une variable numérique valant 5 ?"  }, 
                new object[] { "x = 5", false },
                new object[] { "double x = 5", false},
                new object[] { "numx = 5", false },
                new object[] { "int x = 5", true }),
                Tuple.Create(new object[] {5, "Question 5: Comment déclare - t -on correctement un tableau à deux dimensions en C#?"  }, 
                new object[] { "int[][] myArray;", false },
                new object[] { "int[2] myArray;", false},
                new object[] { "int[,] myArray;", true  },
                new object[] { "System.Array[2] myArray;", false }),
                Tuple.Create(new object[] {6, "Question 6: En C#, les string (chaînes de caractères) sont..." }, 
                new object[] { "... imbitables.", false },
                new object[] { "... immutables.", true },
                new object[] { "... inclassables.", false },
                new object[] { "... mutables.", false }),
                Tuple.Create(new object[] {7, "Question 7: Le mot clef int correspond à quel type .NET ?"  }, 
                new object[] { "System.Int32", true  },
                new object[] { "System.Int16", false},
                new object[] { "System.Int64", false },
                new object[] { "System.Int128", false }),
                Tuple.Create(new object[] {8, "Question 8: En programmation orientée objet, comment décririez - vous l'encapsulation ?"  }, 
                new object[] { "L'exposition des données.", false },
                new object[] { "La séparation de l'interface de l'implémentation", true },
                new object[] { "La résolution à la volée d'appels de méthode.", false },
                new object[] { "La conversion d'un type d'objet vers un autre.", false }),
                Tuple.Create(new object[] {9, "question 9: Le __ en switch permet d’arrêter le code."  },
                new object[] { "default;", false },
                new object[] { "goto", false},
                new object[] { "break;", true  },
                new object[] { "goto", false }),
                Tuple.Create(new object[] {10, "Question 10: Laquelle de ces définitions de string évite le recours aux séquences d'échappement en C# ?"}, 
                new object[] { "string s = #'Test string';", false },
                new object[] { "string s = .'Test string';", false},
                new object[] { "string s = @'Test string';", false },
                new object[] { "string s = 'Test string';", true })
            };

            int compteur = 0;
            Console.WriteLine($" Vous allez effectuez un test qui comporte 10 Questions. " +
                              $"\n 4 reponses seront associées a chaque question, vous devez repondre en tapant une valeur numerique comprise entre 1 et 4");

            Console.WriteLine($"Entrez votre nom: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Entrez votre prenom: ");
            string firstname = Console.ReadLine();


            Console.WriteLine($"Appuyez sur la touche 1 et après sur 'Entrée' pour demarrer le test");
            int start = int.Parse(Console.ReadLine());

            void Question()
            {
                List<object> reponseOk = new List<object>();
                List<object> questionReponse = new List<object>();

                DateTime startTimer = DateTime.Now;
                foreach (var item in AnswersResponse)
                {
                    object questionUser = item.Item1[1];

                    object a = item.Item2[1];
                    object b = item.Item3[1];
                    object c = item.Item4[1];
                    object d = item.Item5[1];

                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"  ____________________________________________________________________________________________________________ ");
                    Console.WriteLine($" | {questionUser}    |");
                    Console.WriteLine($" |------------------------------------------------------------------------------------------------------------|");
                    Console.WriteLine($" |                                                                                                            |");
                    Console.WriteLine($" |  1. {item.Item2[0]}                          2. {item.Item3[0]}                        |");
                    Console.WriteLine($" |                                                                                                            |");
                    Console.WriteLine($" |  3. {item.Item4[0]}                              4. {item.Item5[0]}                      |");
                    Console.WriteLine($" |                                                                                                            |");
                    Console.WriteLine($" |------------------------------------------------------------------------------------------------------------|");
                    
                    int choixUser = int.Parse(Console.ReadLine());
                    Console.WriteLine($" |                                                                                                            |");
                    Console.WriteLine($" |   Ta reponse:  {choixUser}                                                                                            |");
                    Console.WriteLine($" |                                                                                                            |");
                    Console.WriteLine($" |____________________________________________________________________________________________________________|");
                    Console.WriteLine($"                                                                                                               ");

                    if (choixUser == 1)
                    {
                        if (a.Equals(true))
                        {
                            compteur++;
                            reponseOk.Add((item.Item1[1] , item.Item2[0]));
                        }
                    }
                    else if (choixUser == 2)
                    {
                        if (b.Equals(true))
                        {
                            compteur++;
                            reponseOk.Add((item.Item1[1], item.Item3[0]));
                            
                        }
                    }
                    else if (choixUser == 3)
                    {
                        if (c.Equals(true))
                        {
                            compteur++;
                            reponseOk.Add((item.Item1[1], item.Item4[0]));
                        }
                    }
                    else if (choixUser == 4)
                    {
                        if (d.Equals(true))
                        {
                            compteur++;
                            reponseOk.Add((item.Item1[1], item.Item5[0]));
                        }
                    }
                }

                TimeSpan duration = DateTime.Now.Subtract(startTimer);

                string time = string.Format(
                "Temps: {0}m, {1}s et {2}ms.",
                duration.Minutes,
                duration.Seconds,
                duration.Milliseconds);

                Console.WriteLine(time);

                foreach (var item in reponseOk)
                {
                    Console.WriteLine($"{item} clap clap");
                }

                


                


                if (compteur >= 7)
                {
                    Console.WriteLine($" {firstname} {name} vous avez obtenu un score de : {compteur}/ 10. Bravo c'est un très bon resultat");
                }
                else if (compteur == 5 || compteur == 6)
                {
                    Console.WriteLine($" {firstname} {name} vous avez obtenu un score de : {compteur}/ 10. Tout juste la moyenne, attention!!!");
                } 
                else if (compteur <= 5)
                {
                    Console.WriteLine($" {firstname} {name} vous avez obtenu un score de : {compteur}/ 10. Une prochaine fois peut etre, je connais un bon formateur ;)");
                }
            }

            do
            {
                if (start == 1)
                {
                    Question();
                    start = 0;
                }
                else
                {
                    Console.WriteLine($"Nigaud entre la bonne valeur... \n Entrez la valeur 1 pour commencer le test");
                           
                    start = int.Parse(Console.ReadLine()); ;
                }
            } while (start == 1);

            Console.Read();
        }
    }
        
}
