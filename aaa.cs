using System;
using System.Threading;

public class enemy
{


    public string model;
    public bool living = false, nonliving = false;


    public void display(int hp, int damage, string _name)
    {
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
        else
        {
            Console.WriteLine("No one appeared -");
            nonliving = false; living = false;
        }

    }


}

class Program
{


    static void Main()
    {

        enemy maliciousface = new enemy();
        enemy minosprime = new enemy();
        enemy gabriel = new enemy();
        enemy v2 = new enemy();


        Thread.Sleep(700);

        maliciousface.type(2); maliciousface.display(400, 0, "Maurice\n");
        Thread.Sleep(500);
        minosprime.type(4); minosprime.display(1500, 0, "Minos prime\n");
        Thread.Sleep(400);
        gabriel.type(3); gabriel.display(1200, 0, "Gabriel\n");
        Thread.Sleep(300);
        v2.type(5); v2.display(800, 0, "V2\n");
        Thread.Sleep(200);



    }

}
