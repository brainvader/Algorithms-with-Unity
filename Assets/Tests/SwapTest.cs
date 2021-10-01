using NUnit.Framework;

public class SwapTest {
    // A Test behaves as an ordinary method
    [Test]
    [TestCase(1, 2)]
    [TestCase(5, 10)]
    public void ReturnSwappedValues(int a, int b) {
        var (x, y) = Swap.SwapTuple((a, b));

        Assert.That(a, Is.EqualTo(x));
        Assert.That(b, Is.EqualTo(y));
    }
}
