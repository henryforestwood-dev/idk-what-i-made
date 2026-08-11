using System;

namespace img {
	
	public class txt {
		public string c {get; set;} = "あ";
		public string c2 {get; set;} = "こ";
		public string c3 {get; set;} = "な";
		public void reuse(int a) {
			if (a <= 1) {
				Console.Write(c);
			}else if (a == 2) {
				Console.Write(c2);
			}else if (a >= 3) {
				Console.Write(c3);
			}
		}
	}
}