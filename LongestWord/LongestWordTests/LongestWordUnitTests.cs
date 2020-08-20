using Microsoft.VisualStudio.TestTools.UnitTesting;
using LongestWord; 

namespace LongestWordTests
{
	[TestClass]
	public class LongestWordUnitTests
	{
		[TestMethod]
		public void EmptyStringTest()
		{
			string str = "";
			string expectedReturn = "";

			WordInfo emptyStringResult = WordInfo.LongestWordMethods.LongestWord(str);
			Assert.AreEqual(expectedReturn, emptyStringResult.WordName, string.Format("The expected result: \"{0}\" did not match the returned value: \"{1}\"", expectedReturn, emptyStringResult.WordName));
			Assert.AreEqual(expectedReturn.Length, emptyStringResult.WordLength, string.Format("The expected length: \"{0}\" did not match the returned length: \"{1}\"", expectedReturn, emptyStringResult.WordLength));

		}

		[TestMethod]
		public void SingleWordTest()
		{
			string str = "SimpleTest";
			string expectedReturn = "SimpleTest";

			WordInfo emptyStringResult = WordInfo.LongestWordMethods.LongestWord(str);
			Assert.AreEqual(expectedReturn, emptyStringResult.WordName, string.Format("The expected result: \"{0}\" did not match the returned value: \"{1}\"", expectedReturn, emptyStringResult.WordName));
			Assert.AreEqual(expectedReturn.Length, emptyStringResult.WordLength, string.Format("The expected length: \"{0}\" did not match the returned length: \"{1}\"", expectedReturn, emptyStringResult.WordLength));
		}

		[TestMethod]
		public void BaseCaseTest()
		{
			string str = "The cow jumped over the moon.";
			string expectedReturn = "jumped";

			WordInfo emptyStringResult = WordInfo.LongestWordMethods.LongestWord(str);
			Assert.AreEqual(expectedReturn, emptyStringResult.WordName, string.Format("The expected result: \"{0}\" did not match the returned value: \"{1}\"", expectedReturn, emptyStringResult.WordName));
			Assert.AreEqual(expectedReturn.Length, emptyStringResult.WordLength, string.Format("The expected length: \"{0}\" did not match the returned length: \"{1}\"", expectedReturn, emptyStringResult.WordLength));
		}
	}
}
