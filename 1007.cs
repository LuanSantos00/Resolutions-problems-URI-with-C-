using System;
					
public class Program
{
	public static void Main()
	{	
		int A = Convert.ToInt32(Console.ReadLine());
		int B = Convert.ToInt32(Console.ReadLine());
		int C = Convert.ToInt32(Console.ReadLine());
		int D = Convert.ToInt32(Console.ReadLine());
		int diff = ((A * B) - (C * D));
		Console.WriteLine("DIFERENCA = {0}", diff.ToString());
	}
}