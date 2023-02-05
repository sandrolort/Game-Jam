using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StaticPuzzleChecker : MonoBehaviour
{
    public int id;
    public UnityEvent onPuzzleComplete;
    void Start()
    {
        if (PuzzleChecker.isPuzzleComplete[id])
        {
            onPuzzleComplete.Invoke();
            gameObject.SetActive(false);
        }
    }
}
