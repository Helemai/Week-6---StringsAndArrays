using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset 'Hello, world!' tagurpidi

            

            string mySentence = "Hello, world!";

            for (int i = mySentence.Length - 1; i >= 0; i--)
            {
                Console.Write(mySentence[i]);
            }




        }
    }
}
