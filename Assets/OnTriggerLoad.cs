using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerLoad : MonoBehaviour
{
    public int ScenID;

    private void OnTriggerEnter2D(Collider2D col)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(ScenID);
    }
}
