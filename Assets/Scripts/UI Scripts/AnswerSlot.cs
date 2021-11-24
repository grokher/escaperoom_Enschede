using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswerSlot : MonoBehaviour, IDropHandler
{
    public string correctAnswer;
    public GameObject[] dragableTexts;
    public int correctslotCounter = 0;
    public int inslotCounter = 0;
    public GameObject wrongAnswersText;
    void Start()
    {
         dragableTexts = GameObject.FindGameObjectsWithTag("DragableText");
    }
    void Update()
    {
        
    }
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if(eventData.pointerDrag != null)
        {
            wrongAnswersText.SetActive(false);
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<DragDrop>().inSlot = true;
            Debug.Log("Correct answer " + correctAnswer);
            Debug.Log("text component " + eventData.pointerDrag.GetComponentInChildren<TextMeshProUGUI>().text);
            if (eventData.pointerDrag.GetComponentInChildren<TextMeshProUGUI>().text == correctAnswer)
            {
                eventData.pointerDrag.GetComponent<DragDrop>().inCorrectSlot = true;
                
            }
        }
        foreach (var dragableText in dragableTexts)
        {
            if (dragableText.GetComponent<DragDrop>().inSlot == true)
            {
                inslotCounter++;
                if (dragableText.GetComponent<DragDrop>().inCorrectSlot == true)
                {
                    correctslotCounter++;
                }
            }
        }
        if(inslotCounter >= 3)
        {
            if (correctslotCounter >= 3)
            {
                dragableTexts[0].GetComponent<DragDrop>().win();
            }
            else
            {
                foreach (var dragableText in dragableTexts)
                {
                    dragableText.GetComponent<DragDrop>().inSlot = false;
                    dragableText.GetComponent<DragDrop>().CheckPos();
                }
                wrongAnswersText.SetActive(true);
            }
        }
        else
        {
            correctslotCounter = 0;
            inslotCounter = 0;
        }
        
    }
}
