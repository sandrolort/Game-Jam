using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BeautifulSceneViewer : MonoBehaviour
{
    public UnityEvent eventHandle;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            eventHandle.Invoke();
        }
    }
}
