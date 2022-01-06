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
    private bool stopText;
    [Header("lockedDoorPart")]
    public GameObject mozaiekArrow;
    public TextMeshProUGUI lockedPickupText;
    public void NextAreaOnClick()
    {
        Debug.Log("Change F Area");
        RenderSettings.skybox = skyboxArea;
        CurrentArea.SetActive(false);
        NextArea.SetActive(true);
        locationTexts.text = NextArea.name;
        bookText.SetActive(false);
        
        
    }

    IEnumerator lockedDoor()
    {
        //Debug.Log("HITTY");
        if (Camera.main.GetComponent<MouseSelect>().hitObject.name == mozaiekArrow.name && !stopText)
        {
            stopText = false;
            Debug.Log("Text HIt");
            lockedPickupText.text = "je hebt een sleutel nodig om de deur te openen";
            yield return new WaitForSeconds(3f);
            lockedPickupText.text = "";
            stopText = true;
            
        }
        if (Camera.main.GetComponent<MouseSelect>().raycastHit.name != mozaiekArrow.name)
        {
            stopText = false;
        }
    }

    public void Update()
    {
        StartCoroutine(lockedDoor());
    }
}
