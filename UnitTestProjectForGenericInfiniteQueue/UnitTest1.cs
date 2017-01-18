using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HalloJoe.Collections.Generic;
using System.Collections.Generic;
using System.Text;

namespace UnitTestProjectForGenericInfiniteQueue
{
    [TestClass]
    public class UnitTest1
    {

        const string ALPHABET = "abcdefghijklmnopqrstuvwxyzæøå";

        [TestMethod]
        public void Test_Generic_InfiniteQueue()
        {
            InfiniteQueue<char> q = new InfiniteQueue<char>();
            char[] ca = ALPHABET.ToCharArray();
            foreach (var c in ca) q.Enqueue(c);
            char[] expected = (ALPHABET + ALPHABET).ToCharArray();
            List<char> test = new List<char>();
            for (var i = 0; i < ALPHABET.Length * 2; i++)
                test.Add(q.Dequeue());
            char[] actual = test.ToArray();

            Assert.AreEqual(string.Join("", expected), string.Join("", actual));
        }
    }
}
