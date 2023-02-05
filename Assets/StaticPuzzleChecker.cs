using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

public class StaticPuzzleChecker : MonoBehaviour
{
    public int id;
    public UnityEvent onPuzzleComplete;
    public GameObject puzzleComplete;
    void Start()
    {
        if (puzzleComplete.activeInHierarchy)
        {
            onPuzzleComplete.Invoke();
            gameObject.SetActive(false);
        }
    }
}
