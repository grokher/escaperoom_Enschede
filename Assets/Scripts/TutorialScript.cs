using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScript : MonoBehaviour
{
    public GameObject itemPickup;
    public TextMesh tutorialsText;
    public bool Key;

    private void Update()
    {
        StartCoroutine("tutorialScript");
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
    
}