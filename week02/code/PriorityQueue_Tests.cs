using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue a single item with priority 5 and then dequeue it.
    // Expected Result: the item with priority 5 is returned.
    // Defect(s) Found: Basic functionality check
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 5);
        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item1", result);
    }

    [TestMethod]
    // Scenario: Enqueue three items with priorities 5, 4, and 8, respectively, and then dequeue them.
    // Expected Result: the item with priority 8 is returned first.
    // Defect(s) Found: The current implementation incorrectly compares priorities .
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 5);
        priorityQueue.Enqueue("Item2", 4);
        priorityQueue.Enqueue("Item3", 8);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item3", result); // Item3 has the highest priority
    }

    [TestMethod]
    // Scenario: Enqueue twi items with the same priority and dequeue them.
    // Expected Result: the item that was enqueued first should be returned.
    // Defect(s) Found: This is a test for FIFO behavior with equal priorities.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Item1", 4);
        priorityQueue.Enqueue("Item2", 4);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("Item1", result); // FIFO behavior for same priority
    }

    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: An InvalidOperationException is thrown.
    // Defect(s) Found: NO Defect found.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue()); 
    }
}