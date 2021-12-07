using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burgerZaalUnlock : MonoBehaviour
{
    public GameObject eventHandler;
    public Camera cameraMain;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public  void Update()
    {
        if (cameraMain.GetComponent<MouseSelect>().activated && cameraMain.GetComponent<MouseSelect>().raycastHit.name == gameObject.name)
        {
            Debug.Log("UHAFLIBALFHVAFJHBAKF");
            eventHandler.GetComponent<BurgerzaalLock>().tutorialComplete = true;
        }
    }
}
