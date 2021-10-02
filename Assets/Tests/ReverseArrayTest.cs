using System;
using NUnit.Framework;

public class ReverseArrayTest {
    const int MAX = 100;
    const int ARRAY_SIZE = 5;

    [Test]
    [TestCaseSource(nameof(RandomArray))]
    public void ReverseArrayOrder(int[] arr) {
        int firstElement = arr[0];
        int lastElement = arr[ARRAY_SIZE - 1];
        int middleElement = arr[ARRAY_SIZE / 2];

        int[] rev_arr = ReverseArray.Reverse(arr);
        Assert.That(firstElement, Is.EqualTo(rev_arr[ARRAY_SIZE - 1]));
        Assert.That(lastElement, Is.EqualTo(rev_arr[0]));
        Assert.That(middleElement, Is.EqualTo(rev_arr[ARRAY_SIZE / 2]));
    }

    static int[] RandomArray() {
        int[] randomArray = new int[ARRAY_SIZE];
        var rnd = new Random();
        for (int i = 0; i < ARRAY_SIZE; i++) {
            randomArray[i] = rnd.Next(MAX);
        }
        return randomArray;
    }
}
