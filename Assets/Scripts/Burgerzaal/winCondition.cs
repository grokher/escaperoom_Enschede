using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class winCondition : MonoBehaviour
{
    public int winCounter = 0;
    public TextMesh winText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        winText.text = winCounter.ToString();
    }
}
