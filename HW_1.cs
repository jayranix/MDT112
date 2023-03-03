using System;

class Program
{
	static void Main(string[] args)
	{
		Console.Write("Input your password : ");
		string password = Console.ReadLine();
		Console.Write("Input your codename : ");
		double codename = int.Parse(Console.ReadLine());
		double currentnumber;
		double B1 = Math.Floor(codename / 100000);
		currentnumber = Password % 100000;
		double B2 = Math.Floor(currentnumber / 10000);
		currentnumber = currentnumber % 10000;
		double B3 = Math.Floor(currentnumber / 1000);
		currentnumber = currentnumber % 1000;
		double B4 = Math.Floor(currentnumber / 100);
		currentnumber = currentnumber % 100;
		double B5 = Math.Floor(currentnumber / 10);
		currentnumber = currentnumber % 10;
		double B6 = currentnumber;

		if (code == "CIA")
		{
			if (B6 % 3 == 0 && B5! = 1 && B5! = 3 && B5! = 5 && B3 >= 6 && B3! = 8)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}
			return;
		}
		if (code == "FBI")
		{
			if (B1 >= 4 && B1 <= 7 && B4 % 2 == 0 && B4! = 6 && B2 % 2! = 0)
			{
				Console.WriteLine("True");
			}
			else
			{
				Console.WriteLine("False");
			}
			return;
		}
		if (code == "NSA")
		{
			if (30 % B6 == 0 && B4 % 3 == 0 && B4 % 2! = 0)
			{
				if (B1==7 || B2==7 || B3 == 7 || B4 ==7 || B5==7 || B6==7)
				{
					Console.WriteLine("True");
				}
				else
				{
					Console.WriteLine("False");
				}
			}
			else
            {
				Console.WriteLine("False");
			}
			return;
		}
		Console.WriteLine("False");
	}
}

