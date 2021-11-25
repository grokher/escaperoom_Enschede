using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxRotationTutorial : MonoBehaviour
{
    public TextMesh tutorialsText;
    public skyboxRotation skyboxChange;
    public Camera mainCamera;
    public pickupableItems itemObject;
    public void Update()
    {
        if (mainCamera.GetComponent<MouseSelect>().activated && mainCamera.GetComponent<MouseSelect>().raycastHit.name == gameObject.name && itemObject.GetComponent<pickupableItems>().hasThisItem)
        {
            skyboxChange.NextAreaOnClick();
        }
        else if(mainCamera.GetComponent<MouseSelect>().activated && mainCamera.GetComponent<MouseSelect>().raycastHit.name == gameObject.name && !itemObject.GetComponent<pickupableItems>().hasThisItem)
        {
            tutorialsText.text = "Oh wacht eens even je moet \n eerst de sleutel vinden";
        }
    }
}
