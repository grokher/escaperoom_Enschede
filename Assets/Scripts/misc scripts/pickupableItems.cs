using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupableItems : MonoBehaviour
{
    #region variables
    public GameObject Camera;
    public bool hasThisItem;
    public SaveToFile saveScript;
    #endregion
    private void Update()
    {
        PickUp();
    }

    public void PickUp()
    {
        if (Camera.GetComponent<MouseSelect>().activated && Camera.GetComponent<MouseSelect>().raycastHit.name == gameObject.name && !hasThisItem)
        {
            hasThisItem = true; // als je dus wilt checken of die deze item heeft: //itemObject.GetComponent<pickupableItems>().hasThisItem\\
            if(gameObject.name == "Key 1")
            {
                saveScript.Save(gameObject);
            }
            if (gameObject.tag == "Raam")
            {
                saveScript.Save(gameObject);
            }
            this.gameObject.SetActive(false);
            Camera.GetComponent<MouseSelect>().activated = false;
        }
    }
}