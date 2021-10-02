using NUnit.Framework;

public class MiddleIndexTest {
    [Test]
    [TestCase(1, 5, 10, 7, 12)]
    public void ReturnMidIndexInOddCase(params int[] arr) {
        int remainder = arr.Length % 2;
        Assert.That(remainder, Is.EqualTo(0));
        int midIndex = MiddleIndex.Middle(0, arr.Length - 1);
    }

    [Test]
    [TestCase(1, 5, 10, 7, 12, 15)]
    public void ReturnMidIndexInEvenCase(params int[] arr) {
        int remainder = arr.Length % 2;
        Assert.That(remainder, Is.Not.EqualTo(0));
    }
}
