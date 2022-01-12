using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform;
    public Vector2 originalrectTransform;
    public bool inSlot = false;
    public bool inCorrectSlot = false;
    private CanvasGroup canvasGroup;
    public GameObject cypherpuzzle, cypherActivationObject;
    public GameObject raam;
    public GameObject WinPanel;
    private void Awake()
    {
        inSlot = false;
        rectTransform = GetComponent<RectTransform>();
        originalrectTransform = rectTransform.anchoredPosition;
        canvasGroup = GetComponent<CanvasGroup>();
        //raam = GameObject.Find("raam");
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        inSlot = false;
        inCorrectSlot = false;
        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor * 1.45f;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
        canvasGroup.blocksRaycasts = true;
        CheckPos();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
    public void CheckPos()
    {
        if (rectTransform.anchoredPosition != originalrectTransform && !inSlot)
        {
            rectTransform.anchoredPosition = originalrectTransform;
        }
    }
    public void win()
    {
        //winText.color = new Color(0,90,0);
        //winText.text = "Correct, je hebt het goed!";
        WinPanel.SetActive(true);
        raam.SetActive(true);
        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseSelect>().inPuzzle = false;
        cypherpuzzle.SetActive(false);
        cypherActivationObject.SetActive(false);
    }
}
