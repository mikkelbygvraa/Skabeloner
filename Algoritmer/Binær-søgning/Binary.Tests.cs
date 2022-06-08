﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearch
{
    [TestClass]
    public class Binary_Tests
    {
        [TestMethod]
        public void TestBinarySearch()
        {
            var array = new int[] { 5, 12, 14, 20, 26, 36, 37, 43, 44, 46, 47, 50, 51, 53, 57, 78, 80, 92, 93, 95 };

            Console.WriteLine("Array:");
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0} ", array[i]);

            Console.WriteLine("\n");

            int res = Binary.BinarySearch(array, array[0]);
            Assert.AreEqual(0, res);

            res = Binary.BinarySearch(array, array[6]);
            Assert.AreEqual(6, res);

            res = Binary.BinarySearch(array, array[array.Length - 1]);
            Assert.AreEqual(array.Length - 1, res);

            res = Binary.BinarySearch(array, 91);
            Assert.AreEqual(-1, res);
        }
    }
}