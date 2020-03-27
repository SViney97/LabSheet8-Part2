using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabSheet8_Part2;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            GameData db = new GameData();

            using (db)
            {
                ComputerGame CG1 = new ComputerGame()
                {
                    GameID = 1,
                    GameName = "Zelda",
                    GameConsole = "Switch"

                };

                Character C1 = new Character()
                {
                    CharacterID = 1,
                    CharacterName = "Link",
                    GameID = 1,
                    ComputerGame = CG1
                };

                ComputerGame CG2 = new ComputerGame()
                {
                    GameID = 2,
                    GameName = "MarioKart",
                    GameConsole = "Switch"

                };

                Character C2= new Character()
                {
                    CharacterID = 2,
                    CharacterName = "Princess Peach",
                    GameID = 2,
                    ComputerGame = CG2
                };
                Character C3 = new Character()
                {
                    CharacterID = 3,
                    CharacterName = "Princess Daisy",
                    GameID = 2,
                    ComputerGame = CG2
                };

                db.ComputerGames.Add(CG1);
                db.ComputerGames.Add(CG2);

                Console.WriteLine("Added to DB");

                db.Characters.Add(C1);
                db.Characters.Add(C2);
                db.Characters.Add(C3);
                Console.WriteLine("Added characters to DB");

                db.SaveChanges();
                Console.WriteLine("Saved");
            }
        }
    }
}
