using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class skyboxRotationLock : MonoBehaviour
{
    public GameObject mozaiekArrow;
    public GameObject torenArrow;
    public GameObject torenKey;
    public GameObject Raam;
    public TextMeshProUGUI popUpText;
    bool archiveKey = false;

    public void Update()
    {
        if (torenKey.GetComponent<pickupableItems>().hasThisItem)
        {
            torenArrow.GetComponent<OnRaycastHit>().enabled = true;
            mozaiekArrow.GetComponent<OnRaycastHit>().enabled = true;
        }
        else 
        {
            StartCoroutine(keyText());
        }

    }

    IEnumerator keyText()
    {
        if (!torenKey.GetComponent<pickupableItems>().hasThisItem && Camera.main.GetComponent<MouseSelect>().hitObject.name == torenArrow.name)
        {
            popUpText.text = "je moet eerst de sleutel en het raam vinden voordat je hier uit kan gaan";
            yield return new WaitForSeconds(2.5f);
            popUpText.text = "";
        }
        
    }
}
