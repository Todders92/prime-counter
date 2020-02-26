namespace PrimeShifting.Models
{
	public class Prime
	{
		private int _userNumber;

		public Prime(int userNumber)
		{
			_userNumber = userNumber;
		}
		public int GetPrimes(int userNumber)
		{
			return userNumber*2;
		}
	}
}