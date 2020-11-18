using NUnit.Framework;
using DataStructures.DoubleLinkedList;
namespace DoubleLinkedListTests
{
    public class Tests
    {
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { }, new int[] { 4 }, 4)]
        [TestCase(new int[] { 3 }, new int[] { 3, 4 }, 4)]
        [TestCase(new int[] { 1, int.MaxValue, int.MinValue, 3 }, new int[] { 1, int.MaxValue, int.MinValue, 3, int.MaxValue }, int.MaxValue)]

        public void AddTests(int[] array, int[] expectedArray, int value)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.Add(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, 4 }, new int[] { 4 })]
        [TestCase(new int[] { }, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 3 }, new int[] { 3 }, new int[] { })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3, int.MaxValue, int.MinValue }, new int[] { int.MaxValue, int.MinValue })]
        public void AddArrayTests(int[] array, int[] expectedArray, int[] addArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.Add(addArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 1, 2, 3 }, 4)]
        [TestCase(new int[] { }, new int[] { 4 }, 4)]
        [TestCase(new int[] { 3 }, new int[] { 4, 3 }, 4)]
        [TestCase(new int[] { 1, int.MaxValue, int.MinValue, 3 }, new int[] { int.MaxValue, 1, int.MaxValue, int.MinValue, 3 }, int.MaxValue)]
        [TestCase(new int[] { 2 }, new int[] { 4, 2 }, 4)]
        public void AddFirstTests(int[] array, int[] expectedArray, int value)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.AddFirst(value);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 1, 2, 3 }, new int[] { 4 })]
        [TestCase(new int[] { 0 }, new int[] { 4, 5, 6, 0 }, new int[] { 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { int.MaxValue, int.MinValue, 1, 2, 3 }, new int[] { int.MaxValue, int.MinValue })]
        [TestCase(new int[] { }, new int[] { 3 }, new int[] { 3 })]

        public void AddArrayFirstTests(int[] array, int[] expectedArray, int[] addArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expectedArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.AddFirst(addArray);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, int.MaxValue, new int[] { int.MaxValue, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, 10, new int[] { 1, 2, 10, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, -9, new int[] { 1, 2, 3, 4, -9, 5 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 4, -100, new int[] { -1, -2, -3, -4, -100, -5 })]
        [TestCase(new int[] { 1 }, 0, 0, new int[] { 0, 1 })]
        [TestCase(new int[] { }, 0, 0, new int[] { 0 })]
        public void AddByIndex(int[] array, int index, int value, int[] expArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.AddByIndex(index, value);

            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, new int[] { int.MaxValue, 6, 7 }, new int[] { int.MaxValue, 6, 7, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 10, 11 }, new int[] { 1, 2, 10, 11, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { -9 }, new int[] { 1, 2, 3, 4, -9, 5 })]
        [TestCase(new int[] { 1 }, 0, new int[] { 0, 2, 3 }, new int[] { 0, 2, 3, 1 })]
        [TestCase(new int[] { }, 0, new int[] { 0 }, new int[] { 0 })]
        public void AddArrayByIndex(int[] array, int index, int[] addArray, int[] expArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.AddByIndex(index, addArray);

            Assert.AreEqual(expected, actual);

        }
    }
}