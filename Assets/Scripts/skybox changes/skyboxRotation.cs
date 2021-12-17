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
    public void NextAreaOnClick()
    {
        Debug.Log("Change F Area");
        RenderSettings.skybox = skyboxArea;
        CurrentArea.SetActive(false);
        NextArea.SetActive(true);
        locationTexts.text = NextArea.name;
        bookText.SetActive(false);
    }

    public void Update()
    {
        
    }
}
