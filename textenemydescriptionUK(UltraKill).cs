using System;
using System.Threading;

namespace woah {
    public class enemy
    {
    
    
        public string model;
        public bool living = false, nonliving = false;
    
    
        public void display(int typ, int hp, int damage, string _name)
        {
            type(typ);
            int _result = hp - damage;
            Console.WriteLine($"Health : {_result}");
            Console.WriteLine($"Name : {_name}");
    
            if (_result <= 0)
            {
                Console.WriteLine($"{_name} had died");
            }
        }
    
        public void type(int typ)
        {
            if (typ == 1)
            {
                Console.WriteLine("Husk -");
                living = true; nonliving = false;
    
            }
            else if (typ == 2)
            {
                Console.WriteLine("Hell mass -");
                nonliving = true; living = false;
    
            }
            else if (typ == 3)
            {
                Console.WriteLine("Supreme angel -");
                living = true; nonliving = false;
    
            }
            else if (typ == 4)
            {
                Console.WriteLine("Prime soul -");
                living = true;
                nonliving = true;
            }
            else if (typ == 5)
            {
                Console.WriteLine("Machine -");
                nonliving = true; living = false;
            }
            else if (typ <= 0 || typ >= 6)
            {
                Console.WriteLine("NONE");
            }
    
        }
    
    
    }
    
    class Program
    {
    
    
        static void Main()
        {
            ConsoleKeyInfo input = Console.ReadKey(true);

            switch(input.Key) {
                case ConsoleKey.Enter:
                    Environment.Exit(0);
            }
    
            enemy maliciousface = new enemy();
            enemy minosprime = new enemy();
            enemy gabriel = new enemy();
            enemy v2 = new enemy();
    
    
            Thread.Sleep(700);
    
            maliciousface.display(2, 400, 0, "Maurice\n");
            Thread.Sleep(500);
            minosprime.display(4, 1500, 0, "Minos prime\n");
            Thread.Sleep(400);
            gabriel.display(3, 1200, 0, "Gabriel\n");
            Thread.Sleep(300);
            v2.display(5, 800, 0, "V2\n");
            Thread.Sleep(200);
        }
    
    }
}
// Written in phone btw
