using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wireHandler : MonoBehaviour
{

    public int counter = 0;
    int winCounter = 0;
    public GameObject Wires;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(counter == 5)
        {
            counter = 0;
            winCounter++;
        }
        if(winCounter == 3)
        {
            Debug.Log("WINWIRES");
        }
 
    }
}
