using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public MouseSelect mouse;
    public GameObject video;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if(mouse.raycastHit&&mouse.hitObject == gameObject)
        {
            video.SetActive(true);
        }
    }
}
