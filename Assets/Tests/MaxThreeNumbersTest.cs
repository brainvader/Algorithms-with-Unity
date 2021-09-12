using NUnit.Framework;

public class MaxThreeNumbersTest {
    [Test]
    public void ReturnMaxOfThreeNumbers() {
        int x_1 = 1, x_2 = 15, x_3 = 9;
        var maxOfThreeNumbers = new MaxThreeNumbers(x_1, x_2, x_3);
        var got = maxOfThreeNumbers.Max3();
        var expected = 15;

        Assert.AreEqual(got, expected);
    }
}
