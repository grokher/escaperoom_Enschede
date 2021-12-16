using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class storyEventHandler : MonoBehaviour
{
    private float Timer = 12.5f;
    public GameObject text;
    public GameObject fade;
    public Texture TextScherm;
    public Texture bode1;
    public Texture bode2;
    public Texture bode3;
    public Texture bode4;
    public Texture bode5;
    RawImage m_rawImage;
    private bool textDone = false;
    private bool bode1Done =false;
    private bool bode2Done = false;
    private bool bode3Done = false;
    private bool bode4Done = false;
    private bool bode5Done = false;

    // Start is called before the first frame update
    void Start()
    {
   m_rawImage = GetComponent<RawImage>();
        m_rawImage.texture = TextScherm;
     
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
            SceneManager.LoadScene(3);
        }
    }
}
