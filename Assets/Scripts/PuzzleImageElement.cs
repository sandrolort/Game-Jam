using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PuzzleImageElement : MonoBehaviour
{
    private int[] _rotats = { 0, 90, 180, 270 };

    public void Start()
    {
        int rand = Random.Range(0, _rotats.Length);
        transform.Rotate(0,0,_rotats[rand]);
    }
    public void OnMouseDown()
    {
        if (!PuzzleImageContainer.youWin)
        {
            transform.Rotate(0,0,90);
        }
    }
}