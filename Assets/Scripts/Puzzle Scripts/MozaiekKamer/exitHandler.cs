using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitHandler : MonoBehaviour
{
    public GameObject BackButton;
    public GameObject MozaiekSelect;
    public GameObject MasterMozaiek;
    public GameObject NewCameraObject;
    public GameObject player;
    public GameObject MozaiekUI;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void exit()
    {
        NewCameraObject.SetActive(false);
        player.SetActive(true);
        MasterMozaiek.SetActive(false);
        MozaiekSelect.SetActive(true);
        MozaiekUI.SetActive(false);
    }
}
