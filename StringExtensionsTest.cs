using NUnit.Framework;
using Extensions.System;

/// <summary>
/// https://github.com/sixeyed/megacorp-extensions/wiki
/// </summary>
namespace Tests
{
    [TestFixture]
    public class StringExtensionsTest
    {
        [Test]
        public void ToTitleCaseTest()
        {
            var input = "foo ba";
            var expectedOutput = "Foo Ba";

            var result = input.ToTitleCase();

            Assert.AreEqual(expectedOutput, result);
        }
    }
}