using System;
using CaesarCipherLibrary;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Inserisci una parola: ");
                string plaintext = Console.ReadLine();
                int key;
                CaesarCode m1;
                try
                {
                    do
                    {
                        Console.Write("Inserisci la chiave: ");
                        key = int.Parse(Console.ReadLine());

                        if (key < 0 || key > 25) Console.WriteLine("Chiave errata!");
                    } while (key < 0 || key > 25);

                    m1 = new CaesarCode(plaintext, key);
                    Console.Write($"Il testo cifrato è: {m1.CipherText}");
                }
                catch
                {
                    Console.Write("Devi inserire un numero!");
                }

                Console.ReadLine();
            }
        }
    }
}
