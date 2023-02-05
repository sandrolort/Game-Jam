using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using UnityEngine;
using UnityEngine.Events;

public class PuzzleImageContainer : MonoBehaviour
{
    [SerializeField] private Transform[] pictures;
    public static bool youWin;
    public static int Progress;
    public GameObject puzzleComplete;
    public int id;
    
    public UnityEvent OnWin;

    // Start is called before the first frame update
    void Start()
    {
        youWin = false;
    }

    // Update is called once per frame
    void Update()
    {
        print(checkWin());
        if (checkWin())
        {
            youWin = true;
            print("you won!!");
            
            
            OnWin.Invoke();
            Progress = 16;
            this.enabled = false;
        }
    }

    bool checkWin()
    {
        for (int i = 0; i < pictures.Length; i++)
        {
            if (pictures[i].rotation.z > Math.Abs(0.1f))
            {

                print($"False at {i}");
                //todo fix this
                Progress = i;
                
                return false;
            }
        }
        
        return true;
    }
}