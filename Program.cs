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
			int primes = userPrimes.GetPrimes(userNumber);
			Console.WriteLine(primes);
			// Console.WriteLine("These are the prime factors of your number: ");
		}
	}
}