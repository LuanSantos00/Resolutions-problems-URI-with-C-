using System;
					
public class Program
{
	public static void Main()
	{	
		int number = Convert.ToInt32(Console.ReadLine());
		int val = Convert.ToInt32(Console.ReadLine());
		double taxa = double.Parse(Console.ReadLine());
		double salario = val * taxa;
		
		Console.WriteLine("NUMBER = {0}", number.ToString());
		Console.WriteLine("SALARY = U$ {0}", salario.ToString("F2"));
	}
}