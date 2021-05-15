using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life{

    private int value;

    public int Value { get; }

    public Life(int startValue) {
        value = startValue;
    }

    /// <summary>
    /// Adds more lives for the player
    /// </summary>
    /// <param name="lives">how many to add (defaults to 1 if no value given)</param>
    public void Add(int lives= 1) {
        value += lives;
    }

    public void Lose() {
        value--;
    }
}