using UnityEngine;

public class HintSysteem : MonoBehaviour
{
    [Header("KamerInfo")]
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
    [Header("KamerButtons")]
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
    [Header("Notifications")]
    public GameObject newBookNotification;
    public GameObject pageNotification, pageNotification1, pageNotification2, pageNotification3, pageNotification4, pageNotification5, pageNotification6;

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
 
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("TrouwZaal")&&TrouwZaalBool)
        {
            TrouwZaalBool = false;
            TrouwZaalButton.SetActive(true);
            pageNotification6.SetActive(true);
            newBookNotification.SetActive(true);
        }
        if (GameObject.Find("OudeKoffieKamer")&&koffiekamerBool)
        {
            koffiekamerBool = false;
            koffiekamerButton.SetActive(true);
            pageNotification.SetActive(true);
            newBookNotification.SetActive(true);
        }
        if (GameObject.Find("BurgerZaal3")&&BurgerZaalBool)
        {
            BurgerZaalBool = false;
            BurgerZaalButton.SetActive(true);
            pageNotification1.SetActive(true);
            newBookNotification.SetActive(true);
        }
        if (GameObject.Find("Mozaiekkamer")&&MozaiekKamerBool)
        {
            MozaiekKamerBool = false;
            MozaiekKamerButton.SetActive(true);
            pageNotification5.SetActive(true);
            newBookNotification.SetActive(true);
        }
        if (GameObject.Find("Raadzaal")&&RaadZaalBool)
        {
            RaadZaalBool = false;
            RaadZaalButton.SetActive(true);
            pageNotification4.SetActive(true);
            newBookNotification.SetActive(true);
        }
        if (GameObject.Find("BurgermeesterKamer")&&BurgermeestersKamerBool)
        {
            BurgermeestersKamerBool = false;
            BurgermeestersKamerButton.SetActive(true);
            pageNotification2.SetActive(true);
            newBookNotification.SetActive(true);
        }
        if (GameObject.Find("FriedHoffKamer")&&FriedHoffBool)
        {
            FriedHoffBool = false;
            FriedhoffButton.SetActive(true);
            pageNotification3.SetActive(true);
            newBookNotification.SetActive(true);
        }
        if (GameObject.Find("machinekamer")&&MachineKamerBool)
        {
            MachineKamerBool = false;
            MachineKamerButton.SetActive(true);
            pageNotification.SetActive(true);
            newBookNotification.SetActive(true);
        }
        if (GameObject.Find("Archief")&&ArchiefKamerBool)
        {
            ArchiefKamerBool = false;
            ArchiefKamerButton.SetActive(true);
            pageNotification.SetActive(true);
            newBookNotification.SetActive(true);
        }
   /*     if (GameObject.Find("Toren")&&TorenBool)
        {
        
        }
   */


    }

    public void TurnOffPageNotifications()
    {
        if (pageNotification)
        {
            pageNotification.SetActive(false);
        }
        if (pageNotification1)
        {
            pageNotification1.SetActive(false);
        }
        if (pageNotification2)
        {
            pageNotification2.SetActive(false);
        }
        if (pageNotification3)
        {
            pageNotification3.SetActive(false);
        }
        if (pageNotification4)
        {
            pageNotification4.SetActive(false);
        }
        if (pageNotification5)
        {
            pageNotification5.SetActive(false);
        }
        if (pageNotification6)
        {
            pageNotification6.SetActive(false);
            
        }
    }

    public void TurnOffNotifications()
    {
            newBookNotification.SetActive(false);
    }
}
