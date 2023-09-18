using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Variables_HUD_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "My Video Game";
            float score = 0f;
            string realName = "Charlie Curry";
            string gamerTag = "Kickycaptain";
            float health = 100.0f;
            int lives = 3;
            float scoreMultiplier = 1f;

            Console.WriteLine(title);
            Console.WriteLine("----------");

            Console.WriteLine(realName + " AKA " + gamerTag);
            Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
            Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);

            Console.WriteLine();

            Console.WriteLine("Player Defeats an Enemy!");
            Console.WriteLine("Player Loses 10 Health");
            Console.WriteLine("Player Scores 100 Points");
            score += 100f * scoreMultiplier;
            health -= 10;
            scoreMultiplier += 0.1f;

            Console.WriteLine();

            Console.WriteLine(title);
            Console.WriteLine("----------");

            Console.WriteLine(realName + " AKA " + gamerTag);
            Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
            Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);
            Console.WriteLine();

            Console.WriteLine("Player Found Some Treasure!");
            Console.WriteLine("Player Scores 250 Points");
            score += 250f * scoreMultiplier;

            Console.WriteLine();

            Console.WriteLine(title);
            Console.WriteLine("----------");

            Console.WriteLine(realName + " AKA " + gamerTag);
            Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
            Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
