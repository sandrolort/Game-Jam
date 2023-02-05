using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Serialization;

public class ButtonScript : MonoBehaviour
{
    public UnityEvent m_entryEvent;
    public UnityEvent m_exitEvent;

    public string[] tags;

    private void OnTriggerStay2D(Collider2D collision)
    {
        foreach (var tag in tags)
        {
            if (GameObject.FindWithTag(tag))
                m_entryEvent.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        foreach (var tag in tags)
        {
            if (GameObject.FindWithTag(tag))
                m_exitEvent.Invoke();
        }
    }
}
