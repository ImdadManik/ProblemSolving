using System;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = System.Environment.UserName.ToLower();

            switch (username)
            {
                case "imdad":
                    //cImdad.useZigZag();
                    cImdad.useSuperReducedString();
                    break;
                case "kamran":
                    break;

            } 
            Console.Read();
        }

    }
}
