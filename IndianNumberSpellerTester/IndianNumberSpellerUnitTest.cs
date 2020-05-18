using IndianNumberSpeller;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace IndianNumberSpellerTester
{
    [TestFixture]
    public class IndianNumberSpellerUnitTest
    {
        NumberSpeller numberSpeller = new NumberSpeller();
        [Test]
        public void DoNothing()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void CheckIfaNumberIsWholeNumberOrNot()
        {
            Assert.Throws<ArgumentException>(() => numberSpeller.SpellANumber(-1));
        }

        [Test]
        public void CheckIfBasicresponseIsReturned()
        {
            string expectedResult = "zero";
            var result = numberSpeller.SpellANumber(0);
            Assert.AreNotEqual(expectedResult, result);
        }
    }
}
