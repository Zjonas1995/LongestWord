using System;
using System.Text.RegularExpressions;
namespace LongestWord
{
	public class WordInfo
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

		public class LongestWordMethods
		{
			public static void Main(string[] args)
			{
				string s = "The cow jumped over the moon.";;
				WordInfo testWordInfo = LongestWord(s);

				Console.WriteLine(String.Format("Longest word in the string: \"{0}\" Length of the word: {1}", testWordInfo.WordName, testWordInfo.WordLength));
			}

			public static WordInfo LongestWord(string str)
			{
				WordInfo longestWordInfo = new WordInfo();
				
				//check for null case, it is expected that there were be handling of a return null case in whatever method calls this
				if (str == null)
				{
					return null;
				}

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

			public static WordInfo LongestWordRegex(string str)
			{
				WordInfo longestWordInfo = new WordInfo();

				//check for null case, it is expected that there were be handling of a return null case in whatever method calls this
				if (str == null)
				{
					return null;
				}

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
