using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class unPoweredBehaviour : MonoBehaviour
{
    unpoweredStat unpoweredWireS;
    wireHandler handler;

    // Start is called before the first frame update
    void Start()
    {
        unpoweredWireS = GetComponent<unpoweredStat>();
       
    }

    // Update is called once per frame
    void Update()
    {
        ManageLight();
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<statestiek>())
        {
            handler = other.GetComponent<Behaviour>().GameCam.GetComponent<wireHandler>();
            statestiek poweredWireS = other.GetComponent<statestiek>();
            if (poweredWireS.objectColor == unpoweredWireS.objectColor)
            {
              
                poweredWireS.connected = true;
                unpoweredWireS.connected = true;
                poweredWireS.connectedPosition = this.transform.position;
                handler.counter1++;
                handler.counter2++;


            }
        }   
    }
     void OnTriggerExit(Collider other)
    {
        if( other.GetComponent<statestiek>())
                {

            statestiek poweredWireS = other.GetComponent<statestiek>();
            if (poweredWireS.objectColor != unpoweredWireS.objectColor)
            {
                poweredWireS.connected = false;
                unpoweredWireS.connected = false;
            }
        }
    }
    void ManageLight()
    {
        if (unpoweredWireS.connected)
        {
           // unpoweredWireS.poweredLight.SetActive(true);
          //  unpoweredWireS.unpoweredLight.SetActive(false);
        }
        else
        {
          //  unpoweredWireS.poweredLight.SetActive(false);
         //   unpoweredWireS.unpoweredLight.SetActive(true);
        }
    }
}
