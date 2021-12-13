using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skyboxColourChanger : MonoBehaviour
{
    #region variables
    public Material currentSkybox;
    public Slider RSlider, GSlider, BSlider;
    [SerializeField] bool allColoursDone = false;
    bool redDone = false, greenDone = false, blueDone = false;
    float RValue, GValue, BValue;
    GameObject Camera;
    #endregion
    void Awake()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        currentSkybox.SetColor("_Tint", new UnityEngine.Color(128f, 128f, 128f, 1.0f));
        RSlider.value = Random.Range(0.05f, 0.5f); GSlider.value = Random.Range(0.05f, 0.5f); BSlider.value = Random.Range(0.05f, 0.5f);
        AlterSkyBox();
    }
    private void Update()
    {
        AlterSkyBox();
        CheckForDone();
    }
    private void OnDisable()
    {
        currentSkybox.SetColor("_Tint", new UnityEngine.Color(128f / 255f, 128f / 255f, 128f / 255f, 1.0f));
        RenderSettings.skybox = currentSkybox;
    }
    void AlterSkyBox()
    {
        currentSkybox.SetColor("_Tint",new UnityEngine.Color(RSlider.value * 1.5f, GSlider.value * 0.8f, BSlider.value * 0.5f,1.0f));
        RenderSettings.skybox = currentSkybox;
        
    }
    void CheckForDone()
    {
        if (RenderSettings.skybox.GetVector("_Tint").x /1f * 255f > 110f && RenderSettings.skybox.GetVector("_Tint").x /1f * 255f < 140f )
        {
            redDone = true;
        }
        if(RenderSettings.skybox.GetVector("_Tint").y / 1f * 255f > 110f && RenderSettings.skybox.GetVector("_Tint").y / 1f * 255f < 140f)
        {
            greenDone = true;
        }
        if (RenderSettings.skybox.GetVector("_Tint").z / 1f * 255f > 110f && RenderSettings.skybox.GetVector("_Tint").z / 1f * 255f < 140f)
        {
            blueDone = true;
        }
        if( redDone && greenDone && blueDone)
        {
            allColoursDone = true; // use this for linking with progress.
            gameObject.GetComponent<PanelHandler>().linkedPanel.SetActive(false);
            Camera.GetComponent<MouseSelect>().enabled = true;
            Camera.GetComponent<MouseSelect>().inPuzzle = false;
            gameObject.SetActive(false);
        }
        redDone = false; greenDone = false; blueDone = false;
    }
}