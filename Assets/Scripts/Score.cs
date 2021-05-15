using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score {
    private int value;

    public int Value { get; }

    public void AddScore(int points) {
        value += points;
    }

    public void ResetScore() {
        value = 0;
    }
}
