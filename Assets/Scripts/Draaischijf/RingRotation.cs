using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingRotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        gameObject.GetComponent<Transform>().rotation = new Quaternion(0f, 0f, 110f ,0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
