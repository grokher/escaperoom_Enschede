using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Video;

public class burgerzaalAnimHandler : MonoBehaviour
{
    private MouseSelect mouseSelect;
    private GameObject firstActiveGameObject;
    public GameObject allObjects;
    public float Timer = 10f;
    public GameObject logBoek;
    public GameObject questPage;
    public GameObject questPageMarker;
    public GameObject fade;
    [Header("Animators")]
    public Animator pane1;
    public Animator pane2;
    public Animator pane3;
    public Animator pane4;
    public Animator pane5;
    public Animator pane6;
    public Animator pane7;
    public Animator rotator;
    public Animator cameraAnim;
    [Header("panelObjects")]
    public GameObject pane1obj;
    public GameObject pane2obj;
    public GameObject pane3obj;
    public GameObject pane4obj;
    public GameObject pane5obj;
    public GameObject pane6obj;
    public GameObject pane7obj;
    private bool pane1done = false;
    private bool pane2done = false;
    private bool pane3done = false;
    private bool pane4done = false;
    private bool pane5done = false;
    private bool pane6done = false;
    private bool pane7done = false;
    private bool introDone = false;
    [Header("Camera")]
    public GameObject animCam;
    public GameObject mainCam;
 
   
    // Start is called before the first frame update
    void Start()
    {
        cameraAnim = animCam.GetComponent<Animator>();
        pane1obj.SetActive(false);
        pane2obj.SetActive(false);
        pane3obj.SetActive(false);
        pane4obj.SetActive(false);
        pane5obj.SetActive(false);
        pane6obj.SetActive(false);
        pane7obj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     
        Scene currentScene = SceneManager.GetActiveScene();
        if (!introDone)
        {
            cameraAnim.Play("IntroAnim");
            introDone = true;
        }
        if (cameraAnim.GetCurrentAnimatorStateInfo(0).IsName("donePlaying") && introDone)
        {
            animCam.SetActive(false);
            mainCam.SetActive(true);
            logBoek.SetActive(true);
            logBoek.GetComponent<LogboekTracker>().currentPage.SetActive(false);
            questPage.SetActive(true);
            questPageMarker.SetActive(true);
        }
        if (currentScene.name == "EndScene")
        {
            pane1obj.SetActive(true);
            if (pane1.GetCurrentAnimatorStateInfo(0).IsName("donePlaying") && !pane1done)
            {
                pane1done = true;
                pane2obj.SetActive(true);
                pane2.Play("Panel2Start");
            }
            if (pane2.GetCurrentAnimatorStateInfo(0).IsName("donePlaying") && !pane2done)
            {
                pane2done = true;
                pane3obj.SetActive(true);
                pane3.Play("Panel3Start");
            }
            if (pane3.GetCurrentAnimatorStateInfo(0).IsName("donePlaying") && !pane3done)
            {
                pane3done = true;
                pane4obj.SetActive(true);
                pane4.Play("Panel4Start");
            }
            if (pane4.GetCurrentAnimatorStateInfo(0).IsName("donePlaying") && !pane4done)
            {
                pane4done = true;
                pane5obj.SetActive(true);
                pane5.Play("Panel5Start");
            }
            if (pane5.GetCurrentAnimatorStateInfo(0).IsName("donePlaying") && !pane5done)
            {
                pane5done = true;
                pane6obj.SetActive(true);
                pane6.Play("Panel6Start");
            }
            if (pane6.GetCurrentAnimatorStateInfo(0).IsName("donePlaying") && !pane6done)
            {
                pane6done = true;
                pane7obj.SetActive(true);
                pane7.Play("Panel7Start");
            }
            if (pane7.GetCurrentAnimatorStateInfo(0).IsName("donePlaying") && !pane7done)
            {
                pane7done = true;
                rotator.Play("Rotate");
            }
            if (rotator.GetCurrentAnimatorStateInfo(0).IsName("donePlaying"))
            {
                pane1.Play("Panel1");
                pane2.Play("Panel2");
                pane3.Play("Panel3");
                pane4.Play("Panel4");
                pane5.Play("Panel5");
                pane6.Play("Panel6");
                pane7.Play("Panel7");
                fade.GetComponent<Animator>().enabled = true;
                fade.GetComponent<Animator>().Play("endFade");
                Timer -= 1 * Time.deltaTime;
                Debug.Log(Timer);
            }
            if (Timer <= 0)
            {
                fade.SetActive(false);
                Camera.main.GetComponent<VideoPlayer>().enabled = true;
                allObjects.SetActive(false);
            }

        }
    }
   }

