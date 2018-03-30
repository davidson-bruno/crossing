using System;
using System.Threading;

namespace TheCrossingProblem
{
    class Program
    {
        static bool[] Subjects = new bool[4];
        public static Crossing Crossing;

        static void Main(string[] args)
        {
            Crossing = new Crossing();
            string word = "racrlar";
            //string word = "al";
            //string word = "lcar";

            // a: homem sozinho
            // r: homem com coelho
            // l: homem com leão
            // c: homem com repolho

            Console.WriteLine("");
            Crossing.CheckConfiguration();
            Thread.Sleep(5000);

            foreach (char action in word)
            {
                Console.Clear();
                try
                {
                    Crossing.Cross(action);
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("The word is not solution to the problem.");
                    Thread.Sleep(10000);
                    Environment.Exit(-1);
                }

                Thread.Sleep(5000);
            }

            foreach (bool side in Crossing.Side)
            {
                if(side == false)
                {
                    Console.WriteLine("Not everyone crossed the river.");
                    Console.WriteLine("The word is not solution to the problem.");
                    Thread.Sleep(10000);
                    Environment.Exit(-1);
                }
            }

            Console.WriteLine("The word is solution to the problem.");
            Thread.Sleep(10000);
        }
    }
}