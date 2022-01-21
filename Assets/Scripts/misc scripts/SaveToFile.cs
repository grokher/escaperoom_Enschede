using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveToFile : MonoBehaviour
{
    #region variables
    public GameObject collegeKamer, sleutelgatHal, naar5deurhall, zDTPuzzleActivater, pipesActivater, steamOrigin, steamOrigin2, pipePuzzleHallArrow, draaischijfActivater,
        burocratiusArrow, burocratiusFakeArrow, burocratiusActivater, cypherActivater, wiresActivator, liftArrow, liftFakeArrow, mozaiekArrow, raamTorenFoto, raamArchiefFoto, raamTrouwzaalFoto, raadzaalText;
    int tutorial, zDT, pipes, cypher, wires, burocratius, draaischijf, mozaiek, raamToren, raamArchief, raamTrouwzaal;
    int tutorialkey, torenKey, ramenCounter;
    public int burgerZaalCleared;
    #endregion

    private void Awake()
    {
        LoadSave();
    }
    public void Save(GameObject ActivePuzzel)
    {
        PlayerPrefs.SetInt(ActivePuzzel.name, 1);
        Debug.Log("saved: " + ActivePuzzel.name + " " + PlayerPrefs.GetInt(ActivePuzzel.name));
    }
    public void LoadSave()
    {
        tutorial = PlayerPrefs.GetInt("[Hall buiten koffiekamer] Arrow");
        burgerZaalCleared = PlayerPrefs.GetInt("[Burgerzaal 3] arrow");
        zDT = PlayerPrefs.GetInt("EventSystemZDV");
        pipes = PlayerPrefs.GetInt("3D PipesPuzzle 1");
        cypher = PlayerPrefs.GetInt("Moveable panel/text");
        wires = PlayerPrefs.GetInt("GamecamWires");
        burocratius = PlayerPrefs.GetInt("buro puzzel 3D");
        draaischijf = PlayerPrefs.GetInt("DraaischijfPuzzle");
        //mozaiek = PlayerPrefs.GetInt("");
        tutorialkey = PlayerPrefs.GetInt("Tutorial_First Room");
        torenKey = PlayerPrefs.GetInt("Key 1");
        raamArchief = PlayerPrefs.GetInt("IMG_20210921_151225");
        raamToren = PlayerPrefs.GetInt("IMG_20210921_151158");
        raamTrouwzaal = PlayerPrefs.GetInt("IMG_20210921_151132 1");
        Debug.Log("Read: Tutorial = " + tutorial);
        Debug.Log("Read: TutorialKey = " + tutorialkey);
        Debug.Log("Read: Burgerzaal = " + burgerZaalCleared);
        Debug.Log("Read: zDT = " + zDT);
        Debug.Log("Read: Draaischijf = " + draaischijf);


        MakeChanges();
        
        Debug.Log("Read: ramen = " + ramenCounter);
    }
    public void MakeChanges()
    {
        ramenCounter = 0;
        if(torenKey == 1)
        {
            mozaiekArrow.GetComponent<OnRaycastHit>().enabled = true;
        }
        if (tutorial == 1)
        {
            GameObject.Find("Tutorial_First Room").SetActive(false);
            collegeKamer.SetActive(true);
        }
        if(burgerZaalCleared == 1)
        {
            sleutelgatHal.GetComponent<burgerzaalForceClearArrow>().burgerzaalDone = true;
            sleutelgatHal.SetActive(false);
            naar5deurhall.SetActive(true);
        }
        if (zDT == 1)
        {
            zDTPuzzleActivater.SetActive(false);
            raadzaalText.SetActive(false);
            ramenCounter += 1; 
            PlayerPrefs.SetInt("raamCount",ramenCounter);
        }
        if (pipes == 1)
        {
            pipesActivater.SetActive(false);
            steamOrigin.SetActive(false);
            steamOrigin2.SetActive(false);
            pipePuzzleHallArrow.SetActive(true);
        }
        if (draaischijf == 1)
        {
            draaischijfActivater.SetActive(false);
            ramenCounter += 1;
            PlayerPrefs.SetInt("raamCount", ramenCounter);
        }
        if(burocratius  == 1)
        {
            burocratiusActivater.SetActive(false);
            burocratiusFakeArrow.SetActive(false);
            burocratiusArrow.SetActive(true);
        }
        if(cypher == 1)
        {
            cypherActivater.SetActive(false);
            ramenCounter += 1;
            PlayerPrefs.SetInt("raamCount", ramenCounter);
        }
        if (wires == 1)
        {
            wiresActivator.SetActive(false);
            liftFakeArrow.SetActive(false);
            liftArrow.SetActive(true);
        }
        if (raamTrouwzaal == 1)
        {
            raamTrouwzaalFoto.SetActive(false);
            ramenCounter += 1;
            PlayerPrefs.SetInt("raamCount", ramenCounter);
        }
        if (raamArchief == 1)
        {
            raamArchiefFoto.SetActive(false);
            ramenCounter += 1;
            PlayerPrefs.SetInt("raamCount", ramenCounter);
        }
        if (raamToren == 1)
        {
            raamTorenFoto.SetActive(false);
            ramenCounter += 1;
            PlayerPrefs.SetInt("raamCount", ramenCounter);
        }
        ramenCounter = PlayerPrefs.GetInt("raamCount");
        if (ramenCounter != 0)
        {
            gameObject.GetComponent<raamScript>().raamCount = PlayerPrefs.GetInt("raamCount");
            gameObject.GetComponent<raamScript>().UpdateText();
        }
        
    }
}
