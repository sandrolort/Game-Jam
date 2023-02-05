using UnityEngine;
using UnityEngine.Events;

public class DoorScript : MonoBehaviour
{
    public UnityEvent m_tagEvent;
    public string tag;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        anim.SetBool("doorOpen", true);
    }
}
