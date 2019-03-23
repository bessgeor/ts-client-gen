using System;
using System.Linq;
using NUnit.Framework;

namespace TSClientGen.Tests
{
	public static class TextAssert
	{
		public static void ContainsLine(string expectedLine, string output)
		{
			Assert.Contains(
				expectedLine,
				output.Split(Environment.NewLine),
				$"Expected line '{expectedLine}' not found\nActual output: \n{output}");
		}
	}
}