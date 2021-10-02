public class ReverseArray {
    static public int[] Reverse(int[] original) {
        int[] reversedArray = original.Clone() as int[];
        int arraySize = original.Length;
        for (int i = 0; i < arraySize / 2; i++) {
            int pairIndex = arraySize - i - 1;
            (reversedArray[i], reversedArray[pairIndex]) = (
                original[pairIndex],
                original[i]);
        }
        return reversedArray;
    }
}
