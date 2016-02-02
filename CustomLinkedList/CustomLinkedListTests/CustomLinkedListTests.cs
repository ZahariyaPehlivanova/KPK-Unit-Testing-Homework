namespace TestCustomLinkedList
{
    using CustomLinkedList;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class CustomLinkedListTests
    {
       [TestMethod]
       public void TestAddMethod_WithEmptyArray()
       {
           DynamicList<int> arr = new DynamicList<int>();
           arr.Add(1);
           Assert.AreEqual(1, arr.Count,"The adding method doesn't work correclty!");
       }

       [TestMethod]
       public void TestRemoveMethod_AddingAndRemovingObjects()
       {
           DynamicList<int> arr = new DynamicList<int>();
           arr.Add(1);
           arr.Add(2);
           arr.Add(3);
           arr.Add(4);
      
           arr.Remove(1);
           Assert.AreEqual(3,arr.Count,"The removing method doesn't work correclty!");
       }

        [TestMethod]
        public void TestRemoveMethod_WithEmptyArray_ShouldReturnNegativeValue()
        {
            DynamicList<int> arr = new DynamicList<int>();
            arr.Remove(1);
            Assert.AreEqual(-1, arr.Remove(1),"The Remove method doesn't remove objects correctly");
        }

        [TestMethod]
        public void TestRemoveMethod_WithNonExistingObject_ShouldReturnNegativeValue()
        {
            DynamicList<int> arr = new DynamicList<int>();
            arr.Add(1);
            arr.Add(2);

            Assert.AreEqual(-1, arr.Remove(3), "The Remove method shuld not remove non-existing objects!");
        }

        [TestMethod]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void TestRemoveAtMethod_WithNegativeIndex_ShouldThrow()
        {
            DynamicList<int> arr = new DynamicList<int>();
            arr.Add(1);

            arr.RemoveAt(-1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestRemoveAtMethod_WithBiggerIndex_ShouldThrow()
        {
            DynamicList<int> arr = new DynamicList<int>();
            arr.Add(1);
            arr.RemoveAt(2);
        }

        [TestMethod]
        public void TestObject_OnExistingIndex_ShouldReturnCorrectObject()
        {
            DynamicList<int> arr = new DynamicList<int>();
            arr.Add(1);

            Assert.AreEqual(1, arr[0],"The index is not correct!");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestObject_OnNonExistingIndex_ShouldThrow()
        {
            DynamicList<int> arr = new DynamicList<int>();

            arr[0] = 1;
        }

        [TestMethod]
        public void TestChangingObject_WithExistingOne_ShouldReturnCorrectValue()
        {
            DynamicList<int> arr = new DynamicList<int>();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);

            arr[2] = 2;
            Assert.AreEqual(2,arr[2],"The elements are not switched correctly!");
        }

        [TestMethod]
        [Ignore]
        public void TestIgnorTestAttribute_ShouldPassTest()
        {
            DynamicList<int> arr = new DynamicList<int>();
            arr.Add(1);
            arr.Add(2);

            Assert.AreEqual(arr.Contains(2), "The Ignor attribute doesn't work! :(");
        }



        [TestMethod]
        public void TestContainsMethod_WithEmptyArray_ShouldReturnBoolean()
        {
            DynamicList<int> arr = new DynamicList<int>();

            bool contains = arr.Contains(1);

            Assert.IsFalse(contains,"The Cointains method doesn't work correctly!");
        }

        [TestMethod]
        public void TestContainsMethod_WithExistingObject_ShouldReturnBoolean()
        {
            DynamicList<int> arr = new DynamicList<int>();
            arr.Add(1);
            arr.Add(2);

            bool contains = arr.Contains(2);

            Assert.IsTrue(contains, "The Cointains method doesn't work correctly!");
        }

        [TestMethod]
        public void TestIndexOfMethod_WithExistingObject_ShouldReturnCorrectValue()
        {
            DynamicList<int> arr = new DynamicList<int>();
            arr.Add(1);
            arr.Add(2);

           Assert.AreEqual(1,arr.IndexOf(2));
        }

        [TestMethod]
        public void TestIndexOfMethod_WithNonExistingObject_ShouldReturnCorrectValue()
        {
            DynamicList<int> arr = new DynamicList<int>();
            arr.Add(1);
            arr.Add(2);

            Assert.AreEqual(-1, arr.IndexOf(3));
        }
    } 
}
