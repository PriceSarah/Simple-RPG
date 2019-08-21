using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple__RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates the game and holds the whole thing
            Game game = new Game();
            //This calls the game to start
            game.Start();
        }
    }
}
