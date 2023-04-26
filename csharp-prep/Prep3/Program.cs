using System;

class Program
{
    static void Main(string[] args)
    //Console.Write("What is the magic number?");
    //int magicNumber = int.Parse(Console.ReadLine());
    {
        Random randomnumberGenerator = new Random();
        int magicNumber = randomnumberGenerator.Next(1,101);

        int guess =-1;

        while (guess != magicNumber)
        {
            Console.Write("What is the magic number?");
            guess = int.Parse(Console.ReadLine());
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher!");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}