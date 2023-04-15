using System;

namespace zd2
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitForProgram = "";
            while (exitForProgram != "exit")

            {
                Console.WriteLine("Продолжается код программы, пока не введете 'exit' ");
                exitForProgram = Console.ReadLine();

            }

        }
    }
}
