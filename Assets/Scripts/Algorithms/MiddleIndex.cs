using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddleIndex {
    static public int Middle(int low, int high) {
        return low + (high - low) / 2;
    }
}
