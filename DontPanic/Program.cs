using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed lauses "Don't Panic" nulliga - 0
            //programm asendab kõik 'a' tähed samas lauses number 4-ga

            string mySentence = "Don't panic!";

            mySentence = mySentence.Replace('o', '0');
            mySentence = mySentence.Replace('a', '4');
            Console.WriteLine(mySentence);





        }
    }
}
