using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapScript : MonoBehaviour
{
    public GameObject mainFloor, firstFloor;

    public void floorButtonMain0()
    {
        firstFloor.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, 0.2f);
        mainFloor.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, 1);
    }

    public void floorButton1()
    {
        mainFloor.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, 0.2f);
        firstFloor.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, 1);
    }
}
