using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoaderDumb : MonoBehaviour
{
    public int SceneNumber;
    public void loadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneNumber);
    }
    
    public void loadSceneSuffering()
    {
        //load scene 7 (puzzle complete)
        UnityEngine.SceneManagement.SceneManager.LoadScene(7);
    }
}