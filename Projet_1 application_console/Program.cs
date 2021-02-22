using System;
using System.Collections.Generic;

namespace Projet1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> questionTrue = new Dictionary<string, string>();

            questionTrue.Add("Question 1", "Réponse");
            questionTrue.Add("Question 2", "Réponse");
            questionTrue.Add("Question 3", "Réponse");
            questionTrue.Add("Question 4", "Réponse");
            questionTrue.Add("Question 5", "Réponse");
            questionTrue.Add("Question 6", "Réponse");
            questionTrue.Add("Question 7", "Réponse");
            questionTrue.Add("Question 8", "Réponse");
            questionTrue.Add("Question 9", "Réponse");
            questionTrue.Add("Question 10", "Réponse");

            Dictionary<string, string> questionFalse = new Dictionary<string, string>();

            questionFalse.Add("Question 1(F1)", "Réponse Fausse 1 ");
            questionFalse.Add("Question 1(F2)", "Réponse Fausse 2");
            questionFalse.Add("Question 1(F3)", "Réponse Fausse 3");

            questionFalse.Add("Question 2(F1)", "Réponse Fausse 1");
            questionFalse.Add("Question 2(F2)", "Réponse Fausse 2");
            questionFalse.Add("Question 2(F3)", "Réponse Fausse 3");

            questionFalse.Add("Question 3(F1)", "Réponse Fausse 1");
            questionFalse.Add("Question 3(F2)", "Réponse Fausse 2");
            questionFalse.Add("Question 3(F3)", "Réponse Fausse 3");

            questionFalse.Add("Question 4(F1)", "Réponse Fausse 1 ");
            questionFalse.Add("Question 4(F2)", "Réponse Fausse 2");
            questionFalse.Add("Question 4(F3)", "Réponse Fausse 3");

            questionFalse.Add("Question 5(F1)", "Réponse Fausse 1");
            questionFalse.Add("Question 5(F2)", "Réponse Fausse 2");
            questionFalse.Add("Question 5(F3)", "Réponse Fausse 3");

            questionFalse.Add("Question 6(F1)", "Réponse Fausse 1");
            questionFalse.Add("Question 6(F2)", "Réponse Fausse 2");
            questionFalse.Add("Question 6(F3)", "Réponse Fausse 3");

            questionFalse.Add("Question 7(F1)", "Réponse Fausse 1");
            questionFalse.Add("Question 7(F2)", "Réponse Fausse 2");
            questionFalse.Add("Question 7(F3)", "Réponse Fausse 3");

            questionFalse.Add("Question 8(F1)", "Réponse Fausse 1");
            questionFalse.Add("Question 8(F2)", "Réponse Fausse 2");
            questionFalse.Add("Question 8(F3)", "Réponse Fausse 3");

            questionFalse.Add("Question 9(F1)", "Réponse Fausse 1");
            questionFalse.Add("Question 9(F2)", "Réponse Fausse 2");
            questionFalse.Add("Question 9(F3)", "Réponse Fausse 3");

            questionFalse.Add("Question 10(F1)", "Réponse Fausse 1");
            questionFalse.Add("Question 10(F2)", "Réponse Fausse 2");
            questionFalse.Add("Question 10(F3)", "Réponse Fausse 3");

            Console.WriteLine("Question 1" + questionTrue["Question 1"]);
            string data = Console.ReadLine();
        }
    }
}
