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
        public void AddByIndexTests(int[] array, int index, int value, int[] expArray)
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
        public void AddArrayByIndexTest(int[] array, int index, int[] addArray, int[] expArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.AddByIndex(index, addArray);

            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 },  new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 },  new int[] { -1, -2, -3, -4  })]
        [TestCase(new int[] { 1 },  new int[] {  })]
        public void RemoveTests(int[] array,  int[] expArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.Remove();

            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] {  }, new int[] { })]
        public void RemoveTestsNegative(int[] array, int[] expArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
                actual.Remove(); 
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 2, 3 },2)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] { -1, -2 },3)]
        [TestCase(new int[] { 1 }, new int[] { },1)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] {  }, 5)]

        public void RemoveArrayTests(int[] array, int[] expArray,int quantity
            )
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.Remove(quantity);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1,2}, new int[] { },3)]
        [TestCase(new int[] {  }, new int[] { }, 3)]

        public void RemoveArrayTestsNegative(int[] array, int[] expArray,int quantity)
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
                actual.Remove(quantity);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] {  2, 3, 4 ,5})]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] {  -2, -3, -4,-5 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveFirstTests(int[] array, int[] expArray)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.RemoveFirst();

            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { }, new int[] { })]
        public void RemoveFirstTestsNegative(int[] array, int[] expArray)
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
                actual.RemoveFirst();
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] {  3,4,5 }, 2)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] { -4,-5 }, 3)]
        [TestCase(new int[] { 1 }, new int[] { }, 1)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] { }, 5)]

        public void RemoveFirstArrayTests(int[] array, int[] expArray, int quantity
            )
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.RemoveFirst(quantity);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2 }, new int[] { }, 3)]
        [TestCase(new int[] { }, new int[] { }, 3)]

        public void RemoveFirstArrayTestsNegative(int[] array, int[] expArray, int quantity)
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
                actual.RemoveFirst(quantity);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 },0)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] { -1,-2, -3, -4 },4)]
        [TestCase(new int[] { 1 }, new int[] { },0)]
        public void RemoveByIndexTests(int[] array, int[] expArray, int index)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.RemoveByIndex(index);

            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { }, new int[] { },0)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] {1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1,2, 3, 4, 5 }, -5)]

        public void RemoveByIndexNegative(int[] array, int[] expArray, int index)
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
                actual.RemoveByIndex(index);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();

        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] {  4, 5 }, 0,3)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] {  }, 0,5)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] { -1, -2, -3, -4 }, 4,1)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, new int[] { -1, -2 }, 2, 3)]
        [TestCase(new int[] { 1 }, new int[] { }, 0,1)]
        public void RemoveByIndexTests(int[] array, int[] expArray, int index, int quantity)
        {
            DoubleLinkedList expected = new DoubleLinkedList(expArray);
            DoubleLinkedList actual = new DoubleLinkedList(array);
            actual.RemoveByIndex(index,quantity);

            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { }, new int[] { }, 0, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 }, 5, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5 }, -5, 1)]

        public void RemoveByIndexNegative(int[] array, int[] expArray, int index, int quantity)
        {
            DoubleLinkedList actual = new DoubleLinkedList(array);
            try
            {
                actual.RemoveByIndex(index, quantity);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
            [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, 0)]
            [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, 2)]
            [TestCase(new int[] { 1, 2, 3, 4, 5,6 }, 5, 4)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, 4)]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, -1, 0)]
            [TestCase(new int[] { 1 }, 1, 0)]
            public void GetIndexByValueTest(int[] array, int value, int expected)
            {

                DoubleLinkedList doubleLinkedList = new DoubleLinkedList(array);
                int actual = doubleLinkedList.GetIndexByValue(value);

                Assert.AreEqual(expected, actual);
            }
            [TestCase(new int[] { }, 0, 0)]
            public void GetIndexByValueTestNegative(int[] array, int value, int expected)
            {
            DoubleLinkedList doubleLinkedList = new DoubleLinkedList(array);
            try
            {
                    doubleLinkedList.GetIndexByValue(value);
                }
                catch
                {
                    Assert.Pass();
                }
                Assert.Fail();
            }
        }
    }
