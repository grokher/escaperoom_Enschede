using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxRotation : MonoBehaviour
{
    //raycast hit -> moves next specific area
    public Material skyboxArea;
    public GameObject CurrentArea;
    public GameObject NextArea;
    public void NextAreaOnClick()
    {
        Debug.Log("Change F Area");
        RenderSettings.skybox = skyboxArea;
        CurrentArea.SetActive(false);
        NextArea.SetActive(true);
    }

    public void Update()
    {
        Debug.Log(CurrentArea);
    }
}
