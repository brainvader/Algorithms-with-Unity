/// <summary>
/// Maximum of three numbers
/// </summary>
public class MaxThreeNumbers {

    /// <summary>
    /// Compare three elements with their values
    /// </summary>
    /// <param name="values">array of values</param>
    /// <returns>An element with the maximum value</returns>
    public static int Max(int[] values) {
        var maxIndex = 0;
        maxIndex = values[maxIndex] > values[1] ? maxIndex : 1;
        maxIndex = values[maxIndex] > values[2] ? maxIndex : 2;
        return maxIndex;
    }
}
