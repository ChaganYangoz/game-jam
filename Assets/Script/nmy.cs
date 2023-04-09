using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class nmy : MonoBehaviour
{
    public TMP_InputField inputField;
    public TMP_Text textDisplay;

    void nickname()
    {
        // InputField ve Text bileþenlerinin referansýný sakla
        inputField = GetComponent<TMP_InputField>();
        textDisplay = GetComponent<TMP_Text>();
    }

    public void StoreName()
    {
        string theName = inputField.text;
        textDisplay.text = "Welcome to the game, " + theName + "!";
    }
}
