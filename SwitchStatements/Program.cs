using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            string subject = "C#";

            Console.WriteLine("Choose a subject");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "C#":
                    Console.WriteLine("You are in the right class!");
                    break;
                case "Java":
                    Console.WriteLine("C# is better than Java");
                    break;
                default:
                    Console.WriteLine("That subject sucks, we are in the C# class");
                    break;
            }
        }
    }
}
