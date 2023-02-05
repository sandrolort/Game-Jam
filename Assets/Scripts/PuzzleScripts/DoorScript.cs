using UnityEngine;
using UnityEngine.Events;

public class DoorScript : MonoBehaviour
{
    private Animator anim;
    private Collider2D col;

    private void Start()
    {
        anim = GetComponentInParent<Animator>();
        col = GetComponent<Collider2D>();
    }

    public void open()
    {
        anim.SetBool("doorOpen", true);
        col.enabled = false;
    }
    public void close()
    {
        anim.SetBool("doorOpen", false);
        col.enabled = true;
    }
}
