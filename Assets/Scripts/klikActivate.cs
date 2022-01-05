using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class klikActivate : MonoBehaviour
{
    // Start is called before the first frame update
    protected Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }




    public void Activate()
    {
        anim.Play("beginFade");
    }
    // Update is called once per frame
    void Update()
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("done"))
            gameObject.SetActive(false);
    }
}
