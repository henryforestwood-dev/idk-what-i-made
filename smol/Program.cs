using System;
using Func;
					
public class Program
{
	public static void Main()
	{
		Printing c = new Printing();
		string a = "alice";
		c.cwrite($"Hello Hello {a}", 1);
		
		symb s = new symb(1);
		
		Console.WriteLine("Hello World");
	}
}