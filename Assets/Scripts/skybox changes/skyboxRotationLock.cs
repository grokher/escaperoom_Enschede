using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class skyboxRotationLock : MonoBehaviour
{
    public GameObject mozaiekArrow;
    public GameObject torenKey;
    bool archiveKey = false;

    public void Update()
    {
        if (torenKey.GetComponent<pickupableItems>().hasThisItem)
        {
            mozaiekArrow.GetComponent<OnRaycastHit>().enabled = true;
        }
    }
}
