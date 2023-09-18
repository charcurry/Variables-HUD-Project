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
            float smallEnemyScoreMultiplier = 0.1f;
            float mediumEnemyScoreMultiplier = 0.2f;
            float largeEnemyScoreMultiplier = 0.3f;
            float bossScoreMultiplier = 0.5f;
            float deathScoreMultiplier = -0.2f;
            int smallEnemyDamage = 10;
            int mediumEnemyDamage = 25;
            int largeEnemyDamage = 40;
            int bossDamage = 50;
            float treasurePoints = 250f;
            float smallEnemyPoints = 100f;
            float mediumEnemyPoints = 200f;
            float largeEnemyPoints = 300f;
            float bossPoints = 1000f;
            int healthPack = 15;
            string title = "Super Awesome Adventure Video Game";
            float score = 0f;
            string realName = "Charlie Curry";
            string gamerTag = "Kickycaptain";
            int health = 100;
            int lives = 3;
            int oneUp = 1;
            int death = -1;
            float scoreMultiplier = 1.0f;

            Console.WriteLine(title);
            Console.WriteLine("----------");

            Console.WriteLine(realName + " AKA " + gamerTag);
            Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
            Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);

            Console.WriteLine();

            Console.WriteLine("Player Defeats an Enemy!");
            Console.WriteLine("Player Loses " + smallEnemyDamage + " Health");
            Console.WriteLine("Player Scores " + smallEnemyPoints + " Points");
            score += smallEnemyPoints * scoreMultiplier;
            health -= smallEnemyDamage;
            scoreMultiplier += smallEnemyScoreMultiplier;

            Console.WriteLine();

            Console.WriteLine(title);
            Console.WriteLine("----------");

            Console.WriteLine(realName + " AKA " + gamerTag);
            Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
            Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);
            Console.WriteLine();

            Console.WriteLine("Player Found Some Treasure!");
            Console.WriteLine("Player Scores " + treasurePoints + " Points");
            score += treasurePoints * scoreMultiplier;

            Console.WriteLine();

            Console.WriteLine(title);
            Console.WriteLine("----------");

            Console.WriteLine(realName + " AKA " + gamerTag);
            Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
            Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);
            Console.WriteLine();

            Console.WriteLine("Player Defeats a Boss!");
            Console.WriteLine("Player Loses " + bossDamage + " Health");
            Console.WriteLine("Player Scores " + bossPoints + " Points");
            score += bossPoints * scoreMultiplier;
            health -= bossDamage;
            scoreMultiplier += bossScoreMultiplier;

            Console.WriteLine();

            Console.WriteLine(title);
            Console.WriteLine("----------");

            Console.WriteLine(realName + " AKA " + gamerTag);
            Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
            Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);
            Console.WriteLine();

            Console.WriteLine("Player is Defeated by an Enemy!");
            Console.WriteLine("Player Loses " + largeEnemyDamage + " Health");
            Console.WriteLine("Player Loses a Life");
            health -= largeEnemyDamage;
            lives += death;
            scoreMultiplier += deathScoreMultiplier;
            health += 100;

            Console.WriteLine();

            Console.WriteLine(title);
            Console.WriteLine("----------");

            Console.WriteLine(realName + " AKA " + gamerTag);
            Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
            Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);
            Console.WriteLine();

            Console.WriteLine("Player Finds a Health Pack!");
            Console.WriteLine("Player Gains " + healthPack + " Health");
            health += healthPack;

            Console.WriteLine();

            Console.WriteLine(title);
            Console.WriteLine("----------");

            Console.WriteLine(realName + " AKA " + gamerTag);
            Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
            Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);
            Console.WriteLine();

            Console.WriteLine("Player Defeats an Enemy!");
            Console.WriteLine("Player Loses " + largeEnemyDamage + " Health");
            Console.WriteLine("Player Scores " + largeEnemyPoints + " Points");
            health -= largeEnemyDamage;
            score += largeEnemyPoints * scoreMultiplier;
            scoreMultiplier += largeEnemyScoreMultiplier;

            Console.WriteLine();

            Console.WriteLine(title);
            Console.WriteLine("----------");

            Console.WriteLine(realName + " AKA " + gamerTag);
            Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
            Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);
            Console.WriteLine();

            Console.WriteLine("Player Finds a One-Up!");
            Console.WriteLine("Player Gains a Life");
            lives += oneUp;

            Console.WriteLine();

            Console.WriteLine(title);
            Console.WriteLine("----------");

            Console.WriteLine(realName + " AKA " + gamerTag);
            Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
            Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);
            Console.WriteLine();

            Console.WriteLine("Player Defeats an Enemy!");
            Console.WriteLine("Player Loses " + mediumEnemyDamage + " Health");
            Console.WriteLine("Player Scores " + mediumEnemyPoints + " Points");
            health -= mediumEnemyDamage;
            score += mediumEnemyPoints * scoreMultiplier;
            scoreMultiplier += mediumEnemyScoreMultiplier;

            Console.WriteLine();

            Console.WriteLine(title);
            Console.WriteLine("----------");

            Console.WriteLine(realName + " AKA " + gamerTag);
            Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
            Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);
            Console.WriteLine();

            Console.WriteLine("Player Finds a Health Pack!");
            Console.WriteLine("Player Gains " + healthPack + " Health");
            health += healthPack;

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
