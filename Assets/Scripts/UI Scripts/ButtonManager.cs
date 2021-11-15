using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    #region variables
    private Scene currentScene;
    public GameObject linkedPanel;
    public Slider sensSlider;
    public GameObject[] dragableTexts;
    public TextMeshProUGUI linkedText;
    #endregion

    #region Scene Based Buttons
    private void Awake()
    {
        dragableTexts = GameObject.FindGameObjectsWithTag("DragableText");
        currentScene = SceneManager.GetActiveScene();
    }
    public void LoadNext()
    {
        SceneManager.LoadScene(currentScene.buildIndex + 1);
    }

   public void LoadPrev()
    {
        SceneManager.LoadScene(currentScene.buildIndex - 1);
    }

   public void CloseApplication()
    {
        Application.Quit();
    }
    #endregion

    #region Panel Based Buttons
    public void OnInvert()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseSelect>().invert = !GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseSelect>().invert;
    } 
    public void SetSpeed()
    {
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseSelect>().speed = sensSlider.value;
    }
    public void WarningPanelsAlter()
    {

    }
    #endregion
    #region Puzzle Based Buttons
    private int correctCounter = 0;
    public void CheckDragText()
    {
        foreach (var dragableText in dragableTexts)
        {
            if (dragableText.GetComponent<DragDrop>().inCorrectSlot == false)
            {
                dragableText.GetComponent<DragDrop>().inSlot = false;
                dragableText.GetComponent<DragDrop>().CheckPos();
            }
            else
            {
                correctCounter++;
            }
        }
        if (correctCounter >= 3)
        {
            dragableTexts[0].GetComponent<DragDrop>().win();
        }
    }
    public void DraaischijfpuzzleRightAnswer()
    {
        linkedText.color = new Color(0f, 90f, 0f);
        linkedText.text = "Juiste antwoord is gegeven!";
        linkedText.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
    public void DraaischijfpuzzleWrongAnswer()
    {
        linkedText.color = new Color(90f, 0f, 0f);
        linkedText.text = "Jammer, je hebt het fout!";
        linkedText.gameObject.SetActive(true);
    }
    #endregion
}
