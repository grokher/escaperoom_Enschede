using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongObject : MonoBehaviour
{
    public GameObject eventsystem;
    
    
    // Update is called once per frame
    void Update()
    {
        if (Camera.main.GetComponent<MouseSelect>().raycastHit.name == gameObject.name)
        { 
            eventsystem.GetComponent<ZDVCounter>().panelCounter++;
            Debug.Log(eventsystem.GetComponent<ZDVCounter>().panelCounter);
            gameObject.SetActive(false);
        }

    }
}
