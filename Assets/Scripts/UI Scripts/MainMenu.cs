using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject OptionsPanel;

    public void QuitButton()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Intro Scene");
    }

    public void OpenOptionsMenu()
    {
        OptionsPanel.SetActive(true);
    }

    public void OpenCredits()
    {
        //SceneManager.LoadScene(); // load credits scene
    }
}
