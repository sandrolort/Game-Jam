using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
        string destination = Application.persistentDataPath + "/PuzzleComplete" + 0;
        FileStream file;
 
        if(File.Exists(destination)) File.Delete(destination);
        
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
