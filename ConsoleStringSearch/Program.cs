using System;
using System.Text;

namespace ConsoleStringSearch
{
	class Program
	{
		//					  convert char abcdefghijklmnopqrstuvwxyz to
		static readonly string char2num = "22233344455566677778889999";
		static void Main(string[] args)
		{
			Console.Write("Test stringsearch algoritm.\nOutput: ");
			ConsoleStringSearch();
		}

		private static void ConsoleStringSearch()
		{
			var phoneNumber = "3662277";
			string[] words = { "foo", "bar", "baz", "foobar", "emo", "cap", "car", "cat" };

			foreach (var word in words) if (phoneNumber.Contains(ConvertWordToPhoneNumber(word)))
				{
					Console.Write(word + ",");
				}
		}
		private static string ConvertWordToPhoneNumber(string word)
		{
			StringBuilder number = new();
			for (int i = 0; i < word.Length; i++) number.Append(char2num[word[i] - 'a']);
			return number.ToString();
		}
	}
}
