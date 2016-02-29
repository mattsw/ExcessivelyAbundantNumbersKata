namespace ExcessivelyAbundantNumbersKata.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class ProgramTests
    {
        [TestFixture]
        public class IsExcessiveNumber
        {
            private Func<int, bool> methodToTest;

            [TestFixtureSetUp]
            public void Setup()
            {
                methodToTest = Program.IsExcessiveNumber;
            }

            [TestCase(12)]
            [TestCase(18)]
            public void ExcessiveNumber_ShouldReturnTrue(int numberToTest)
            {
                Assert.IsTrue(methodToTest(numberToTest));
            }

            [TestCase(11)]
            [TestCase(13)]
            public void ExcessiveNumber_ShouldReturnFalse(int numberToTest)
            {
                Assert.IsFalse(methodToTest(numberToTest));
            }
        }
    }
}
