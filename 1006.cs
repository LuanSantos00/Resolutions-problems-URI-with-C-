using System;
					
public class Program
{
	public static void Main()
	{	
		double A = double.Parse(Console.ReadLine());
		double B = double.Parse(Console.ReadLine());
		double C = double.Parse(Console.ReadLine());
		double media = ((A*2)+(B*3)+(C*5))/10;
		Console.WriteLine("MEDIA = {0}", media.ToString("F1"));
	}
}