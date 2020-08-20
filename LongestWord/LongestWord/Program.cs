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

			/* Assumptions
			 * - The he prompt wanted this method to return both the string and the length, so I decided to utilize a WordInfo object. In most similar cases
			 *   I would just return a string and then call string.Length where the length is needed.
			 * - If passed a null string, I will return null. The assumption is that null further null handling will occur wherever the method is called if
			 *   it is needed. (An alternative could be to return an empty string with length 0 in the null case).
			 * - A sentence with two equal length longest words will return the earlier occurence. This can be easily adjusted by changing the logic to search for
			 *   >= instead of >
			 * - By this method, a word is anything other than a space. An additional method was made that splits by other characters for proof of concept, if that
			 *   was the intention, but the assumption I am working with is that a word is any character, seperated by a space.
			 */
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

			/* Assumptions
			 * - Right now this method splits words by anything that isn't a space, period, comma, colon, semi-colon, !, and ?. This can be expanded on easily
			 *   if a more specific spec of what is or isn't a word is provided. 
			 */
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
