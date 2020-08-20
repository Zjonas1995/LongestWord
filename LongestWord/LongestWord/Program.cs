using System;
using System.Text.RegularExpressions;

namespace LongestWord
{
	class WordInfo
	{
		public string WordName
		{
			set;
			get;
		}
		public int WordLength
		{
			set;
			get;
		}

		class Program
		{
			static WordInfo LongestWord(string str)
			{
				WordInfo longestWordInfo = new WordInfo();
				string[] strSplit = str.Split(" ");

				longestWordInfo.WordName = strSplit[0];
				longestWordInfo.WordLength = strSplit[0].Length;


				foreach (string s in strSplit)
				{
					if (s.Length > longestWordInfo.WordLength)
					{
						longestWordInfo.WordName = s;
						longestWordInfo.WordLength = s.Length;
					}
				}
				return longestWordInfo;
			}

			static void Main(string[] args)
			{
				string s = "The cow jumped over the moon.";
				WordInfo testWordInfo = LongestWord(s);

				Console.WriteLine(String.Format("Longest word in the string: \"{0}\" Length of the word: {1}", testWordInfo.WordName, testWordInfo.WordLength));
			}

			static WordInfo LongestWordRegex(string str)
			{
				WordInfo longestWordInfo = new WordInfo();
				//string[] result = Regex.Matches(s, "\\w+('(s|d|t|ve|m))?").Cast<Match>().Select(x => x.Value).ToArray();

				string splitOn = @"[\s.,;!?:]+";

				string[] strSplit = Regex.Split(str, splitOn);
				longestWordInfo.WordName = strSplit[0];
				longestWordInfo.WordLength = strSplit[0].Length;

				foreach (string s in strSplit)
				{
					if (s.Length > longestWordInfo.WordLength)
					{
						longestWordInfo.WordName = s;
						longestWordInfo.WordLength = s.Length;
					}
				}

				return longestWordInfo;
			}
		}
	}
}
