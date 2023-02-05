using System;
using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    public UnityEvent m_entryEvent;
    public UnityEvent m_exitEvent;
    public GameObject InteractionText;
    
    private bool isOn = false;
    private bool isCollided = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isCollided)
        {
            isOn = !isOn;
            if (isOn)
            {
                m_entryEvent.Invoke();
            }
            else
            {
                m_exitEvent.Invoke();
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        isCollided = true;
        InteractionText.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        isCollided = false;
        InteractionText.SetActive(false);
    }
}
