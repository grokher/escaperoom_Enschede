using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public GameObject TutorialArea;
    public GameObject itemPickup;
    public GameObject bookPickup;
    public GameObject inspectTool;
    public TextMesh tutorialsText;
    public bool Key;

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