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
            

            //Welcome
            Console.WriteLine("What is your name? ");
            playerName = Console.ReadLine();
            Console.WriteLine("Welcome, " + playerName);

            Console.WriteLine("");

            encounter();
            

            Console.ReadKey();
        }

        void welcome()
        {

        }
        void encounter()
        {
            


            //Monster Encounter!
            int monsterDamage = 13;
            Console.WriteLine("There is a monster in front of you!");

            Console.WriteLine("");

            string action = "";
            Console.Write("Well " + playerName + " Do Something! (fight/flee) ");
            action = Console.ReadLine();
            if (action == "fight" || action == "Fight")
            {
                //monster attack
                Console.WriteLine("The monster attacks! " + playerName + " takes " + monsterDamage + " damage!");
                playerHealth = playerHealth - monsterDamage;
                Console.WriteLine(playerName + " has " + playerHealth + " health left!");

                //player attack
                Console.WriteLine(playerName + " attacks! the monster is defeated!");

            }
            else if (action == "flee" || action == "Flee")
            {
                //escape
                Console.WriteLine(playerName + " got out safley");

            }

        }
    }
}
