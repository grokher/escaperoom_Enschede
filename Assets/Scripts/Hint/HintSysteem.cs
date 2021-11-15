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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("TrouwZaal")&&TrouwZaalBool)
        {
            TrouwZaalBool = false;
            TrouwZaalInfo.SetActive(true);
        }
        if (GameObject.Find("OudeKoffieKamer")&&koffiekamerBool)
        {
            koffiekamerBool = false;
            koffiekamerInfo.SetActive(true);
        }
        if (GameObject.Find("BurgerZaal3")&&BurgerZaalBool)
        {
            BurgerZaalBool = false;
            BurgerZaalInfo.SetActive(true);
        }
        if (GameObject.Find("Mozaiekkamer")&&MozaiekKamerBool)
        {
            MozaiekKamerBool = false;
            MozaiekKamerInfo.SetActive(true);
        }
        if (GameObject.Find("Raadzaal")&&RaadZaalBool)
        {
            RaadZaalBool = false;
            RaadZaalInfo.SetActive(true);
        }
        if (GameObject.Find("BurgermeesterKamer")&&BurgermeestersKamerBool)
        {
            BurgermeestersKamerBool = false;
            BurgermeestersKamerInfo.SetActive(true);
        }
        if (GameObject.Find("FriedHoffKamer")&&FriedHoffBool)
        {
            FriedHoffBool = false;
            FriedhoffInfo.SetActive(true);
        }
        if (GameObject.Find("machinekamer")&&MachineKamerBool)
        {
            MachineKamerBool = false;
            MachineKamerInfo.SetActive(true);
        }
        if (GameObject.Find("Archief")&&ArchiefKamerBool)
        {
            ArchiefKamerBool = false;
            ArchiefKamerInfo.SetActive(true);
        }
   /*     if (GameObject.Find("Toren")&&TorenBool)
        {
        
        }
   */
    }
}
