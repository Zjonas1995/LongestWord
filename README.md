# LongestWord
Program to find the the longest word and it's length from a sentence

----------- To execute Tests -----------
This project was written using the .net framework, so a pre-requisite will be to have .net sdk, and having visual studio while not necessary is suggested.

Using Visual Studio:
- Open project in Visual Studio 
- Open up Test Exporer tab. This can be found by clicking on the "Test" tab at the top toolbar of Visual Studio and then clicking Test Explorer, or by pressing ctrl + e, and then t
- Drop open tests, select desired tests to run (ctrl clicks + shift clicks work in this menu), right click, and select run tests

Using vstest.console.exe:
- Locate vstest.console.exe 
(Often may be located in "C:\Program Files (x86)\Microsoft Visual Studio\{Version}\TestAgent\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe")
- Locate LongestWordTests.dll (relative path will be  LongestWord\LongestWordTests\bin\Debug\netcoreapp3.1\LongestWordTests.dll)
Call vstest.console.exe with the LongestWordTests.dll as an argument
- If you want to filter which test to run you can add the argument /Tests:[test name] ie. /Tests:BaseCaseTest,EmptyStringTest 
