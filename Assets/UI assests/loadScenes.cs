using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScenes : MonoBehaviour
{
    public void exit()
    {
        Application.Quit();
    }
    public void loadGame()
    {
        SceneManager.LoadScene(1);
    }
    public void pausar()
    {
        Time.timeScale = 0f;
    }
    public void despausar()
    {
        Time.timeScale = 1.0f;
    }
}
