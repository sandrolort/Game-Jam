using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowMaker : MonoBehaviour
{
    private GameObject shadow;
    public GameObject player;
    
    private bool isShadow = false;
    private Movement_SideScroller _movementSideScroller;
    private Movement_SideScroller _movementSideScroller1;

    private void Start()
    {
        _movementSideScroller1 = player.GetComponent<Movement_SideScroller>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (!isShadow)
            {
                if (shadow == null)
                {
                    shadow = Instantiate(player, player.transform.position, Quaternion.identity);
                    shadow.GetComponent<SpriteRenderer>().color = new Color(0.3f, 0, 0, 0.8f);
                    _movementSideScroller = shadow.GetComponent<Movement_SideScroller>();
                }

                _movementSideScroller1.isStationary = true;
                _movementSideScroller.isStationary = false;
                
                isShadow = true;
            }
            else
            {
                _movementSideScroller1.isStationary = false;
                _movementSideScroller.isStationary = true;
                isShadow = false;
            }
        }
    }
}