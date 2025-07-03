using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordButton : MonoBehaviour
{
    [SerializeField] private WordDisplay display;
    [SerializeField] private int wordNumber;
    [SerializeField] private Text textDisplay;

    private void Start()
    {
        textDisplay.text = display.translatedStrings[wordNumber];
    }

    public void ButtonPress()
    {
        if (wordNumber == display.chosenNumber)
        {
            display.RightNumber();
        }
    }
}
