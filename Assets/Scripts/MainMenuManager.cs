using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void EndGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
