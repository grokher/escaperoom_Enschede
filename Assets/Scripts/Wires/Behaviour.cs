using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behaviour : MonoBehaviour
{
    public statestiek powerWireStats;
    public GameMouseSelect mouse;
    public Camera GameCam;
    LineRenderer line;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<statestiek>();
        line = GetComponentInParent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveWire();
        line.SetPosition(2, new Vector3(transform.localPosition.x - .1f, transform.localPosition.y - .1f, transform.localPosition.z));
       // line.SetPosition(1, new Vector3(transform.position.x - .4f, transform.position.y - .4f, transform.position.z));
        if (!mouse.activated)
        {
            if(!powerWireStats.connected)
            gameObject.transform.position = powerWireStats.startPosition;
            if (powerWireStats.connected)
                transform.position = powerWireStats.connectedPosition;
        }
    }
    void OnMouseOver()
    {
        
        powerWireStats.movable = true;
    }
    void OnMouseExit()
    {
     
        if (!powerWireStats.moving)
            powerWireStats.movable = false;
    }
    void MoveWire()
    {
        if (mouse.activated && powerWireStats.movable&&powerWireStats.connected == false)
        {
            powerWireStats.moving = true;
            float mouseX = Input.mousePosition.x;
            float mouseY = Input.mousePosition.y;

            transform.position = GameCam.ScreenToWorldPoint(new Vector3(mouseX, mouseY, 20));
        }
        else
            powerWireStats.moving = false;

    }
}
