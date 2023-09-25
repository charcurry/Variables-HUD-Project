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

        static void ShowHUD(string title, int health, float score, float scoreMultiplier, string realName, string gamerTag, int lives)
        {
            Console.WriteLine(title);
            Console.WriteLine("----------");

            Console.WriteLine(realName + " AKA " + gamerTag);
            Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
            Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            float smallEnemyScoreMultiplier = 0.1f;
            float mediumEnemyScoreMultiplier = 0.2f;
            float largeEnemyScoreMultiplier = 0.3f;
            float bossScoreMultiplier = 0.5f;
            float finalBossScoreMultiplier = 0.6f;
            float deathScoreMultiplier = -0.2f;
            int smallEnemyDamage = 10;
            int mediumEnemyDamage = 25;
            int largeEnemyDamage = 40;
            int bossDamage = 50;
            int finalBossDamage = 60;
            float treasurePoints = 250f;
            float smallEnemyPoints = 100f;
            float mediumEnemyPoints = 200f;
            float largeEnemyPoints = 300f;
            float bossPoints = 1000f;
            float finalBossPoints = 2000f;
            int healthPack = 15;
            string title = "Super Awesome Adventure Video Game";
            float score = 0f;
            string realName = "Charlie Curry";
            string gamerTag = "Kickycaptain";
            int health = 100;
            int newLifeHealth = 100;
            int lives = 3;
            int oneUp = 1;
            int death = -1;
            float scoreMultiplier = 1.0f;

            void TakeDamage(int damage)
            {
                health -= damage;
            }

            void AddScore(float pointsEarned)
            {
                score += pointsEarned * scoreMultiplier;
            }

            ShowHUD(title, health, score, scoreMultiplier, realName, gamerTag, lives);

            Console.WriteLine("Player Defeats an Enemy!");
            Console.WriteLine("Player Loses " + smallEnemyDamage + " Health");
            Console.WriteLine("Player Scores " + smallEnemyPoints + " Points");
            AddScore(smallEnemyPoints);
            TakeDamage(smallEnemyDamage);
            scoreMultiplier += smallEnemyScoreMultiplier;

            Console.WriteLine();

            ShowHUD(title, health, score, scoreMultiplier, realName, gamerTag, lives);

            Console.WriteLine("Player Found Some Treasure!");
            Console.WriteLine("Player Scores " + treasurePoints + " Points");
            AddScore(treasurePoints);

            Console.WriteLine();

            ShowHUD(title, health, score, scoreMultiplier, realName, gamerTag, lives);

            Console.WriteLine("Player Defeats a Boss!");
            Console.WriteLine("Player Loses " + bossDamage + " Health");
            Console.WriteLine("Player Scores " + bossPoints + " Points");
            AddScore(bossPoints);
            TakeDamage(bossDamage);
            scoreMultiplier += bossScoreMultiplier;

            Console.WriteLine();

            ShowHUD(title, health, score, scoreMultiplier, realName, gamerTag, lives);

            Console.WriteLine("Player is Defeated by an Enemy!");
            Console.WriteLine("Player Loses " + largeEnemyDamage + " Health");
            Console.WriteLine("Player Loses a Life");
            TakeDamage(largeEnemyDamage);
            lives += death;
            scoreMultiplier += deathScoreMultiplier;
            health += newLifeHealth;

            Console.WriteLine();

            ShowHUD(title, health, score, scoreMultiplier, realName, gamerTag, lives);

            Console.WriteLine("Player Finds a Health Pack!");
            Console.WriteLine("Player Gains " + healthPack + " Health");
            health += healthPack;

            Console.WriteLine();

            ShowHUD(title, health, score, scoreMultiplier, realName, gamerTag, lives);

            Console.WriteLine("Player Defeats an Enemy!");
            Console.WriteLine("Player Loses " + largeEnemyDamage + " Health");
            Console.WriteLine("Player Scores " + largeEnemyPoints + " Points");
            TakeDamage(largeEnemyDamage);
            AddScore(largeEnemyPoints);
            scoreMultiplier += largeEnemyScoreMultiplier;

            Console.WriteLine();

            ShowHUD(title, health, score, scoreMultiplier, realName, gamerTag, lives);

            Console.WriteLine("Player Finds a One-Up!");
            Console.WriteLine("Player Gains a Life");
            lives += oneUp;

            Console.WriteLine();

            ShowHUD(title, health, score, scoreMultiplier, realName, gamerTag, lives);

            Console.WriteLine("Player Defeats an Enemy!");
            Console.WriteLine("Player Loses " + mediumEnemyDamage + " Health");
            Console.WriteLine("Player Scores " + mediumEnemyPoints + " Points");
            TakeDamage(mediumEnemyDamage);
            AddScore(mediumEnemyPoints);
            scoreMultiplier += mediumEnemyScoreMultiplier;

            Console.WriteLine();

            ShowHUD(title, health, score, scoreMultiplier, realName, gamerTag, lives);

            Console.WriteLine("Player Finds a Health Pack!");
            Console.WriteLine("Player Gains " + healthPack + " Health");
            health += healthPack;

            Console.WriteLine();

            ShowHUD(title, health, score, scoreMultiplier, realName, gamerTag, lives);

            Console.WriteLine("Player Encounters the Final Boss!");
            Console.WriteLine("Player Defeats the Final Boss");
            Console.WriteLine("Player Loses " + finalBossDamage + " Health");
            Console.WriteLine("Player Scores " + finalBossPoints + " Points");
            TakeDamage(finalBossDamage);
            AddScore(finalBossPoints);
            scoreMultiplier += finalBossScoreMultiplier;

            Console.WriteLine();

            ShowHUD(title, health, score, scoreMultiplier, realName, gamerTag, lives);

            Console.WriteLine("You Win!");
            Console.WriteLine("Final Score: " + score + " Points");

            Console.ReadLine();
        }
    }
}
