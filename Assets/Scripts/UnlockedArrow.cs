using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedArrow : MonoBehaviour
{
    [SerializeField] private MouseSelect select;
    public GameObject burgerZaalSlot;
    public GameObject unlockingArrow;
    public GameObject unlockedArrow;
    public GameObject unlockedTorenArrow;
    public GameObject swapObject;
    public GameObject Wires;
    public GameObject thisObject;
    public SaveToFile saveScript;

    private void Update()
    {
        if (select.hitObject == unlockingArrow)
        {
            Debug.Log(select.hitObject + "hitted");
            unlockedArrow.SetActive(true);
            burgerZaalSlot.SetActive(false);
            saveScript.Save(gameObject);
            swapObject.SetActive(false);
            //text saying you unlocked a new acces way to walk around
            //thisObject.GetComponent<UnlockedArrow>().enabled = false;
        }
        WiresUnlock();
    }
    public void WiresUnlock()
    {
        if(Wires.GetComponent<wireHandler>().winCounter >= 3)
        {
            unlockedTorenArrow.SetActive(true);
        }

    }
}
