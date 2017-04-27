using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabWork1;

namespace LabWork1.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompareIntDigits_10less20()
        {
            //arrange 
            int fistDidits = 10;
            int lastDigits = 20;
            int lessresult = 0;            

            //action
            lessresult = Program.compareIntDigits(fistDidits, lastDigits);

            //assert 
            Assert.AreEqual(lessresult, -1);

        }

        [TestMethod]
        public void CompareIntDigits_20bigger10()
        {
            //arrange 
            int fistDidits = 10;
            int lastDigits = 20;
            
            int biggerResult = 0;

            //action
            biggerResult = Program.compareIntDigits(lastDigits, fistDidits);

            //assert 
            Assert.AreEqual(biggerResult, 1);

        }

        [TestMethod]
        public void CompareIntDigits_10equals10()
        {
            //arrange 
            int fistDidits = 10;
            int lastDigits = 10;

            int result = 0;

            //action
            result = Program.compareIntDigits(lastDigits, fistDidits);

            //assert 
            Assert.AreEqual(result, 0);
        }
    }
}
