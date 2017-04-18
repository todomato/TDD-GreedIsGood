using System;
using NUnit.Framework;
using ClassLibrary1;

namespace GreedisGood
{
    [TestFixture()]
    public class UnitTest1
    {
        [Test()]
        public void ShouldBeWorthless()
        {
            Assert.AreEqual(0, Kata.Score(new int[] { 2, 3, 4, 6, 2 }));
        }

        [Test]
        public static void ShouldValueTriplets()
        {
            Assert.AreEqual(400, Kata.Score(new int[] { 4, 4, 4, 3, 3 }), "Should be 400");
        }
    }
}
