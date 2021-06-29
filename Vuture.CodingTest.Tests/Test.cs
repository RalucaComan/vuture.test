using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vuture.CodingTest.Business;

namespace Vuture.CodingTest.Tests
{

    [TestClass]
    public class Test
    {
        public TaskHelper th = new TaskHelper();

        [TestMethod]
        public void TestTaskOne()
        {
            int expected = 5;
            int result = th.RunTaskOne();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTaskTwo()
        {
            bool expected = false ;
            bool result = th.RunTaskTwo();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTaskThreeA()
        {
            List<string> expected = new List<string>{ "dog: 2", "cat: 1", "large: 0", "total: 3" };
            List<string> result = th.RunTaskThreeA();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestTaskThreeB()
        {
            char[] delimiters = { ' ', ',', '.', ':', ';' };
            string ex = "I have a cat named M$$w and a dog name W$$f.I love the dog a lot. He is larger than a small horse.";
            string[] expected = ex.Split(delimiters);
            string[] result = th.RunTaskThreeB();

            Assert.AreEqual(expected, result);
        }

    }
}
