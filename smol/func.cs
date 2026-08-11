using System;
using img;

namespace Func {
	public class symb {
		txt ar = new txt();
		public symb(int a) {
			ar.reuse(a);
		}
	}
	public class Printing {
		
		public string a {get; set;}
		public int c = 0;
		public int v = 315215;
		
		public void cwrite(string b,int d) { // for strings only
			a = b;
			c = d;
			
			if (c <= 3) {
				Console.WriteLine($"{a}");
			} else {
				Console.WriteLine(v);
			}
		}
		
	}
}