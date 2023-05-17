using System;


namespace Introduction
{
    public class NewUser
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {1}, I'm {0}", to, Name);
            Console.WriteLine("Nice to meet you: ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var userOne = new NewUser();
            Console.WriteLine("Enter your Name:");
            userOne.Name = Console.ReadLine();
            Console.Clear();


            userOne.Introduce("Esther");

            //guessing game starts here
            Console.WriteLine("would you like to play a game?");
            Console.ReadLine();


           // Random.ReferenceEquals(userOne.Name, Console.ReadLine());
        }
    }
}
