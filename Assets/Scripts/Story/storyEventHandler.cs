using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class storyEventHandler : MonoBehaviour
{
    private float Timer = 12.5f;
    public GameObject text;
    public GameObject text2;
    public GameObject fade;
    public GameObject imageHolder;
    public GameObject webGLimage;
    protected VideoPlayer player;
    public Texture TextScherm;
    public Texture bode1;
    public Texture bode2;
    public Texture bode3;
    public Texture bode4;
    public Texture bode5;
    RawImage m_rawImage;
    public bool isWebGL = false;
    private bool textDone = false;
    private bool bode1Done =false;
    private bool bode2Done = false;
    private bool bode3Done = false;
    private bool bode4Done = false;
    private bool bode5Done = false;
    private bool lastTextDone = false;
    private bool videoPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
   m_rawImage = GetComponent<RawImage>();
        m_rawImage.texture = TextScherm;
        player = Camera.main.GetComponent<VideoPlayer>();
        player.enabled = false;
     
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= 1*Time.deltaTime;
        
        if(Timer <= 0 && !textDone)
        {
            text.SetActive(false);
            textDone = true;
            m_rawImage.texture = bode1;
            Timer = 3.1f;

        }

        if(Timer <= 0 && !bode1Done)
        {
            bode1Done = true;
            m_rawImage.texture = bode2;
            Timer = 2.9f;
        }
        if (Timer <= 0 && !bode2Done)
        {
            bode2Done = true;
            m_rawImage.texture = bode3;
            Timer = 2.8f;
        }
        if (Timer <= 0 && !bode3Done)
        {
            bode3Done = true;
            m_rawImage.texture = bode4;
            Timer = 2.8f;
        }
        if (Timer <= 0 && !bode4Done)
        {
            bode4Done = true;
            m_rawImage.texture = bode5;
            Timer = 2.8f;
        }
        if(Timer <= 0 && !bode5Done)
        {
            bode5Done = true;
            m_rawImage.texture = TextScherm;
            text2.SetActive(true);
            Timer = 3f;
            lastTextDone = true;
           
            //SceneManager.LoadScene(3);
        }

        if (Timer <= 0 && lastTextDone&&!videoPlayed&&!isWebGL)
        {
            videoPlayed = true;
            imageHolder.SetActive(false);
            player.enabled = true;
            Timer = 20f;
            fade.GetComponent<Animator>().Play("videoFade");
            GetComponent<RawImage>().enabled = false;
        }
        if (Timer <= 0 && lastTextDone && !videoPlayed && isWebGL)
        {
            videoPlayed = true;
            imageHolder.SetActive(false);
            GetComponent<RawImage>().enabled = false;
            webGLimage.SetActive(true);
            Timer = 20f;
        }

            if (Timer <= 10f&&videoPlayed)
            SceneManager.LoadScene(3);
    }

    public void SkipButton()
    {
        SceneManager.LoadScene(3);
    }
}
