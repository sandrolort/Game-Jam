using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;

public class PuzzleImageContainer : MonoBehaviour
{
    [SerializeField] private Transform[] pictures;
    public static bool youWin;
    public static int Progress;
    public int id;

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
            PuzzleChecker.isPuzzleComplete[id] = true;
            Progress = 16;
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