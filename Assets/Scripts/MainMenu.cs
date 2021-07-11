using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void GameScene(string levelname)
    {
        SceneManager.LoadScene(levelname);     
    }

    public void Exit()
    {
        Application.Quit();
    }
}
