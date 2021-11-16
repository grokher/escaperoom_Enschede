using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockedArrow : MonoBehaviour
{
    [SerializeField] private MouseSelect select;
    public GameObject unlockingArrow;
    public GameObject unlockedArrow;
    public GameObject thisScript;

    private void Update()
    {
        if (select.hitObject = unlockingArrow)
        {
            unlockedArrow.SetActive(true);

            //text saying you unlocked a new acces way to walk around
            thisScript.GetComponent<UnlockedArrow>().enabled = false;
        }
    }
}
