using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextCopy : MonoBehaviour
{
    [SerializeField] private Text textToCopy;
    [SerializeField] private Text textArea;

    private void Update()
    {
        textArea.text = textToCopy.text;
    }
}
