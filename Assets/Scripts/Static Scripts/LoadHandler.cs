using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LoadHandler
{
    public static void loadScene(string sceneName)
    {
        //Load a scene
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }
    public static void loadSceneAsync(string sceneName)
    {
        //Load a scene asynchronously
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName);
    }
    public static void loadSceneAdditive(string sceneName)
    {
        //Load a scene additively
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName, UnityEngine.SceneManagement.LoadSceneMode.Additive);
    }
    public static void loadSceneAdditiveAsync(string sceneName)
    {
        //Load a scene additively asynchronously
        UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(sceneName, UnityEngine.SceneManagement.LoadSceneMode.Additive);
    }
}