using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZDVCounter : MonoBehaviour
{
  //  public GameObject painting;
    public GameObject message;
    public GameObject Text;
    public GameObject winText;
    public GameObject Feedback;
    public GameObject raam;
    public int panelCounter = 0;
    private int prevPanelCounter;
    public int winCounter = 0;
    private float Timer = 3f;
    public bool isInTheme;
    private Text counterText;
    private Text winCounterText;
    // Start is called before the first frame update
    void Start()
    {
        isInTheme = false;
        message.SetActive(false);
       Feedback.SetActive(false); 
        counterText = Text.GetComponent<Text>();
        winCounterText = winText.GetComponent<Text>();
        prevPanelCounter = panelCounter;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= 1 * Time.deltaTime;
        counterText.text = panelCounter.ToString();
        winCounterText.text = winCounter.ToString();
        if (isInTheme)
        {
            if (panelCounter == 3)
            {
                panelCounter = 0;
                winCounter++;
            }
            if (prevPanelCounter < panelCounter)
            {
                Feedback.SetActive(true);
                prevPanelCounter = panelCounter;
                Timer = 3f;
            }
            else
                prevPanelCounter = panelCounter;
            if (Timer <= 0)
                Feedback.SetActive(false);
        }
        else
            panelCounter = 0;
        if (winCounter >= 6)
            raam.SetActive(true);
       
    }
}
