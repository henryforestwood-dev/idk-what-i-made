using System;
using System.Linq;
using System.Collections.Generic;

namespace Coolultrakill
{

    class projectile
    {
        public int damage { get; set; }

        public projectile(int dmg)
        {
            damage = dmg;
        }

    }
    class v1
    {
        static public int health = 100;



    }

    class Program
    {
        static List<projectile> orb = new List<projectile>();


        static void Main()
        {

            void reuse(int b, int a) // b is total a is damage per object
            {
                int total = b * a;

                orb.Add(new projectile(total));

            }

            reuse(1, 25);
            reuse(4, 25);
            reuse(10, 5);

            foreach (projectile newdmg in orb)
            {

                Console.WriteLine($"{v1.health - newdmg.damage}");



            }

        }

    }
}
