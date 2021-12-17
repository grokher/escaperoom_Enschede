using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapScript : MonoBehaviour
{
    public GameObject mainFloor, firstFloor, baseMent;

    public void floorButtonMain1()
    {
        firstFloor.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, 0.2f);
        mainFloor.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, 1);
        baseMent.GetComponentInChildren<Image>().color = new UnityEngine.Color(1, 1, 1, 0.2f);
    }

    public void floorButton2()
    {
        mainFloor.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, 0.2f);
        firstFloor.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, 1);
        baseMent.GetComponentInChildren<Image>().color = new UnityEngine.Color(1, 1, 1, 0);
    }

    public void floorButton0()
    {
        mainFloor.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, 0.2f);
        firstFloor.GetComponent<Image>().color = new UnityEngine.Color(1, 1, 1, 0);
        baseMent.GetComponentInChildren<Image>().color = new UnityEngine.Color(1, 1, 1, 1);
    }
}
