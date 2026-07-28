using System;
using System.Linq;
using System.Collections.Generic;

namespace blacksoultop1fan
{
    public class game
    {
        public string name2 { get; set; }
        public string genre2 { get; set; }
        public game(string name, string genre)
        {
            name2 = name;
            genre2 = genre;

        }


    }

    class Program
    {
        static void Main()
        {
            game[] favgame = new game[3];

            favgame[0] = new game("Red Hood Woods", "Erotic/Rpg");
            favgame[1] = new game("Blacksouls I", "Erotic/Rpg");
            favgame[2] = new game("Blacksouls II", "Erotic/Rpg");



            foreach (game gaem in favgame)
            {
                Console.WriteLine($"Name:{gaem.name2} Genre:{gaem.genre2}");
            }

            List<game> favgame2 = new List<game>();

            favgame2.Add(new game("Ultrakill", "Shooter"));

            foreach (game gaem2 in favgame2)
            {
                Console.WriteLine($"hm my other fav is {gaem2.name2}");
            }




        }


    }
}
