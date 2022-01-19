using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class skyboxRotation : MonoBehaviour
{
    //raycast hit -> moves next specific area
    public Material skyboxArea;

    public GameObject CurrentArea;
    public GameObject NextArea;
    public TextMeshProUGUI locationTexts;
    public GameObject bookText;
    private bool stopText, stopText1, stopText2;
    [Header("lockedDoorPart")]
    public GameObject mozaiekArrow;
    public TextMeshProUGUI lockedPickupText;
    [Header("lockedArrow")]
    public GameObject lockedArrow;
    public GameObject lockedLift;
    public void NextAreaOnClick()
    {
        Debug.Log("Change F Area");
        RenderSettings.skybox = skyboxArea;
        CurrentArea.SetActive(false);
        NextArea.SetActive(true);
        locationTexts.text = NextArea.name;
        //bookText.SetActive(false);
        
        
    }

    IEnumerator lockedDoor()
    {
        //Debug.Log("HITTY");
        if (Camera.main.GetComponent<MouseSelect>().hitObject.name == mozaiekArrow.name)
        {
            lockedPickupText.text = "je hebt een sleutel nodig om de deur te openen";
            yield return new WaitForEndOfFrame();
               yield return new WaitForSeconds(1.5f);
                lockedPickupText.text = "";
                stopText = true;
            }
            else if (Camera.main.GetComponent<MouseSelect>().raycastHit.name != mozaiekArrow.name)
           {
                stopText = false;
               lockedPickupText.text = "";
        
      }
    }

    IEnumerator UnlockingArrow()
    {
        if (Camera.main.GetComponent<MouseSelect>().hitObject.name == lockedArrow.name && !stopText1)
        {
            lockedPickupText.text = "je moet eerst ergens anders heen";
            yield return new WaitForSeconds(1.5f);
            lockedPickupText.text = "";
            stopText1 = true;
        }
        else if (Camera.main.GetComponent<MouseSelect>().raycastHit.name != lockedArrow.name)
        {
            stopText1 = false;
            lockedPickupText.text = "";
        }
            
    }

    IEnumerator liftUnlock()
    {
        if (Camera.main.GetComponent<MouseSelect>().hitObject.name == lockedLift.name && !stopText2)
        {
            lockedPickupText.text = "Je moet iets in de machinekamer repareren";
            yield return new WaitForSeconds(3f);
            lockedPickupText.text = "";
            stopText2 = true;
        }
        else if (Camera.main.GetComponent<MouseSelect>().raycastHit.name != lockedLift.name)
        {
            stopText2 = false;
            lockedPickupText.text = "";
        }
    }

    public void Update()
    {
        StartCoroutine(lockedDoor());
        StartCoroutine(UnlockingArrow());
        StartCoroutine(liftUnlock());
    }
}
