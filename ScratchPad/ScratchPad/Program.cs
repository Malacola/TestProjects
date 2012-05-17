using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScratchPad
{
	class Program
	{
		static void Main(string[] args)
		{
			PalindromeTest();
		}

		private static void PalindromeTest()
		{
			var palindrome = "racecar";
			var notAPalindrome = "palindrome";

			if (IsPalindromeSansLinqMine(palindrome))
				Console.WriteLine(palindrome + " is a palindrome!");

			if (!IsPalindromeSansLinqMine(notAPalindrome))
				Console.WriteLine(notAPalindrome + "is not a palindrome!");
			else
				Console.WriteLine(notAPalindrome + " is a palindrome! Wait that's not quite right...");
		}

		private static bool IsPalindromeMine(string input)
		{
			var forwards = input.Trim();
			var backwards = forwards.Reverse();
			return backwards.SequenceEqual(forwards);
			
			#region BAD
			//if (backwards.SequenceEqual(forwards))
			//    return true;
			//return false; 
			#endregion
		}

		private static bool IsPalindromeSansLinqMine(string input)
		{
			var forwards = input.Replace(" ", "");
			var backArray = new char[forwards.Length];
			var length = forwards.Length - 1;

			for (int i = 0; i <= length; i++)
				backArray[i] = forwards[length - i];

			var backwards = new string(backArray);
			return backwards.Equals(forwards);
		}

		private static bool IsPalindromeLINQINTERNETS(string input)
		{
			return Enumerable.SequenceEqual(input.ToCharArray(), input.ToCharArray().Reverse());
		}

		private static bool IsPalindromeSansLinqINTERNETS(string input)
		{
			for (int i = 0; i < input.Length / 2; i++)
				if (input[i] != input[input.Length - 1 - i]) return false;
			return true;
		}
	}
}
