using System;
namespace method_exercises
{
    public static class RandomNumber
    {
        public static void DisplayRandomNumbers()
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{random.Next(1, 100)} ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}

