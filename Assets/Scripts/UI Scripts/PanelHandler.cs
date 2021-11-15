using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelHandler : MonoBehaviour
{
    #region variables
    public GameObject linkedPanel;
    public GameObject Camera;
    public GameObject PuzzleCamera;
    public GameObject linked3DPuzzle;
    public GameObject highlight;
    #endregion
    private void Update()
    {
        if (Camera.GetComponent<MouseSelect>().activated && Camera.GetComponent<MouseSelect>().hitObject.GetComponent<PanelHandler>().linkedPanel != null)
        {
            Camera.GetComponent<MouseSelect>().hitObject.GetComponent<PanelHandler>().linkedPanel.SetActive(true);
            Camera.GetComponent<MouseSelect>().inPuzzle = true;
            Camera.GetComponent<MouseSelect>().activated = false;
        }
        else if (Camera.GetComponent<MouseSelect>().activated && Camera.GetComponent<MouseSelect>().hitObject.GetComponent<PanelHandler>().linked3DPuzzle != null)
        {
            PuzzleCamera.SetActive(true);
            Camera.SetActive(false);
            Camera.GetComponent<MouseSelect>().hitObject.GetComponent<PanelHandler>().linked3DPuzzle.SetActive(true);
            Camera.GetComponent<MouseSelect>().inPuzzle = true;
            Camera.GetComponent<MouseSelect>().activated = false;
        }
        if (linkedPanel != null && linkedPanel.active == false && Camera.GetComponent<MouseSelect>().inPuzzle == true || linked3DPuzzle != null && linked3DPuzzle.active == false && Camera.GetComponent<MouseSelect>().inPuzzle == true)
        {
            if (!Camera.activeInHierarchy)
            {
                Camera.SetActive(true);
            }
            if (linkedPanel != null && linkedPanel.active == false && Camera.GetComponent<MouseSelect>().inPuzzle == true || linked3DPuzzle != null && linked3DPuzzle.active == false && Camera.GetComponent<MouseSelect>().inPuzzle == true)
            {
                Camera.GetComponent<MouseSelect>().inPuzzle = false;
            }
        }
    }
}