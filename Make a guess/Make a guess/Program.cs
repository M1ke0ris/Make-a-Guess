using System;

namespace Make_a_guess
{
    internal class Program
    {
        private static int points;

        static int playersNumber;
        public static void Main(string[] args)
        {


            Console.WriteLine(
                "Hello Stranger. Welcome to the great Valentino!Try to guess the number that is in a gratest Valentino mind. To make it fair, try to guess a number from 1-5. Good luck.");
            addPoints();
        }
        
        static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min,max);
        }

        static int addPoints()
        {
            playersNumber = Convert.ToInt32(Console.ReadLine());
            int pointnum = RandomNumber(1, 5);
            if (playersNumber == pointnum)
            {
                //points += 10;
                points = points + 10;
                Console.WriteLine("Good job Travaller, but simple luck!!! Try again if you want, you will loose");
                Console.WriteLine($"points = {points}");
                addPoints();
            }
            else 
            {
                points -= 3;
                Console.WriteLine(
                    $"HAHAHAHA!!! You lost - noob.Right answer was {pointnum} Noone can beat the mighty Valentino. Try again if you dare.");
                if (points < 0)
                {
                    points = Math.Max(-10, 0);
                }
                Console.WriteLine($"points = {points}");
                addPoints();
            }

            return points;
        }
        
        
    }


}