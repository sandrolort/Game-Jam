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
}