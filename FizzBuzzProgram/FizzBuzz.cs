using System;
namespace FizzBuzz
{
	public static class Program
	{
		
		static int printout(int begRange, int endRange, int iDiv1, int iDiv2, string sOut1, string sOut2)
		{
			// Check if the inputs are valid
			if (begRange < 1)
			{
				Console.WriteLine("Beginning number must be >= 0");
				return 0;
			}

			if (endRange < begRange)
			{
				Console.WriteLine("Eng number must be <= To number");
				return 0;
			}

			if (iDiv1 < 1 || iDiv2 < 1)
			{
				Console.WriteLine("Divisors must be non zero");
				return 0;
			}

			if (string.IsNullOrEmpty(sOut1) || string.IsNullOrEmpty(sOut2))
			{
				Console.WriteLine("Strings cannot be empty");
				return 0;
			}

			for (int i = begRange; i <= endRange; i++)
			{
				int iMod1 = i % iDiv1;
				int iMod2 = i % iDiv2;
				if (iMod1 == 0)
				{
					Console.WriteLine(sOut1);
				}
				else if (iMod2 == 0)
				{
					Console.WriteLine(sOut2);
				}
				else if (i % (iMod1 * iMod2) == 0)
				{
					Console.WriteLine(sOut1 + " " + sOut2);
				}
				else
				{
					Console.WriteLine(i);
				}
			}
			return 0;
		}
	}

}
