using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialScript : MonoBehaviour
{
    public GameObject TutorialArea;
    public GameObject itemPickup;
    public GameObject bookPickup;
    public GameObject inspectTool;
    public TextMesh tutorialsText;
    public TextMeshProUGUI pickupText;
    public bool Key;
    public bool pickingupText;

    private void Update()
    {
        StartCoroutine("tutorialScript");
        bookInspect();
    }

   IEnumerator tutorialScript()
   {
        if (itemPickup.GetComponent<pickupableItems>().hasThisItem)
        {
            tutorialsText.text = "je hebt de sleutel gevonden \n maak nu de deur open"; // \n = newline \t = tab \b = backspace
            Key = true;
            if(Key == true && !pickingupText)
            {
                pickupText.text = "Je hebt een logboek ontvangen";
                yield return new WaitForSeconds(3f);
                pickupText.text = "";
                pickingupText = true;
            }
        }
        yield return new WaitForSeconds(2f); 
   }
    public void bookInspect()
    {
        if (bookPickup.GetComponent<pickupableItems>().hasThisItem && !itemPickup.GetComponent<pickupableItems>().hasThisItem)
        {
            inspectTool.SetActive(true);
        }
    }
}