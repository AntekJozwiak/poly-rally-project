using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Rally()
    {
        SceneManager.LoadScene("Game");
    }

    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }

    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Select");
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void DuneDash()
    {
        SceneManager.LoadScene("Game Dune");
    }
    public void Space()
    {
        SceneManager.LoadScene("Space");
    }
}
