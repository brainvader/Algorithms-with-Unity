using NUnit.Framework;


public class MaxArrayTest {

    [Test]
    public void ReturnMaxValueFromArray() {
        var got = MaxArray.Max(1, 11, 20, 15, 9);
        var expected = 20;

        Assert.That(got, Is.EqualTo(expected));
    }
}
