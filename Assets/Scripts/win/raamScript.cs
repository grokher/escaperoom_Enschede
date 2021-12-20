using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raamScript : MonoBehaviour
{
    public MouseSelect mouse;
    public winCondition win;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mouse.activated && mouse.hitObject == gameObject)
        {

        }
           // win.winCounter++;
    }
}
