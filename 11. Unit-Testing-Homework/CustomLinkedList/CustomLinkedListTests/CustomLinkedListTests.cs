namespace TestCustomLinkedList
{
    using CustomLinkedList;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    class CustomLinkedListTests
    {
       [TestMethod]
       public void TestAdd()
       {
           DynamicList<int> arr = new DynamicList<int>();
           arr.Add(1);
           Assert.AreEqual(1, arr.Count);
       }
      //
      // [TestMethod]public void TestRemove()
      // {
      //     DynamicList<int> arr = new DynamicList<int>();
      //     arr.Add(1);
      //     arr.Add(2);
      //     arr.Add(3);
      //     arr.Add(4);
      //
      //     arr.Remove(1);
      //     Assert.AreEqual(3,arr.Count);
      // }

        //public int Remove(T item)
        // {
        // Find the element containing the searched item
        //    int currentIndex = 0;
        //    ListNode currentNode = this.head;
        //    ListNode prevNode = null;
        //    while (currentNode != null)
        //    {
        //        if (object.Equals(currentNode.Element, item))
        //        {
        //            break;
        //        }
        //
        //        prevNode = currentNode;
        //        currentNode = currentNode.NextNode;
        //        currentIndex++;
        //    }
        //
        //    if (currentNode != null)
        //    {
        //        // The element is found in the list -> remove it
        //        RemoveListNode(currentNode, prevNode);
        //        return currentIndex;
        //    }
        //
        //    // The element is not found in the list -> return -1
        //    return -1;
        //}
    } 
}
