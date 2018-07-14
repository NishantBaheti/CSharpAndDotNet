using System;

class absolutediff{
	static void Main(string[] args){
		int a=0;
		int b=0;
		int result=0;
		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());
		result= a-b;
		if (result<0){
			result *=(-1);
		}
		Console.WriteLine("{0}",result);
	}
}
