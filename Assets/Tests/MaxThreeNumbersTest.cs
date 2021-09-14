using NUnit.Framework;
using UnityEngine;
using TMPro;

public class MaxThreeNumbersTest {
    private GameObject element1, element2, element3;

    [SetUp]
    public void SetUp() {
        element1 = new GameObject("Element0");
        element1.AddComponent<TextMeshPro>();
        element1.GetComponent<TextMeshPro>().text = "1";
        element2 = new GameObject("Element1");
        element2.AddComponent<TextMeshPro>();
        element2.GetComponent<TextMeshPro>().text = "15";
        element3 = new GameObject("Element2");
        element3.AddComponent<TextMeshPro>();
        element3.GetComponent<TextMeshPro>().text = "9";
    }

    [Test]
    public void ReturnMaxOfThreeNumbers() {
        var values = new int[] {
            int.Parse(element1.GetComponent<TextMeshPro>().text),
            int.Parse(element2.GetComponent<TextMeshPro>().text),
            int.Parse(element3.GetComponent<TextMeshPro>().text)
        };

        var maxIndex = MaxThreeNumbers.Max(values);
        var got = values[maxIndex];
        var expected = 15;

        Assert.AreEqual(got, expected);
    }

    [TearDown]
    public void TearDown() {
        GameObject.DestroyImmediate(element1);
        GameObject.DestroyImmediate(element2);
        GameObject.DestroyImmediate(element3);
    }
}
