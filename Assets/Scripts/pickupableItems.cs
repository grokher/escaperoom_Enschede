using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupableItems : MonoBehaviour
{
    #region variables
    public GameObject Camera;
    public bool hasThisItem;
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
            this.gameObject.SetActive(false);
            Camera.GetComponent<MouseSelect>().activated = false;
        }
    }
}