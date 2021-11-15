using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnswerSlot : MonoBehaviour, IDropHandler
{
    public string correctAnswer;
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop");
        if(eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<DragDrop>().inSlot = true;
            if(eventData.pointerDrag.GetComponentInChildren<TextMeshProUGUI>().text == correctAnswer)
            {
                eventData.pointerDrag.GetComponent<DragDrop>().inCorrectSlot = true;
            }
        }
    }
}
