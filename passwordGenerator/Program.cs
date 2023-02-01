using Utils;
using System;

namespace passwordGenerator
{
    class Program
    {

        static void Main(string[] args)
        {
            int passwordLength = utils.AskPositifNumberNotNull("Longueur du mot de passe : ");

            string min = "abcdefghijklmnopqrstuvwxyz";
            string alphabet = min;
            string password = "";
            int alphabetLength = alphabet.Length;
            Random rand = new Random();

            for (int i = 0; i < passwordLength; i++)
            {
                int index = rand.Next(0, alphabetLength);
                Console.WriteLine($":::index  {index}");
                password += alphabet[index];
            }


            Console.WriteLine("Mot de passe : " + password);

        }
    }
}
