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
            float finalBossScoreMultiplier = 0.6f;
            float deathScoreMultiplier = 0.2f;
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
            int healthPack = 30;
            string title = "Super Awesome Adventure Video Game";
            float score = 0f;
            string realName = "Charlie Curry";
            string gamerTag = "Kickycaptain";
            int health = 100;
            int maxHealth = 100;
            int lives = 3;
            int oneUp = 1;
            float scoreMultiplier = 1.0f;
            int weapon = 0;

            string WeaponName(int weaponVar)
            {
                if (weaponVar == 0)
                {
                    return "Pistol";
                }
                else if (weaponVar == 1)
                {
                    return "Shot Gun";
                }
                else if (weaponVar == 2)
                {
                    return "Spreader";
                }
                else if (weaponVar == 3)
                {
                    return "Laser";
                }
                else if (weaponVar == 4)
                {
                    return "Sniper";
                }
                else if (weaponVar == 5)
                {
                    return "BFG";
                }
                return null;
            }

            string HealthStatus(int healthVar)
            {
                if (healthVar == 100)
                {
                    return "Perfect Health";
                }
                else if (healthVar < 100 && healthVar >= 75)
                {
                    return "Healthy";
                }
                else if (healthVar < 75 && healthVar >= 50 )
                {
                    return "Hurt";
                }
                else if (healthVar < 50 && healthVar >= 10)
                {
                    return "Badly Hurt";
                }
                else if (healthVar < 10)
                {
                    return "Imminent Danger";
                }
                return null;
            }

            void ChangeWeapon(int weaponPickedUp)
            {
                weapon = weaponPickedUp;
            }

            void TakeDamage(int damage)
            {
                if (health - damage <= 0)
                {
                    health = maxHealth;
                    lives--;
                    scoreMultiplier -= deathScoreMultiplier;
                }
                else
                {
                    health -= damage;
                }
                
            }

            void Heal(int hp)
            {
                if (health + hp > 100)
                {
                    health = maxHealth;
                }
                else
                {
                    health += hp;
                }
                
            }

            void AddScore(float pointsEarned)
            {
                score += pointsEarned * scoreMultiplier;
            }

            void ShowHUD()
            {
                Console.WriteLine(title);
                Console.WriteLine("----------");

                Console.WriteLine(realName + " AKA " + gamerTag);
                Console.WriteLine("Weapon: " + WeaponName(weapon));
                Console.WriteLine("Health: " + health + " | " + "Lives: " + lives);
                Console.WriteLine(HealthStatus(health));
                Console.WriteLine("Score: " + score + " | " + "Score Multiplier: " + scoreMultiplier);

                Console.WriteLine();
            }

            ShowHUD();

            Console.WriteLine("Player Defeats an Enemy With a Pistol!");
            Console.WriteLine("Player Loses " + smallEnemyDamage + " Health");
            Console.WriteLine("Player Scores " + smallEnemyPoints + " Points");
            AddScore(smallEnemyPoints);
            TakeDamage(smallEnemyDamage);
            scoreMultiplier += smallEnemyScoreMultiplier;

            Console.WriteLine();

            ShowHUD();

            Console.WriteLine("Player Found Some Treasure!");
            Console.WriteLine("Player Scores " + treasurePoints + " Points");
            Console.WriteLine("Player Finds a " + WeaponName(1) + " in the Chest");
            AddScore(treasurePoints);
            ChangeWeapon(1);

            Console.WriteLine();

            ShowHUD();

            Console.WriteLine("Player Defeats a Boss With a Shot Gun!");
            Console.WriteLine("Player Loses " + bossDamage + " Health");
            Console.WriteLine("Player Scores " + bossPoints + " Points");
            AddScore(bossPoints);
            TakeDamage(bossDamage);
            scoreMultiplier += bossScoreMultiplier;

            Console.WriteLine();

            ShowHUD();

            Console.WriteLine("Player is Defeated by an Enemy!");
            Console.WriteLine("Player Loses " + largeEnemyDamage + " Health");
            Console.WriteLine("Player Loses a Life");
            TakeDamage(largeEnemyDamage);

            Console.WriteLine();

            ShowHUD();

            Console.WriteLine("Player Defeats an Enemy With a Shot Gun!");
            Console.WriteLine("Player Loses " + largeEnemyDamage + " Health");
            Console.WriteLine("Player Scores " + largeEnemyPoints + " Points");
            Console.WriteLine("Player Finds a " + WeaponName(2) + " on the Enemy");
            TakeDamage(largeEnemyDamage);
            AddScore(largeEnemyPoints);
            ChangeWeapon(2);
            scoreMultiplier += largeEnemyScoreMultiplier;

            Console.WriteLine();

            ShowHUD();

            Console.WriteLine("Player Finds a One-Up!");
            Console.WriteLine("Player Gains a Life");
            lives += oneUp;

            Console.WriteLine();

            ShowHUD();

            Console.WriteLine("Player Defeats an Enemy With a Spreader!");
            Console.WriteLine("Player Loses " + mediumEnemyDamage + " Health");
            Console.WriteLine("Player Scores " + mediumEnemyPoints + " Points");
            TakeDamage(mediumEnemyDamage);
            AddScore(mediumEnemyPoints);
            scoreMultiplier += mediumEnemyScoreMultiplier;

            Console.WriteLine();

            ShowHUD();

            Console.WriteLine("Player Finds a Health Pack!");
            Console.WriteLine("Player Gains " + healthPack + " Health");
            Heal(healthPack);

            Console.WriteLine();

            ShowHUD();

            Console.WriteLine("Player Encounters the Final Boss!");
            Console.WriteLine("Player Defeats the Final Boss With a Spreader");
            Console.WriteLine("Player Loses " + finalBossDamage + " Health");
            Console.WriteLine("Player Scores " + finalBossPoints + " Points");
            TakeDamage(finalBossDamage);
            AddScore(finalBossPoints);
            scoreMultiplier += finalBossScoreMultiplier;

            Console.WriteLine();

            ShowHUD();

            Console.WriteLine("You Win!");
            Console.WriteLine("Final Score: " + score + " Points");

            Console.ReadLine();
        }
    }
}
