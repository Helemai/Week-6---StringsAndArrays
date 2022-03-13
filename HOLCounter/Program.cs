using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu 'h', 'e', 'o' ja 'l' tähte on lauses "Hello world!"

            Console.WriteLine("Kirjuta 'Hello world'.");
            
            string mySentence = Console.ReadLine().ToLower();

            int hCounter = 0;

            int eCounter = 0;

            int lCounter = 0;

            int oCounter = 0;

            Console.WriteLine($"Lauses '{mySentence}' on :");


            for (int i = 0; i < mySentence.Length; i++)
            {
                if (mySentence[i] == 'h')
                {
                    hCounter++;
                }
                
            }

            if (hCounter != 1)
            {
                Console.WriteLine($" {hCounter} h tähte,");
            }

            else
            {
                Console.WriteLine($"{hCounter} h täht,");
            }

            for (int i = 0; i < mySentence.Length; i++)
            {
                if (mySentence[i] == 'e')
                {
                    eCounter++;
                }

            }

            if (eCounter != 1)
            {
                Console.WriteLine($"{eCounter} e tähte,");
            }

            else
            {
                Console.WriteLine($"{eCounter} e täht,");
            }


            for (int i = 0; i < mySentence.Length; i++)
            {
                if (mySentence[i] == 'o')
                {
                    oCounter++;
                }

            }

            if (oCounter != 1)
            {
                Console.WriteLine($"{oCounter} o tähte,");
            }

            else
            {
                Console.WriteLine($"{oCounter} o täht,");
            }

            for (int i = 0; i < mySentence.Length; i++)
            {
                if (mySentence[i] == 'l')
                {
                    lCounter++;
                }

            }

            if (lCounter != 1)
            {
                Console.WriteLine($"{lCounter} l tähte.");
            }

            else
            {
                Console.WriteLine($"{lCounter} l täht.");
            }
            
            

           



        }
    }
}
