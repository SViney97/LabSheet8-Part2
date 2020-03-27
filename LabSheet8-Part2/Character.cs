using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet8_Part2
{
    public class Character
    {
        public int CharacterID { get; set; }
        public string CharacterName { get; set; }

        public int GameID { get; set; }
        public virtual ComputerGame ComputerGame { get; set; }

    }

    public class ComputerGame
    {
        public int GameID { get; set; }
        public string GameName { get; set; }
        public string GameConsole { get; set; }

        public virtual List<Character> Characters { get; set; }
    }

    public class GameData: DbContext
    {
        public GameData() : base("MyGameData") { }
        public DbSet<Character>Characters{ get; set; }
        public DbSet<ComputerGame>ComputerGames{ get; set; }
    }
}
