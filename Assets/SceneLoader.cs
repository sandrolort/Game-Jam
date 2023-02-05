using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public int SceneNumber;
    private void OnTriggerEnter2D(Collider2D col)
    {
        //Load the scene
        if (col.gameObject.CompareTag("Player"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneNumber);
        }
    }
}
