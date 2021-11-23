using Microsoft.VisualStudio.TestTools.UnitTesting;
using P3;
using System;

namespace PrimeNumsUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsPrimeNumTest1()
        {
            //Arrange 
            bool expectedResult = false;
            bool actualResult;
            //int numTest = 1;
            PrimeNums pm = new PrimeNums(1);

            //Act 
            actualResult = pm.IsPrimeNum(1);

            //Assert 
            Assert.IsTrue((actualResult == expectedResult), "Calculation incorrect.");
        }

        [TestMethod]
        public void IsPrimeNumTest2()
        {
            //Arrange 
            bool expectedResult = true;
            bool actualResult;
            PrimeNums pm = new PrimeNums(101);

            //Act 
            actualResult = pm.IsPrimeNum(101);

            //Assert 
            Assert.IsTrue((actualResult == expectedResult), "Calculation incorrect.");
        }

        [TestMethod]
        public void IsPrimeNumTest3()
        {
            //Arrange 
            bool expectedResult = false;
            bool actualResult;
            //int numTest = 1;
            PrimeNums pm = new PrimeNums(0);

            //Act 
            actualResult = pm.IsPrimeNum(0);

            //Assert 
            Assert.IsTrue((actualResult == expectedResult), "Calculation incorrect.");
        }
    }
}
