using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakeHallArrow : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject text;
    // Start is called before the first frame update
    public void Update()
    {
        if (mainCamera.GetComponent<MouseSelect>().activated && mainCamera.GetComponent<MouseSelect>().raycastHit.name == gameObject.name)
        {
            text.SetActive(true);
            gameObject.SetActive(false);
        }
        //Debug.Log(mainCamera.transform.eulerAngles);
    }
}
