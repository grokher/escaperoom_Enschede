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
