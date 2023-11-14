using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcherManager : MonoBehaviour
{
    public string firstScene;
    public string secondScene;

    private string currentScene;

    void Start()
    {
        currentScene = firstScene;
    }

    public void ToggleScene()
    {
        string targetScene = (currentScene == firstScene) ? secondScene : firstScene;

        SceneManager.LoadScene(targetScene);

        currentScene = targetScene;
    }
}
