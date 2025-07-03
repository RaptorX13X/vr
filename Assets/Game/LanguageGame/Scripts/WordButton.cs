using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class WordButton : MonoBehaviour
{
    [SerializeField] private WordDisplay display;
    [SerializeField] private int wordNumber;
    [SerializeField] private Text textDisplay;
    [SerializeField] private Transform parent;

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
        else
        {
            parent.DOPunchRotation(Vector3.up * 5f, 1f);
        }
    }
}
