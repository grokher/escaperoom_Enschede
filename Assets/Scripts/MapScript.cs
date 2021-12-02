using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    public Color mapColor;
    public GameObject floorImage, floorImage1, floorImage2;

    public void OnFloorButtonClick()
    {
        mapColor.a = 1;
    }

    public void OnOtherFloorButton()
    {
        mapColor.a = 0.25f;
    }
}
