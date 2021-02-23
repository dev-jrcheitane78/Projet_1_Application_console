using System;
using System.Collections.Generic;

namespace Projet_1_application_console
{
    class Program
    {      
        static void Main()

        {
            

            Tuple<object[], object[], object[], object[], object[]>[] AnswersResponse = {
                Tuple.Create(new object[] {1, "question 1: Quelle est la bonne sythaxe pour afficher 'Hello World' en C# ?"  }, 
                new object[] {"Console.WriteLine('Hello World');", true  },
                new object[] {"Print'Hello World", false},
                new object[] {"System.outprintIn'HelloWorld'", false },
                new object[] {"cout <<'HelloWorld'", false }),
                Tuple.Create(new object[] {2, "question 2:"  },
                new object[] {"reponse 1", false },
                new object[] { "reponse 2", true },
                new object[] { "reponse 3", false },
                new object[] {"reponse 4", false }),
                Tuple.Create(new object[] {3, "question 3:"  }, 
                new object[] {"reponse 1", false },
                new object[] { "reponse 2", false},
                new object[] { "reponse 3", true  },
                new object[] {"reponse 4", false }),
                Tuple.Create(new object[] {4, "question 4:"  }, 
                new object[] {"reponse 1", false },
                new object[] { "reponse 2", false},
                new object[] { "reponse 3", false },
                new object[] {"reponse 4", true }),
                Tuple.Create(new object[] {5, "question 5:"  }, 
                new object[] {"reponse 1", false },
                new object[] { "reponse 2", false},
                new object[] { "reponse 3", true  },
                new object[] {"reponse 4", false }),
                Tuple.Create(new object[] {6, "question 6:"  }, 
                new object[] {"reponse 1", false },
                new object[] { "reponse 2", true },
                new object[] { "reponse 3", false },
                new object[] {"reponse 4", false }),
                Tuple.Create(new object[] {7, "question 7:"  }, 
                new object[] {"reponse 1", true  },
                new object[] { "reponse 2", false},
                new object[] { "reponse 3", false },
                new object[] {"reponse 4", false }),
                Tuple.Create(new object[] {8, "question 8:"  }, 
                new object[] {"reponse 1", false },
                new object[] { "reponse 2", true },
                new object[] { "reponse 3", false },
                new object[] {"reponse 4", false }),
                Tuple.Create(new object[] {9, "question 9:"  },
                new object[] {"reponse 1", false },
                new object[] { "reponse 2", false},
                new object[] { "reponse 3", true  },
                new object[] {"reponse 4", false }),
                Tuple.Create(new object[] {10, "question 10:"}, 
                new object[] {"reponse 1", false },
                new object[] { "reponse 2", false},
                new object[] { "reponse 3", false },
                new object[] {"reponse 4", true })
            };

            void Question()
            {

                foreach (var item in AnswersResponse)
                {
                    object questionUser = item.Item1[1];

                    object a = item.Item2[1];
                    object b = item.Item3[1];
                    object c = item.Item4[1];
                    object d = item.Item5[1];

                    int choixUser = int.Parse(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($" _______________________________________________________________________________________________ ");
                    Console.WriteLine($"| {questionUser}                   |");
                    Console.WriteLine($"|-----------------------------------------------------------------------------------------------|");
                    Console.WriteLine($"|                                                                                               |");
                    Console.WriteLine($"|  1. {item.Item2[0]}                 2. {item.Item3[0]}                                        |");
                    Console.WriteLine($"|                                                                                               |");
                    Console.WriteLine($"|  3. {item.Item4[0]}                 4. {item.Item5[0]}                                        |");
                    Console.WriteLine($"|                                                                                               |");
                    Console.WriteLine($"|-----------------------------------------------------------------------------------------------|");
                    Console.WriteLine($"|                                                                                               |");
                    Console.WriteLine($"|   Ta reponse:  {choixUser}                                                                               |");
                    Console.WriteLine($"|                                                                                               |");
                    Console.WriteLine($"|_______________________________________________________________________________________________|");
                    Console.WriteLine($"                                                                                                 ");

                    
                    if (choixUser == 1)
                    {
                        if (a.Equals(true))
                        {
                            Console.WriteLine("Bonne reponse");
                        }
                        else
                        {
                            Console.WriteLine("mauvaise reponse");
                        }
                    }
                    else if (choixUser == 2)
                    {
                        if (b.Equals(true))
                        {
                            Console.WriteLine("Bonne reponse");
                        }
                        else
                        {
                            Console.WriteLine("mauvaise reponse");
                        }
                    }
                    else if (choixUser == 3)
                    {
                        if (c.Equals(true))
                        {
                            Console.WriteLine("Bonne reponse");
                        }
                        else
                        {
                            Console.WriteLine("mauvaise reponse");
                        }
                    }
                    else if (choixUser == 4)
                    {
                        if (d.Equals(true))
                        {
                            Console.WriteLine("Bonne reponse");
                        }
                        else
                        {
                            Console.WriteLine("mauvaise reponse");
                        }
                    }
                }
            }


            /*void affichageTable ()
            {

                Question();


                
            }
            Question();
            affichageTable();
  
            Console.ResetColor();*/
            Question();
            Console.Read();
        }
    }
        
}
