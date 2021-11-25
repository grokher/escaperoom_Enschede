using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class lockedDoor : MonoBehaviour
{
    #region variables
    public GameObject linkedItem;
    public GameObject Camera;
    public TextMeshProUGUI lockedDoorText;
    public bool unlocked = false;
    bool textMessage = false;

    public skyboxRotation skyboxChange;
    #endregion
    private void Awake()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
    }
    private void Update()
    {
       StartCoroutine("Tutorial");
    }

    IEnumerator Tutorial()
    {
        if (Camera.GetComponent<MouseSelect>().activated && Camera.GetComponent<MouseSelect>().raycastHit.name == gameObject.name && linkedItem.GetComponent<pickupableItems>().hasThisItem)
        {
            unlocked = true;
            Camera.GetComponent<MouseSelect>().activated = false;
            lockedDoorText.text = "De deur is nu open!";
            skyboxChange.NextAreaOnClick();
            yield return new WaitForSeconds(1.5f);
        }
        else if (Camera.GetComponent<MouseSelect>().activated && Camera.GetComponent<MouseSelect>().raycastHit.name == gameObject.name && !linkedItem.GetComponent<pickupableItems>().hasThisItem)
        {
            lockedDoorText.text = "De deur zit op slot, je moet een sleutel vinden!";
            yield return new WaitForSeconds(3f);
        }
        if (linkedItem.GetComponent<pickupableItems>().hasThisItem && !unlocked && !textMessage)
        {
            textMessage = true;
            lockedDoorText.text = "Je hebt de sleutel Gevonden!";
            yield return new WaitForSeconds(3f);
            if(textMessage == true)
            {
                lockedDoorText.text = "";
            }
        }
    }
}