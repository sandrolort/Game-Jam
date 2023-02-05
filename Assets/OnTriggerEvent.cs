using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEvent : MonoBehaviour
{
    public UnityEvent eventHandle;
    private void OnTriggerEnter2D(Collider2D col)
    {
        eventHandle.Invoke();
    }
}
