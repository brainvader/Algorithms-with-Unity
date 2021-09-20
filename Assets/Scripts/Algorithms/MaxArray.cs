/// <summary>
/// Maximum of array
/// </summary>
public class MaxArray {
    public static int Max(params int[] values) {
        int max = values[0];
        for (int i = 1; i < values.Length; i++) {
            max = max > values[i] ? max : values[i];
        }
        return max;
    }
}
