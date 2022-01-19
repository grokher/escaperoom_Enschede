using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class popUpText : MonoBehaviour
{
    public TextMeshProUGUI popupText;
    public GameObject itemPickup;
    bool textShown1, textShown2, textShown3;

    private void Update()
    {
        StartCoroutine(TutorialText());
        //StartCoroutine(RaamText());
        StartCoroutine(KeyText());
    }

    IEnumerator TutorialText()
    {
        if (itemPickup.GetComponent<pickupableItems>().hasThisItem && !textShown1)
        {
            popupText.text = "je hebt een Logboek ontvangen";
            yield return new WaitForSeconds(2.5f);
            popupText.text = "";
            textShown1 = true;
        }
    }

    /*IEnumerator RaamText()
    {
        if (itemPickup.GetComponent<pickupableItems>().hasThisItem && !textShown2 && gameObject.CompareTag("Raam"))
        {
            popupText.text = "je hebt een raam ontvangen";
            yield return new WaitForSeconds(2.5f);
            popupText.text = "";
        }
    }*/

    IEnumerator KeyText()
    {
        if(itemPickup.GetComponent<pickupableItems>().hasThisItem && !textShown3)
        {
            popupText.text = "je hebt de sleutel voor de mozaiek kamer ontvangen";
            yield return new WaitForSeconds(2.5f);
            popupText.text = "";
            textShown3 = true;
        }
    }
}
