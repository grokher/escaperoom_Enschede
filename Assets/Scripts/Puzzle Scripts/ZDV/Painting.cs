using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Painting : MonoBehaviour
{
    public GameObject Info;
    public GameObject huisVestingWorld;
    public GameObject bedrijfWorld;
    public GameObject onderWijsWorld;
    public GameObject samenWerkingWorld;
    public GameObject wethouderWorld;
    public GameObject justitieWorld;
    public GameObject huisVestingWorldPainting;
    public GameObject bedrijfWorldPainting;
    public GameObject onderWijsWorldPainting;
    public GameObject sameWerkingWorldPainting;
    public GameObject wethouderWorldPainting;
    public GameObject justitieWorldPainting;
    public GameObject thisWorld;
    public GameObject onderwijsInfo;
    public GameObject wetInfo;
    public GameObject bedrijfInfo;
    public GameObject samenwerkenInfo;
    public GameObject huisvesting;
    public GameObject wethouderInfo;
    public GameObject Win;
    public GameObject cam;
    public GameObject lookObject;
    public GameObject themeObject;
    public GameObject activeWindow;
    protected ZDVCounter counter;
    public TextMeshProUGUI themaText;
    public bool clicked;
    public Animator onderwijsAnim;
    public Animator wetAnim;
    public Animator AmbtenarenAnim;
    public Animator SamenwerkenAnim;
    public Animator huisVestingAnim;
    public Animator bedrijfAnim;
    // Start is called before the first frame update
    void Start()
    {
        counter = GetComponent<ZDVCounter>();
        themeObject.SetActive(false);
        cam = Camera.main.gameObject;
        wetInfo.SetActive(false);
        onderwijsInfo.SetActive(false);
        bedrijfInfo.SetActive(false);
        wethouderInfo.SetActive(false);
        samenwerkenInfo.SetActive(false);
        huisvesting.SetActive(false);
        huisVestingWorld.SetActive(false);
        bedrijfWorld.SetActive(false);
        onderWijsWorld.SetActive(false);
        samenWerkingWorld.SetActive(false);
        wethouderWorld.SetActive(false);
        justitieWorld.SetActive(false);
        thisWorld.SetActive(true);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter.panelCounter == 3)
            themeObject.SetActive(false);
        if (Input.GetMouseButtonDown(0) && Camera.main.GetComponent<MouseSelect>().activated && Camera.main.GetComponent<MouseSelect>().raycastHit.name == huisVestingWorldPainting.name && clicked == false)
        {
            Info.SetActive(false);
            huisVestingAnim.SetBool("huisvestingBool", true);
            clicked = true;
            huisvesting.SetActive(true);
            cam.GetComponent<MouseSelect>().isAnimating = true;
            lookObject = Camera.main.GetComponent<MouseSelect>().raycastHit.gameObject;
            themaText.text = cam.GetComponent<MouseSelect>().raycastHit.gameObject.name.ToString();
            counter.isInTheme = true;
        }
        else if (Input.GetMouseButtonDown(0) && Camera.main.GetComponent<MouseSelect>().activated && Camera.main.GetComponent<MouseSelect>().raycastHit.name == bedrijfWorldPainting.name && clicked == false)
        {
            Info.SetActive(false);
            bedrijfAnim.SetBool("bedrijfBool", true);
            clicked = true;
            bedrijfInfo.SetActive(true);
            cam.GetComponent<MouseSelect>().isAnimating = true;
            lookObject = Camera.main.GetComponent<MouseSelect>().raycastHit.gameObject;
            themaText.text = cam.GetComponent<MouseSelect>().raycastHit.gameObject.name.ToString();
            counter.isInTheme = true;
        }
        else if (Input.GetMouseButtonDown(0) && Camera.main.GetComponent<MouseSelect>().activated && Camera.main.GetComponent<MouseSelect>().raycastHit.name == onderWijsWorldPainting.name && clicked == false)
        {
            Info.SetActive(false);
            onderwijsAnim.SetBool("onderwijsSelected", true);
            clicked = true;
            onderwijsInfo.SetActive(true);
            cam.GetComponent<MouseSelect>().isAnimating = true;
            lookObject = Camera.main.GetComponent<MouseSelect>().raycastHit.gameObject;
            themaText.text = cam.GetComponent<MouseSelect>().raycastHit.gameObject.name.ToString();
            counter.isInTheme = true;

        }
        else if (Input.GetMouseButtonDown(0) && Camera.main.GetComponent<MouseSelect>().activated && Camera.main.GetComponent<MouseSelect>().raycastHit.name == sameWerkingWorldPainting.name && clicked == false)
        {
            Info.SetActive(false);
            SamenwerkenAnim.SetBool("SamenWerkenBool", true);
            clicked = true;
            samenwerkenInfo.SetActive(true);
            cam.GetComponent<MouseSelect>().isAnimating = true;
            lookObject = Camera.main.GetComponent<MouseSelect>().raycastHit.gameObject;
            themaText.text = cam.GetComponent<MouseSelect>().raycastHit.gameObject.name.ToString();
            counter.isInTheme = true;
        }
        else if (Input.GetMouseButtonDown(0) && Camera.main.GetComponent<MouseSelect>().activated && Camera.main.GetComponent<MouseSelect>().raycastHit.name == wethouderWorldPainting.name && clicked == false)
        {
            Info.SetActive(false);
            AmbtenarenAnim.SetBool("AmbtenarenBool", true);
            clicked = true;
            wethouderInfo.SetActive(true);
            cam.GetComponent<MouseSelect>().isAnimating = true;
            lookObject = Camera.main.GetComponent<MouseSelect>().raycastHit.gameObject;
            themaText.text = cam.GetComponent<MouseSelect>().raycastHit.gameObject.name.ToString();
            counter.isInTheme = true;

        }
        else if (Input.GetMouseButtonDown(0) && Camera.main.GetComponent<MouseSelect>().activated && Camera.main.GetComponent<MouseSelect>().raycastHit.name == justitieWorldPainting.name && clicked == false)
        {
            Info.SetActive(false);
            clicked = true;
            wetInfo.SetActive(true);
            wetAnim.SetBool("WetBool", true);
            lookObject = Camera.main.GetComponent<MouseSelect>().raycastHit.gameObject;
            cam.GetComponent<MouseSelect>().isAnimating = true;
            themaText.text = cam.GetComponent<MouseSelect>().raycastHit.gameObject.name.ToString();
            counter.isInTheme = true;
        }
        else if (lookObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Rotate"))
        {
            lookObject = null;
        }
        
        if (cam.GetComponent<MouseSelect>().isAnimating)
        {
            themeObject.SetActive(true);
            if (lookObject.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Rotate"))
                cam.GetComponent<MouseSelect>().isAnimating = false;
            cam.transform.LookAt(lookObject.transform);
        }
    
    
 
   }
    public void wetStart()
    {
        
        wetAnim.SetBool("WetBool", false);
        justitieWorld.SetActive(true);
        thisWorld.SetActive(false);
        wetInfo.SetActive(false);
        cam.GetComponent<MouseSelect>().isAnimating = false;
    }
    public void OnderwijsStart()
    {
      
        onderwijsAnim.SetBool("onderwijsSelected", false);
        onderWijsWorld.SetActive(true);
        thisWorld.SetActive(false);
        onderwijsInfo.SetActive(false);
        cam.GetComponent<MouseSelect>().isAnimating = false;
    }
    public void samenwerkenStart()
    {
       
        SamenwerkenAnim.SetBool("SamenWerkenBool", false);
        samenWerkingWorld.SetActive(true);
        thisWorld.SetActive(false);
        samenwerkenInfo.SetActive(false);
        cam.GetComponent<MouseSelect>().isAnimating = false;
    }
    public void bedrijfStart()
    {
       
        bedrijfAnim.SetBool("bedrijfBool", false);
        bedrijfWorld.SetActive(true);
        thisWorld.SetActive(false);
        bedrijfInfo.SetActive(false);
        cam.GetComponent<MouseSelect>().isAnimating = false;
    }
    public void huisvestingStart()
    {
        
      
        huisVestingAnim.SetBool("huisvestingBool", false);
        huisVestingWorld.SetActive(true);
        thisWorld.SetActive(false);
        huisvesting.SetActive(false);
        cam.GetComponent<MouseSelect>().isAnimating = false;
    }
    public void wethouderStart()
    {
     
       AmbtenarenAnim.SetBool("AmbtenarenBool", false);
        wethouderWorld.SetActive(true);
        thisWorld.SetActive(false);
        wethouderInfo.SetActive(false);
        cam.GetComponent<MouseSelect>().isAnimating = false;
    }
    public void back()
    {
        counter.isInTheme = false;
        themeObject.SetActive(false);
        clicked = false;
        
        huisVestingWorld.SetActive(false);
        bedrijfWorld.SetActive(false);
        onderWijsWorld.SetActive(false);
        samenWerkingWorld.SetActive(false);
        wethouderWorld.SetActive(false);
        justitieWorld.SetActive(false);
        thisWorld.SetActive(true);
        Win.SetActive(false);
        cam.GetComponent<MouseSelect>().isAnimating = false;
    }

}
