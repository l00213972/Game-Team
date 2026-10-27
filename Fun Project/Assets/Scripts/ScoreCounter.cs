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
       scoreText.text = "Score: " + appleCounter;
    }
}
