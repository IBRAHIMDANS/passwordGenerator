using System;
using System.Collections.Generic;
using System.Text;

namespace Utils
{
    static class utils
    {
        public static int AskPositifNumberNotNull(string question)
        {
            return AskPositifNumberBeetween(question, 1, int.MaxValue);
        }

        public static int AskPositifNumberBeetween(string question, int min, int max)
        {

            int nombre = AskPositifNumber(question);
            if ((nombre >= min) && (nombre <= max))
            {
                // valide
                return nombre;
            }
            Console.WriteLine("ERREUR : Le nombre doit être compris entre " + min + " et " + max);

            return AskPositifNumberBeetween(question, min, max);
        }

        public static int AskPositifNumber(string question)
        {
            while (true)
            {
                Console.Write(question);
                string reponse = Console.ReadLine() ?? "";
                try
                {
                    int reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR : Vous devez rentrer un nombre");
                }
            }
        }

    }
}