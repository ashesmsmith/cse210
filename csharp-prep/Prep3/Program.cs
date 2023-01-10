using System;

class Program
{
    static void Main(string[] args)
    {
        // Challange 1 & 2
        // Console.Write("Please enter a random number: ");
        // int random = int.Parse(Console.ReadLine());

        // Challange 3
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1, 100);

        int guess = -1;
        int track = 0;

        while (guess != random) 
        {
            Console.Write("Please guess a number: ");
            guess = int.Parse(Console.ReadLine());
            track = track +1;

            if (random > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (random < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine($"You guessed correctly in {track} attempts!");
            }

        }
    }
}