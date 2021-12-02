using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHighlight : MonoBehaviour
{
    private Color tempColour = Color.yellow;
    public GameObject interactObject;
    

    public Renderer rend;

    private void Start()
    {
        interactObject = gameObject;
    }

    void OnMouseEnter()
    {

        tempColour = rend.material.color;
        tempColour.a = 0.25f;
        rend.material.color = tempColour;

        Debug.Log(tempColour);
    }

    private void OnMouseExit()
    {
        tempColour.a = 0.2f;
        rend.material.color = tempColour;
        Debug.Log(tempColour);
    }
}
