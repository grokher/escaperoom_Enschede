using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnRaycastHitSetting : MonoBehaviour
{
    public skyboxRotation skyboxChange;
    public GameObject warningPanel;
    public Camera mainCamera;

    public void Update()
    {
        if (mainCamera.GetComponent<MouseSelect>().activated && mainCamera.GetComponent<MouseSelect>().raycastHit.name == gameObject.name)
        {
            openWarningPanel();
        }
        //Debug.Log(mainCamera.transform.eulerAngles);
    }

    public void openWarningPanel()
    {
        warningPanel.SetActive(true);
    }

    public void closeWarningPanelNO()
    {
        warningPanel.SetActive(false);
    }
    public void closeWarningPanelYES()
    {
        warningPanel.SetActive(false);
        skyboxChange.NextAreaOnClick();
    }
}
