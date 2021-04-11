using System;
using System.Text;

namespace GoogleCodeInterview
{
	class Program
	{
		// commit 2
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
		/// <summary>
		/// This methode converts a word to phonenumber: flower -> 356937
		/// +----+----+----+
		/// |  1 |  2 |  3 |
		/// |    | abc| def|
		/// +----+----+----+
		/// |  4 |  5 |  6 |
		/// | ghi| jkl| mno|
		/// +----+----+----+
		/// |  7 |  8 |  9 |
		/// |pqrs| tuv|wxyz|
		/// +----+----+----+
		/// </summary>
		/// <param name="word"></param>
		/// <returns></returns>
		private static string ConvertWordToPhoneNumber(string word)
		{
			StringBuilder phoneNumber = new();
			for (int i = 0; i < word.Length; i++) phoneNumber.Append(char2num[word[i] - 'a']);
			return phoneNumber.ToString();
		}
	}
}
