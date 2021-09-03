using System;
					
public class Program
{
	public static void Main()
	{
		double r = double.Parse(Console.ReadLine());
		double pi = 3.14159;
		double a = pi * Math.Pow(r, 2);
		
		Console.WriteLine("A={0}", a.ToString("F4"));
		
	}
}