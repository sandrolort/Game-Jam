using UnityEngine;
using UnityEngine.Events;

public class Lever : MonoBehaviour
{
    public UnityEvent m_tagEvent;
    public string tag;
    
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(GameObject.FindWithTag(tag) && Input.GetKey(KeyCode.F))
            m_tagEvent.Invoke();
    }
}
