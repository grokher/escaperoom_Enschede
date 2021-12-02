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
    public int panelCounter = 0;
    public int winCounter = 0;
    private Text counterText;
    private Text winCounterText;
    // Start is called before the first frame update
    void Start()
    {
        message.SetActive(false);
        counterText = Text.GetComponent<Text>();
        winCounterText = winText.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = panelCounter.ToString();
        winCounterText.text = winCounter.ToString();
        if (panelCounter == 3)
        {
            panelCounter = 0;
            winCounter++;
        }
    }
}
