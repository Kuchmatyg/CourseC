using NUnit.Framework;
using Повторение;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Повторение.Tests
{
    [TestFixture()]
    public class KataTests
    {
        [Test, Order(1)]
        public void DuplicateCountTest()
        {
            Assert.That(Kata.DuplicateCount(""), Is.EqualTo(0));
            Assert.That(Kata.DuplicateCount("abcde"), Is.EqualTo(0));
            Assert.That(Kata.DuplicateCount("aabbcde"), Is.EqualTo(2));
            Assert.That(Kata.DuplicateCount("aabBcde"), Is.EqualTo(2), "should ignore case");
            Assert.That(Kata.DuplicateCount("Indivisibility"), Is.EqualTo(1));
            Assert.That(Kata.DuplicateCount("Indivisibilities"), Is.EqualTo(2), "characters may not be adjacent");
        }

        [Test, Order(1)]
        public void IsValidWalkTest()
        {
            Assert.That(Kata.IsValidWalk(new string[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }), Is.True, "should return true");
            Assert.That(Kata.IsValidWalk(new string[] { "w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e" }), Is.False, "should return false");
            Assert.That(Kata.IsValidWalk(new string[] { "w" }), Is.False, "should return false");
            Assert.That(Kata.IsValidWalk(new string[] { "n", "n", "n", "s", "n", "s", "n", "s", "n", "s" }), Is.False, "should return false");
        }

        
        [Test]
        [Order(1)]
        public void DigPowTest1()
        {
            Assert.That(Kata.digPow(89, 1), Is.EqualTo(1));
        }
        [Test]
        [Order(2)]
        public void DigPowTest2()
        {   
            Assert.That(Kata.digPow(92, 1), Is.EqualTo(-1));
        }
        [Test]
        [Order(3)]
        public void DigPowTest3()
        {
            Assert.That(Kata.digPow(46288, 3), Is.EqualTo(51));
        }


        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(500, "D")]
        [TestCase(1000, "M")]
        [TestCase(1954, "MCMLIV")]
        [TestCase(1990, "MCMXC")]
        [TestCase(2008, "MMVIII")]
        [TestCase(2014, "MMXIV")]
        public void SolutionTest(int value, string expected)
        {
            Assert.That(Kata.Solution(value), Is.EqualTo(expected));
        }

        [Test]
        [Order(1)]
        public void MoveZeroesTest()
        {
            int[] expected = new int[] { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0 };
            Assert.That(Kata.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }), Is.EqualTo(expected));
        }

        private static void DoTest(int input, int expected)
        {
            int actual = Kata.CountBits(input);
            Assert.That(actual, Is.EqualTo(expected), "for n = " + input);
        }

        [Test, Order(1)]
        public void FixedTests()
        {
            DoTest(0, 0);
            DoTest(4, 1);
            DoTest(7, 3);
            DoTest(12525589, 11);
            DoTest(3811, 8);
            DoTest(392902058, 17);
            DoTest(1044, 3);
            DoTest(10030245, 10);
            DoTest(89, 4);
            DoTest(674259, 10);
            DoTest(Int32.MaxValue, 31);
        }

        [Test, Order(1), Description("test")]
        public void Rot13Test1()
        {
            var actualOutput = Kata.Rot13("test");
            Assert.That(actualOutput, Is.EqualTo("grfg"), String.Format("Input: test, Expected Output: grfg, Actual Output: {0}", actualOutput));
        }

        [Test, Order(2), Description("Test")]
        public void Rot13Test2()
        {
            var actualOutput = Kata.Rot13("Test");
            Assert.That(actualOutput, Is.EqualTo("Grfg"), String.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", actualOutput));
        }

        [TestCase(new[] { 1, 2, 2, 2 }, ExpectedResult = 1)]
        [TestCase(new[] { -2, 2, 2, 2 }, ExpectedResult = -2)]
        [TestCase(new[] { 11, 11, 14, 11, 11 }, ExpectedResult = 14)]
        public int GetUniqueTest(IEnumerable<int> numbers)
        {
            return Kata.GetUnique(numbers);
        }

        [Test, Order(1)]
        public void removNbTest()
        {
            List<long[]> r = new List<long[]> {
                new long[] { 15, 21 },
                new long[] { 21, 15 }
            };
            Assert.That(Kata.removNb(26), Is.EqualTo(r));
        }
    }
}