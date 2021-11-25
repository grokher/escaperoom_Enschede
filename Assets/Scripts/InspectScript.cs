using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InspectScript : MonoBehaviour
{
    public GameObject key;
    public Transform inspectCamera;
    public GameObject inspectTool;
    public Camera mainCamera;
    public GameObject tutorialRoomText;
    public GameObject tutorialRoomArrow;
    private void Start()
    {
        mainCamera.GetComponent<MouseSelect>().enabled = false;
        tutorialRoomText.SetActive(false);
        tutorialRoomArrow.SetActive(false);
    }
    void Update()
    {
        Inspection();
    }
    private void Inspection()
    {
        if (Input.GetMouseButton(0))
        {
            float rotX = Input.GetAxis("Mouse X") * 50 * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * 50 * Mathf.Deg2Rad;
            transform.Rotate(Vector3.up, -rotX);
            transform.Rotate(Vector3.right, rotY);
            
        }
        if(key.GetComponent<pickupableItems>().hasThisItem)
        {
            inspectTool.SetActive(false);
            tutorialRoomText.SetActive(true);
            tutorialRoomArrow.SetActive(true);
            mainCamera.GetComponent<MouseSelect>().enabled = true;
        }
    }
}
