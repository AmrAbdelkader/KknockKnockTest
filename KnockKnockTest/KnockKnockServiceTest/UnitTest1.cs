using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KnockKnockServiceTest.KnockKnockServiceReference;

namespace KnockKnockServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWhatIsYourToken()
        {
            KnockKnockServiceReference.RedPillClient serviceReference = new KnockKnockServiceReference.RedPillClient();
            serviceReference.WhatIsYourToken();
        }

        [TestMethod]
        public void TestFibonacciNumber()
        {
            KnockKnockServiceReference.RedPillClient serviceReference = new KnockKnockServiceReference.RedPillClient();
            long fibonacciNumber = serviceReference.FibonacciNumber(23);
        }

        [TestMethod]
        public void TestReverseString()
        {
            KnockKnockServiceReference.RedPillClient serviceReference = new KnockKnockServiceReference.RedPillClient();
            string reversedString = serviceReference.ReverseWords("Select");
        }

        [TestMethod]
        public void TestTriangleType()
        {
            KnockKnockServiceReference.RedPillClient serviceReference = new KnockKnockServiceReference.RedPillClient();
            TriangleType triangleType = serviceReference.WhatShapeIsThis(6,6,6);
        }

    }
}
