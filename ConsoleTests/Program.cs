using System;

namespace ConsoleTests
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
			var tests = new AppiumTests.Test ();
			tests.BeforeAll ();
			tests.ComputeSumTestCase ();
		}
	}
}
