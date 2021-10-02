using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class ReverseArrayTest {
    const int MAX = 15;
    const int ARRAY_SIZE = 5;

    [Test]
    // [TestCaseSource(nameof(RandomArrays))]
    [TestCase(1, 5, 10, 7, 12)]
    public void ReverseArrayInOddCase(params int[] arr) {
        int arr_size = arr.Length;
        int firstElement = arr[0];
        int lastElement = arr[arr_size - 1];
        int middleElement = arr[arr_size / 2];

        int[] rev_arr = ReverseArray.Reverse(arr);
        Assert.That(firstElement, Is.EqualTo(rev_arr[arr_size - 1]));
        Assert.That(lastElement, Is.EqualTo(rev_arr[0]));
        Assert.That(middleElement, Is.EqualTo(rev_arr[arr_size / 2]));
    }

    [Test]
    [TestCase(1, 5, 10, 7, 12, 15)]
    public void ReverseArrayInEvenCase(params int[] arr) {
        int arr_size = arr.Length;
        Assert.That(arr.Length % 2, Is.Zero);
        int firstElement = arr[0];
        int lastElement = arr[arr_size - 1];
        Assert.That(firstElement, Is.EqualTo(1));

        int[] rev_arr = ReverseArray.Reverse(arr);
        Assert.That(firstElement, Is.EqualTo(rev_arr[arr_size - 1]));
        Assert.That(lastElement, Is.EqualTo(rev_arr[0]));
    }

    [Test]
    [TestCaseSource(nameof(RandomArrays))]
    public void ReverseArrayWithRandomValue(params int[] arr) {
        int arr_size = arr.Length;
        int firstElement = arr[0];
        int lastElement = arr[arr_size - 1];

        int[] rev_arr = ReverseArray.Reverse(arr);
        Assert.That(firstElement, Is.EqualTo(rev_arr[arr_size - 1]));
        Assert.That(lastElement, Is.EqualTo(rev_arr[0]));
    }

    static object[] RandomArrays = {
        GenRandomArray(Random.Range(2, 9)),
        GenRandomArray(Random.Range(2, 9)),
        GenRandomArray(Random.Range(2, 9))
    };

    static int[] GenRandomArray(int array_size = ARRAY_SIZE) {
        int[] randomArray = new int[array_size];
        for (int i = 0; i < array_size; i++) {
            randomArray[i] = Random.Range(0, MAX);
        }
        return randomArray;
    }
}
