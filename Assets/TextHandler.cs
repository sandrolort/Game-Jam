using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextHandler : MonoBehaviour
{
    private string text = "";
    private int currentLetter = 0;
    //textmeshpro text
    public TextMeshProUGUI textMesh;

    private void Start()
    {
        InvokeRepeating("FixedUpdateCustom", 0, 0.1f);
    }

    void FixedUpdateCustom()
    {
        currentLetter++;
        if (currentLetter > text.Length)
        {
            currentLetter = text.Length;
        }
        textMesh.text = text.Substring(0, currentLetter);
    }
    
    public void setText(string text)
    {
        this.text = text;
        currentLetter = 0;
    }
}
