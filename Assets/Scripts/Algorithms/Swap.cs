using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swap {
    public static (int, int) SwapTuple((int, int) t) {
        return (t.Item2, t.Item1);
    }
}
