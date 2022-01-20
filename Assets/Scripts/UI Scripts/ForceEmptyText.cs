using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ForceEmptyText : MonoBehaviour
{
    private TextMeshProUGUI popUp;
    private MouseSelect mouse;
    // Start is called before the first frame update
    void Start()
    {
        popUp = GetComponent<TextMeshProUGUI>();
        mouse = Camera.main.GetComponent<MouseSelect>();
    }

    IEnumerator forceText()
    {
        if (popUp.text != ("")&&mouse.activated)
        {
            yield return new WaitForSeconds(1.5f);
            popUp.text = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("forceText");

    }

}
