using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintSysteem : MonoBehaviour
{

    public GameObject koffiekamerInfo;
    public GameObject MozaiekKamerInfo;
    public GameObject BurgerZaalInfo;
    public GameObject RaadZaalInfo;
    public GameObject TrouwZaalInfo;
    public GameObject BurgermeestersKamerInfo;
    public GameObject FriedhoffInfo;
    public GameObject MachineKamerInfo;
    public GameObject ArchiefKamerInfo;
    public GameObject TorenInfo;

    public GameObject koffiekamerButton;
    public GameObject MozaiekKamerButton;
    public GameObject BurgerZaalButton;
    public GameObject RaadZaalButton;
    public GameObject TrouwZaalButton;
    public GameObject BurgermeestersKamerButton;
    public GameObject FriedhoffButton;
    public GameObject MachineKamerButton;
    public GameObject ArchiefKamerButton;
    public GameObject TorenButton;

    private bool koffiekamerBool = true;
    private bool MozaiekKamerBool = true;
    private bool BurgerZaalBool = true;
    private bool RaadZaalBool = true;
    private bool TrouwZaalBool = true;
    private bool BurgermeestersKamerBool = true;
    private bool FriedHoffBool = true;
    private bool MachineKamerBool = true;
    private bool ArchiefKamerBool = true;
    private bool TorenBool = true;

    // Start is called before the first frame update
    void Start()
    {
        koffiekamerInfo.SetActive(false);
      MozaiekKamerInfo.SetActive(false);
        BurgerZaalInfo.SetActive(false);
        RaadZaalInfo.SetActive(false);
        TrouwZaalInfo.SetActive(false);
        BurgermeestersKamerInfo.SetActive(false);
        FriedhoffInfo.SetActive(false);
        MachineKamerInfo.SetActive(false);
        ArchiefKamerInfo.SetActive(false);
        TorenInfo.SetActive(false);
    }
    public void page1()
    {
        if (!koffiekamerBool)
        {
            koffiekamerInfo.SetActive(true);
            MozaiekKamerInfo.SetActive(false);
            BurgerZaalInfo.SetActive(false);
            RaadZaalInfo.SetActive(false);
            TrouwZaalInfo.SetActive(false);
            BurgermeestersKamerInfo.SetActive(false);
            FriedhoffInfo.SetActive(false);
            MachineKamerInfo.SetActive(false);
            ArchiefKamerInfo.SetActive(false);
            TorenInfo.SetActive(false);
        }
    }
    public void page2()
    {
        if (!BurgerZaalBool)
        {
            BurgerZaalInfo.SetActive(true);
            RaadZaalInfo.SetActive(false);
            TrouwZaalInfo.SetActive(false);
            BurgermeestersKamerInfo.SetActive(false);
            FriedhoffInfo.SetActive(false);
            MachineKamerInfo.SetActive(false);
            ArchiefKamerInfo.SetActive(false);
            TorenInfo.SetActive(false);
             koffiekamerInfo.SetActive(false);
            MozaiekKamerInfo.SetActive(false);
        }
    }
    public void page3()
    {
        if (!BurgermeestersKamerBool)
        {
            BurgermeestersKamerInfo.SetActive(true);
            FriedhoffInfo.SetActive(false);
            MachineKamerInfo.SetActive(false);
            ArchiefKamerInfo.SetActive(false);
            TorenInfo.SetActive(false);
            koffiekamerInfo.SetActive(false);
            MozaiekKamerInfo.SetActive(false);
            BurgerZaalInfo.SetActive(false);
            RaadZaalInfo.SetActive(false);
            TrouwZaalInfo.SetActive(false);
        }
    }
    public void page4()
    {
        if (!FriedHoffBool)
        {
            FriedhoffInfo.SetActive(true);
            MachineKamerInfo.SetActive(false);
            ArchiefKamerInfo.SetActive(false);
            TorenInfo.SetActive(false);
            koffiekamerInfo.SetActive(false);
            MozaiekKamerInfo.SetActive(false);
            BurgerZaalInfo.SetActive(false);
            RaadZaalInfo.SetActive(false);
            TrouwZaalInfo.SetActive(false);
            BurgermeestersKamerInfo.SetActive(false);
        }
    }
    public void page5()
    {
        if (!RaadZaalBool)
        {
            RaadZaalInfo.SetActive(true);
            TrouwZaalInfo.SetActive(false);
            BurgermeestersKamerInfo.SetActive(false);
            FriedhoffInfo.SetActive(false);
            MachineKamerInfo.SetActive(false);
            ArchiefKamerInfo.SetActive(false);
            TorenInfo.SetActive(false);
            koffiekamerInfo.SetActive(false);
            MozaiekKamerInfo.SetActive(false);
            BurgerZaalInfo.SetActive(false);
        }
    }
    public void page6()
    {
        if (!MozaiekKamerBool)
        {
            MozaiekKamerInfo.SetActive(true);
            BurgerZaalInfo.SetActive(false);
            RaadZaalInfo.SetActive(false);
            TrouwZaalInfo.SetActive(false);
            BurgermeestersKamerInfo.SetActive(false);
            FriedhoffInfo.SetActive(false);
            MachineKamerInfo.SetActive(false);
            ArchiefKamerInfo.SetActive(false);
            TorenInfo.SetActive(false);
            koffiekamerInfo.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("TrouwZaal")&&TrouwZaalBool)
        {
            TrouwZaalBool = false;
            TrouwZaalButton.SetActive(true);
        }
        if (GameObject.Find("OudeKoffieKamer")&&koffiekamerBool)
        {
            koffiekamerBool = false;
            koffiekamerButton.SetActive(true);
        }
        if (GameObject.Find("BurgerZaal3")&&BurgerZaalBool)
        {
            BurgerZaalBool = false;
            BurgerZaalButton.SetActive(true);
        }
        if (GameObject.Find("Mozaiekkamer")&&MozaiekKamerBool)
        {
            MozaiekKamerBool = false;
            MozaiekKamerButton.SetActive(true);
        }
        if (GameObject.Find("Raadzaal")&&RaadZaalBool)
        {
            RaadZaalBool = false;
            RaadZaalButton.SetActive(true);
        }
        if (GameObject.Find("BurgermeesterKamer")&&BurgermeestersKamerBool)
        {
            BurgermeestersKamerBool = false;
            BurgermeestersKamerButton.SetActive(true);
        }
        if (GameObject.Find("FriedHoffKamer")&&FriedHoffBool)
        {
            FriedHoffBool = false;
            FriedhoffButton.SetActive(true);
        }
        if (GameObject.Find("machinekamer")&&MachineKamerBool)
        {
            MachineKamerBool = false;
            MachineKamerButton.SetActive(true);
        }
        if (GameObject.Find("Archief")&&ArchiefKamerBool)
        {
            ArchiefKamerBool = false;
            ArchiefKamerButton.SetActive(true);
        }
   /*     if (GameObject.Find("Toren")&&TorenBool)
        {
        
        }
   */


    }
}
