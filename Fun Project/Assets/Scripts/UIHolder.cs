using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHolder : MonoBehaviour
{
    public Image firstHealthSlot;
    public Image secondHealthSlot;
    public Image thirdHealthSlot;


    public Sprite fullHealth;
    public Sprite missingHealth;

    public static int playerHealth = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth >= 3)
        {
            firstHealthSlot.sprite = fullHealth;
            secondHealthSlot.sprite = fullHealth;
            thirdHealthSlot.sprite = fullHealth;
        }
        else if (playerHealth == 2)
        {
            firstHealthSlot.sprite = fullHealth;
            secondHealthSlot.sprite = fullHealth;
            thirdHealthSlot.sprite = missingHealth;
        }
        else if (playerHealth == 1)
        {
            firstHealthSlot.sprite = fullHealth;
            secondHealthSlot.sprite = missingHealth;
            thirdHealthSlot.sprite = missingHealth;
        }
        else if (playerHealth == 0)
        {
            firstHealthSlot.sprite = missingHealth;
            secondHealthSlot.sprite = missingHealth;
            thirdHealthSlot.sprite = missingHealth;
        }
    }
}
