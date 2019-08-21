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
        int playerHealth = 100;
        public void Start()
        {
            //the whole game basically
            welcome();


            int monstersRemaining = 5;


            //all the encounters
            bool alive = true;

            while (alive && monstersRemaining>0)
            {
                Console.WriteLine("There are " + monstersRemaining + " Monsters left");
                Console.WriteLine("");
                alive = encounter(20);
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
        bool encounter(int monsterDamage)
        {
            //Monster Encounter!
            
            Console.WriteLine("There is a monster in front of you!");

            Console.WriteLine("");

            string action = "";
            Console.Write("Well " + playerName + " Do Something! (fight/flee) ");
            action = Console.ReadLine();
            Console.WriteLine("");
            if (action == "fight" || action == "Fight")
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
                Console.WriteLine(playerName + " attacks! the monster is defeated!");

            }
            else if (action == "flee" || action == "Flee")
            {
                //escape
                Console.WriteLine(playerName + " got out safley");

            }

            //Work in progress
            /*else if (action != "Fight" || action != "fight" || action != "flee" || action != "Flee")
            {
                Console.WriteLine("Try again, (fight/flee)");
                action = Console.ReadLine();

            }*/
            return true;

        }
    }
}
