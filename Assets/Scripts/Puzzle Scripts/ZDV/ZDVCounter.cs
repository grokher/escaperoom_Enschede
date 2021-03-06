using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ZDVCounter : MonoBehaviour
{
  //  public GameObject painting;
    public GameObject message;
    public GameObject Text;
    public GameObject TextObject;
    public GameObject winText;
    public GameObject Feedback;
    public GameObject foundText;
    public GameObject winScreen;
    public GameObject raam;
    protected Painting painting;
    public Collider activeWindowCollider;
    public int panelCounter = 0;
    private int huisCount = 0;
    private int bedrijfCount = 0;
    private int samenwerkenCount = 0;
    private int onderwijsCount = 0;
    private int wethouderCount = 0;
    private int wetCount = 0;
    protected bool huisBool;
    protected bool bedrijfBool;
    protected bool onderwijsBool;
    protected bool samenwerkenBool;
    protected bool WethouderBool;
    protected bool wetBool;
    private bool win = false;
    private int prevPanelCounter;
    public int winCounter = 0;
    private float Timer = 3f;
    public bool isInTheme;
    private Text counterText;
    private TextMeshProUGUI winCounterText;
    public SaveToFile saveScript;
    // Start is called before the first frame update
    void Start()
    {
        
        painting = GetComponent<Painting>();
        isInTheme = false;
        message.SetActive(false);
       Feedback.SetActive(false); 
        counterText = Text.GetComponent<Text>();
        winCounterText = winText.GetComponent<TextMeshProUGUI>();
        prevPanelCounter = panelCounter;
    }
    IEnumerator completeTheme()
    {
        foundText.GetComponent<TextMeshProUGUI>().text = "Thema compleet!";
        Feedback.SetActive(true);
        yield return new WaitForSeconds(2);
        Feedback.SetActive(false);
        foundText.GetComponent<TextMeshProUGUI>().text = "Voorwerp gevonden!";
    }
    IEnumerator exitThema()
    {
        foundText.GetComponent<TextMeshProUGUI>().text = "Thema verlaten";
        Feedback.SetActive(true);
        yield return new WaitForSeconds(2);
        Feedback.SetActive(false);
        foundText.GetComponent<TextMeshProUGUI>().text = "Voorwerp gevonden!";
    }
    public void themaExit()
    {
        StartCoroutine("exitThema");
    }
    // Update is called once per frame
    void Update()
    {
        Timer -= 1 * Time.deltaTime;
        counterText.text = panelCounter.ToString();
        winCounterText.text = winCounter.ToString();
        if (isInTheme)
        {
            TextObject.SetActive(true);
            if (huisBool)
                huisCount = panelCounter;
            if (bedrijfBool)
                bedrijfCount = panelCounter;
            if (onderwijsBool)
                onderwijsCount = panelCounter;
            if (samenwerkenBool)
                samenwerkenCount = panelCounter;
            if (WethouderBool)
                wethouderCount = panelCounter;
            if (wetBool)
                wetCount = panelCounter;

            if (panelCounter == 3)
            {
                StartCoroutine("completeTheme");

                win = true;
                activeWindowCollider = painting.activeWindow.GetComponent<Collider>();
                activeWindowCollider.enabled = !activeWindowCollider.enabled;
                activeWindowCollider.GetComponent<Animator>().Play("RotateInf");
                painting.back();
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
        {
            TextObject.SetActive(false);
            panelCounter = 0;
        }
        if (winCounter >= 6&& win)
        {
            win = false;
            winScreen.SetActive(true);
            saveScript.Save(gameObject);
            raam.SetActive(true);
        }
       
    }
    public void huisSelect()
    {
        huisBool = true;
        panelCounter = huisCount;
    }

    public void bedrijfSelect()
    {
        bedrijfBool = true;
        panelCounter = bedrijfCount;
    }
    public void onderwijsSelect()
    {
        onderwijsBool = true;
        panelCounter = onderwijsCount;
    }
    public void samenwerkenSelect()
    {
        samenwerkenBool = true;
        panelCounter = samenwerkenCount;
    }
    public void wethouderSelect()
    {
        WethouderBool = true;
        panelCounter = wethouderCount;
    }
    public void wetSelect()
    {
        wetBool = true;
        panelCounter = wetCount;
    }

    public void allBack()
    {
        huisBool = false;
        bedrijfBool = false;
        samenwerkenBool = false;
        onderwijsBool = false;
        wetBool = false;
        WethouderBool = false;
    }
}
