using System.Collections;
using System.Collections.Generic;
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
    public GameObject fade;
    public GameObject onderwijsInfo;
    public GameObject wetInfo;
    public GameObject bedrijfInfo;
    public GameObject samenwerkenInfo;
    public GameObject huisvesting;
    public GameObject wethouderInfo;
    public GameObject Win;
    public bool clicked;
    private Animator animController;
    public Animator onderwijsAnim;
    public Animator wetAnim;
    public Animator AmbtenarenAnim;
    public Animator SamenwerkenAnim;
    public Animator huisVestingAnim;
    public Animator bedrijfAnim;
    // Start is called before the first frame update
    void Start()
    {
        
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
        animController = fade.GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetMouseButtonDown(0)&& Camera.main.GetComponent<MouseSelect>().activated && Camera.main.GetComponent<MouseSelect>().raycastHit.name == huisVestingWorldPainting.name && clicked == false)
        {
            Info.SetActive(false);
            huisVestingAnim.SetBool("huisvestingBool", true);
            clicked = true;
            huisvesting.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0) && Camera.main.GetComponent<MouseSelect>().activated && Camera.main.GetComponent<MouseSelect>().raycastHit.name == bedrijfWorldPainting.name && clicked == false)
        {
            Info.SetActive(false);
            bedrijfAnim.SetBool("bedrijfBool", true);
            clicked = true;
            bedrijfInfo.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0) && Camera.main.GetComponent<MouseSelect>().activated && Camera.main.GetComponent<MouseSelect>().raycastHit.name == onderWijsWorldPainting.name && clicked == false)
        {
            Info.SetActive(false);
            onderwijsAnim.SetBool("onderwijsSelected", true);
            clicked = true;
            onderwijsInfo.SetActive(true);
          
        }
        if (Input.GetMouseButtonDown(0) && Camera.main.GetComponent<MouseSelect>().activated && Camera.main.GetComponent<MouseSelect>().raycastHit.name == sameWerkingWorldPainting.name && clicked == false)
        {
            Info.SetActive(false);
            SamenwerkenAnim.SetBool("SamenWerkenBool", true);
            clicked = true;
            samenwerkenInfo.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0) && Camera.main.GetComponent<MouseSelect>().activated && Camera.main.GetComponent<MouseSelect>().raycastHit.name == wethouderWorldPainting.name && clicked == false)
        {
            Info.SetActive(false);
            AmbtenarenAnim.SetBool("AmbtenarenBool", true);
            clicked = true;
            wethouderInfo.SetActive(true);

        }
        if (Input.GetMouseButtonDown(0) && Camera.main.GetComponent<MouseSelect>().activated && Camera.main.GetComponent<MouseSelect>().raycastHit.name == justitieWorldPainting.name && clicked == false)
        {
            Info.SetActive(false);
            clicked = true;
            wetInfo.SetActive(true);
            wetAnim.SetBool("WetBool", true);
    
        if (Input.GetMouseButtonUp(0))
        {
            animController.SetBool("hasClicked", false);
        }
    }
   }
    public void wetStart()
    {
        animController.SetBool("hasClicked", true);
        wetAnim.SetBool("WetBool", false);
        justitieWorld.SetActive(true);
        thisWorld.SetActive(false);
        wetInfo.SetActive(false);
    }
    public void OnderwijsStart()
    {
        animController.SetBool("hasClicked", true);
        onderwijsAnim.SetBool("onderwijsSelected", false);
        onderWijsWorld.SetActive(true);
        thisWorld.SetActive(false);
        onderwijsInfo.SetActive(false);
    }
    public void samenwerkenStart()
    {
        animController.SetBool("hasClicked", true);
        SamenwerkenAnim.SetBool("SamenWerkenBool", false);
        samenWerkingWorld.SetActive(true);
        thisWorld.SetActive(false);
        samenwerkenInfo.SetActive(false);
    }
    public void bedrijfStart()
    {
        animController.SetBool("hasClicked", true);
        bedrijfAnim.SetBool("bedrijfBool", false);
        bedrijfWorld.SetActive(true);
        thisWorld.SetActive(false);
        bedrijfInfo.SetActive(false);
    }
    public void huisvestingStart()
    {
        animController.SetBool("hasClicked", true);
        huisVestingAnim.SetBool("huisvestingBool", false);
        huisVestingWorld.SetActive(true);
        thisWorld.SetActive(false);
        huisvesting.SetActive(false);
    }
    public void wethouderStart()
    {
        animController.SetBool("hasClicked", true);
        wetAnim.SetBool("AmbtenarenBool", false);
        wethouderWorld.SetActive(true);
        thisWorld.SetActive(false);
        wethouderInfo.SetActive(false);
    }
    public void back()
    {
        clicked = false;
        animController.SetBool("hasClicked", true);
        huisVestingWorld.SetActive(false);
        bedrijfWorld.SetActive(false);
        onderWijsWorld.SetActive(false);
        samenWerkingWorld.SetActive(false);
        wethouderWorld.SetActive(false);
        justitieWorld.SetActive(false);
        thisWorld.SetActive(true);
        Win.SetActive(false);
    }

}
