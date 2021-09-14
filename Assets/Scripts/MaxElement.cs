using UnityEngine;
using TMPro;

public class MaxElement : MonoBehaviour {

    /// <summary>
    /// Set up each label with random number
    /// </summary>
    /// <param name="labels">Label Objects</param>
    private void SetupLabels(TextMeshPro[] labels) {
        for (int i = 0; i < labels.Length; i++) {
            var num = Random.Range(0, 100);
            labels[i].text = num.ToString();
        }
    }

    /// <summary>
    /// Find maximum of three labels
    /// </summary>
    /// <param name="labels">three labels</param>
    /// <returns>Label with the largest value</returns>
    private TextMeshPro FindMax(TextMeshPro[] labels) {
        var values = new int[] {
            int.Parse(labels[0].text),
            int.Parse(labels[1].text),
            int.Parse(labels[2].text)
        };
        var maxIndex = MaxThreeNumbers.Max(values);
        return labels[maxIndex];
    }

    void Start() {

        // Get labels for each element
        var labels = this.transform.GetComponentsInChildren<TextMeshPro>();
        this.SetupLabels(labels);

        var maxElement = this.FindMax(labels).transform.parent;
        var elementRenderer = maxElement.GetComponent<Renderer>();
        elementRenderer.material.SetColor("_Color", Color.yellow);
    }

    void Update() {

    }
}
