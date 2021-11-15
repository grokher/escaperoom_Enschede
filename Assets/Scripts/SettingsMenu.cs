using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject OptionsPanel;
    public Camera mainCamera;

    public void openMenu()
    {
            OptionsPanel.SetActive(true);

        mainCamera.GetComponent<MouseSelect>().enabled = false;
    }

    public void closeMenu()
    {
        OptionsPanel.SetActive(false);

        mainCamera.GetComponent<MouseSelect>().enabled = true;
    }

    
    //pause mouseSelect open settings
    //return to game and unpause mouseSelect
    //quit.application
    //quit to mainMenu
    //invert mouseSelect
    //door warning when clicking
    //mouse sensitivity slider
}
