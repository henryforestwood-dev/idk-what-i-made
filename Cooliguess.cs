using System;
using System.Linq;
using System.Collections.Generic;


namespace lazyproject
{
    class v1
    {
        public int v1_hp { get; set; } = 100; // absolutelu useless



        public v1(int hpgame)
        {
            v1_hp = hpgame;
        }
    }

    class enemies
    {
        public int en_hp { get; set; }
        public string name { get; set; }


        public enemies(string enem, int enhp)
        {
            name = enem;
            en_hp = enhp;

        }

    }
    class bullet
    {
        public int dmg { get; set; }

        public bullet(int dmg2)
        {
            dmg = dmg2;

        }
    }

    class Program
    {

        static void Main()
        {
            void triggerphase2()
            {

            }

            List<enemies> Husks = new List<enemies>();
            List<enemies> Maurice = new List<enemies>();

            Maurice.Add(new enemies("Malicious faces ", 160));
            Husks.Add(new enemies("Minos king husk ", 1200));



            foreach (enemies ab in Maurice)
            {

                Console.WriteLine($"{ab.name}{ab.en_hp}");
            }
            foreach (enemies ac in Husks)
            {
                Console.WriteLine($"{ac.name} {ac.en_hp}");

            }


            // Absolutely No idea what to add im on school btw

        }
    }
}
