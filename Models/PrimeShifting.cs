using System;
using System.Collections.Generic;

namespace PrimeShifting.Models
{
	public class Prime
	{
		private int _userNumber;
		public List<int> _numberList = new List<int> {};
		public List<int> _nonPrimeList = new List<int> {};

		public Prime(int userNumber)
		{
			_userNumber = userNumber;
		}
		
		public void SetCountList(int userNumber)
		{
			List<int> numberList = new List<int>(){};
			for (int i = 1; i <= userNumber; i++) 
			{
				numberList.Add(i);
				_numberList = numberList;
			}
		}
		public void SetNonPrimeList(int userNumber)
		{
			List<int> nonPrimeList = new List<int>(){};
			for (int i = 2; i <= userNumber; i++)
			{
				for (int j = i+1; j < _numberList.Count; j++)
				{
					if (_numberList[j] % i == 0)
					{
						_numberList[j] = 0;
					}
				}
			}
		}
		public void ShowPrimeNumbers() 
		{
			for (int i = 0; i < _numberList.Count; i++)
			{
				if (_numberList[i] != 0)
				{
				Console.WriteLine(_numberList[i]);
				}
			}
		}
	}
}