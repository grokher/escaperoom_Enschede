using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject credits;

    void Update()
    {
        if(Camera.main.GetComponent<MouseSelect>().activated && Camera.main.GetComponent<MouseSelect>().raycastHit.name == gameObject.name)
        {
            credits.SetActive(true);
            Camera.main.GetComponent<MouseSelect>().activated = false;
        }
    }
}
