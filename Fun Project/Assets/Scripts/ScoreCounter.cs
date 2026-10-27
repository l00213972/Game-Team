using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public static int appleCounter; // Not actually apples
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + appleCounter;
    }

    public static void AddApples()
    {
        appleCounter++;
    }

}
