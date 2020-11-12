using NUnit.Framework;
using DataStructures;
namespace DataStructures_Tests
{
    public class Tests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, 6 }, 6)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, 25 }, 25)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, 0 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5, -1 }, -1)]
        [TestCase(new int[] { }, new int[] { 6 }, 6)]
        public void AddTests(int[] array, int[] expectedArray, int value)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Add(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 0, 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 25, 1, 2, 3, 4, 5 }, 25)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 90, 1, 2, 3, 4, 5 }, 90)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { -1, 1, 2, 3, 4, 5 }, -1)]
        [TestCase(new int[] { }, new int[] { 6 }, 6)]
        public void AddFirstTests(int[] array, int[] expectedArray, int value)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddFirst(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 0, 2, 3, 4, 5 }, 1, 0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 25, 4, 5 }, 3, 25)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3, 4, 90, 5 }, 4, 90)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { -1, 1, 2, 3, 4, 5 }, 0, -1)]
        [TestCase(new int[] { }, new int[] { 6 }, 0, 6)]
        public void AddByIndexTest(int[] array, int[] expectedArray, int index, int value)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.AddByIndex(index, value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] {  2, 3, 4, 5 }, new int[] {  2, 3, 4, 5, 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] {  2, 3, 4, 5 }, new int[] {  2, 3, 4, 5, 101, 202, 203 }, new int[] { 101, 202, 203 })]
        [TestCase(new int[] {  2, 3, 4, 5 }, new int[] {  2, 3, 4, 5, -101, -102, 103 }, new int[] { -101, -102, 103 })]
        [TestCase(new int[] { 2, 3, 4, 5 }, new int[] {  2, 3, 4, 5, 0, 303 }, new int[] { 0, 303 })]
        [TestCase(new int[] {0 }, new int[] {0, 1, 2,3 }, new int[] { 1, 2, 3 })]


        public void Add(int[] array, int[] expectedArray, int[] addArray)
        {
            ArrayList expected = new ArrayList(expectedArray);
            ArrayList actual = new ArrayList(array);
            actual.Add(addArray);
            Assert.AreEqual(expected, actual);
        }
    }
}