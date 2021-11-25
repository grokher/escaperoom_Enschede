using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnRaycastHit : MonoBehaviour
{
    public skyboxRotation skyboxChange;
    public Camera mainCamera;
    private TutorialScript TutorialScript;

    public void Awake()
    {
        gameObject.GetComponent<TutorialScript>();
    }

    public void Update()
    {
        if (mainCamera.GetComponent<MouseSelect>().activated && mainCamera.GetComponent<MouseSelect>().raycastHit.name == gameObject.name)
        {
            skyboxChange.NextAreaOnClick();
        }
        //Debug.Log(mainCamera.transform.eulerAngles);
    }
}
