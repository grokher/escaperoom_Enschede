using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedArrow : MonoBehaviour
{
    [SerializeField] private MouseSelect select;
    public GameObject unlockingArrow;
    public GameObject unlockedArrow;
    public GameObject unlockedTorenArrow;
    public GameObject Wires;
    public GameObject thisObject;

    private void Update()
    {
        if (select.hitObject == unlockingArrow)
        {
            Debug.Log(select.hitObject + "hitted");
            unlockedArrow.SetActive(true);

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
