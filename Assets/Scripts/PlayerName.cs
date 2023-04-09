using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    public string theName;
    public TextMeshProUGUI characterNameText;
    void Start()
    {
        // Karakter adýný ekranda göstermek için text objesini sprite'ýn üstüne yerleþtir
        Vector3 namePos = Camera.main.WorldToScreenPoint(transform.position);
        characterNameText.transform.position = namePos + new Vector3(0, 1.5f, 0);
        characterNameText.SetText(theName);
    }
    public void UpdateName(string newName)
    {
        theName = newName;
        characterNameText.SetText(theName);
    }
}
