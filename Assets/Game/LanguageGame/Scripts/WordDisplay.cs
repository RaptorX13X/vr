using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class WordDisplay : MonoBehaviour
{
    [SerializeField] private Text textArea;
    [SerializeField] private Text pointArea;
    private int points;
    public int chosenNumber;
    private int previousNumber;
    public string[] animalStrings;
    public string[] translatedStrings;

    private void Start()
    {
        SetText();
        pointArea.text = points.ToString();
    }

    public void SetText()
    {
        randomizeNumber();
        textArea.text = animalStrings[chosenNumber];
    }

    private void randomizeNumber()
    {
        int newNumber;

        do
        {
            newNumber = Random.Range(0, animalStrings.Length);
        } while (newNumber == previousNumber);

        chosenNumber = newNumber;
        previousNumber = chosenNumber;
    }

    public void RightNumber()
    {
       SetText();
       points += 1;
       pointArea.text = points.ToString();
    }
}
