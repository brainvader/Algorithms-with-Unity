/// <summary>
/// Maximum of three numbers
/// </summary>
public class MaxThreeNumbers {
    private int max;

    private int b, c;


    /// <summary>
    /// Take three numbers and return maximum of them
    /// </summary>
    /// <param name="a">Initial maximum value</param>
    /// <param name="b"></param>
    /// <param name="c"></param>
    public MaxThreeNumbers(int a, int b, int c) {
        this.max = a;
        this.b = b;
        this.c = c;
    }

    /// <summary>
    /// Compare three numbers
    /// </summary>
    /// <returns>Maximum value of three numbers</returns>
    public int Max3() {
        this.max = this.b > this.max ? this.b : this.max;
        this.max = this.c > this.max ? this.c : this.max;
        return this.max;
    }
}
