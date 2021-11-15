using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class JournalHandler : MonoBehaviour
{
    #region Variables 
    public int pageNumber;
    public GameObject[] Pages;
    GameObject Camera;
    bool ChangeOfPage = false;

    #endregion
    private void Awake()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    private void Update()
    {
        if (ChangeOfPage)
        {
            UpdatePage();
        }
    }
    void UpdatePage()
    {
        try
        {
            Pages[Camera.GetComponent<MouseSelect>().raycastHit.GetComponent<JournalPage>().pageNumber].SetActive(true);
        }
        catch
        {
            Debug.Log("Geen journalPage");
        }
    }
        

}
