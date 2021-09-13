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
    /// Compare two labels with thier values
    /// </summary>
    /// <param name="label1">label 1</param>
    /// <param name="label2">label 2</param>
    /// <returns>Label with a larger value</returns>
    private TextMeshPro Max(TextMeshPro label1, TextMeshPro label2) {
        return int.Parse(label1.text) > int.Parse(label2.text) ? label1 : label2;
    }

    /// <summary>
    /// Find maximum of three labels
    /// </summary>
    /// <param name="labels">three labels</param>
    /// <returns>Label with the largest value</returns>
    private TextMeshPro FindMax(TextMeshPro[] labels) {
        var max = labels[0];
        max = this.Max(max, labels[1]);
        max = this.Max(max, labels[2]);
        return max;
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
