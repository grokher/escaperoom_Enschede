using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EndCredits : MonoBehaviour
{
    private Animator Animator;

    public GameObject credits;
    private void Start()
    {
        Animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        endCredits();
    }

    public void endCredits()
    {
        if(Animator.GetCurrentAnimatorStateInfo(0).IsName("almost ending"))
        credits.SetActive(false);
    }

}
