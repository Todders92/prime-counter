using System;
using System.Collections.Generic;
using PrimeShifting.Models;

namespace PrimeShifting 
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("Enter a number: ");
			int userNumber = int.Parse(Console.ReadLine());
			Prime userPrimes = new Prime(userNumber);
			userPrimes.SetCountList(userNumber);
			// Console.WriteLine(userPrimes._numberList[]);
			userPrimes.SetNonPrimeList(userNumber);
			userPrimes.ShowPrimeNumbers();
		}
	}
}