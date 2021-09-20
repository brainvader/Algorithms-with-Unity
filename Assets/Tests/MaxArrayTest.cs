using NUnit.Framework;


public class MaxArrayTest {

    [Test]
    [TestCase(1, 11, 20, 15, 9)]
    public void ReturnMaxValueFromArray(params int[] arr) {
        var got = MaxArray.Max(arr);
        var expected = 20;

        Assert.That(got, Is.EqualTo(expected));
    }
}
