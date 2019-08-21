using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple__RPG
{
    class Game
    {
        //player info
        string playerName = "";
        int playerMaxHealth = 100;
        int playerHealth = 100;
        int playerDamage = 10;
        int monstersRemaining = 5;
        public void Start()
        {
            //the whole game basically
            welcome();


           


            //all the encounters
            bool alive = true;

            while (alive && monstersRemaining > 0)
            {
                Console.WriteLine("There are " + monstersRemaining + " Monster(s) left");
                Console.WriteLine("");
                alive = encounter(20, 20);
                monstersRemaining--;
            }
            Console.ReadKey();
        }

        void welcome()
        {
            //Welcome
            Console.WriteLine("What is your name? ");
            playerName = Console.ReadLine();
            Console.WriteLine("Welcome, " + playerName);

        }
        bool encounter(int monsterDamage, int monsterHealth)
        {
            //Monster Encounter!
            // monsterHealth = 30;

            Console.WriteLine("There is a monster in front of you!");

            Console.WriteLine("");

            string action = "";
            bool survived = true;
            while (playerHealth > 0 && monsterHealth > 0)
            {

                Console.Write("What do you want to do? (fight/flee) ");
                action = Console.ReadLine();
                Console.WriteLine("");



                if (action == "fight" || action == "Fight")
                {
                  survived = fight(ref monsterDamage, ref monsterHealth);
                    if (!survived)
                    {
                        return false;
                    }
                }



                else if (action == "flee" || action == "Flee")
                {
                    //escape
                    Console.WriteLine(playerName + " got out safley");
                    Console.WriteLine("");
                    return true;

                }
            }

            return survived;

        }

        bool fight(ref int monsterDamage, ref int monsterHealth)
        {
            
            //monster attack
            Console.WriteLine("The monster attacks! " + playerName + " takes " + monsterDamage + " damage!");
            playerHealth = playerHealth - monsterDamage;
            Console.WriteLine("");
            Console.WriteLine(playerName + " has " + playerHealth + " health left!");
            if (playerHealth <= 0)
            {
                //player defeat
                Console.WriteLine(playerName + " was defeated!");
                return false;
            }

            //player attack
            Console.WriteLine(playerName + " attacks! The monster takes " + playerDamage + " damage!");
            monsterHealth -= playerDamage;
            Console.WriteLine("The monster has " + monsterHealth + " health left");
            if (monsterHealth <= 0)
            {
                Console.WriteLine("The monster was defeated!");
                
                return true;
            }
            bool flee()
            {

                return true;
            }
            bool heal()
            {
                return true;
            }
            return true;
        }
    }
}
