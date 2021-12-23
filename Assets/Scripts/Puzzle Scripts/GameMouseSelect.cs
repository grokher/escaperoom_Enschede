using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMouseSelect : MonoBehaviour
{
    public Camera GameCamera;
    public bool isLerping;
    RaycastHit hit;
    public GameObject hitObject;
    Ray ray;
    public bool activated;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isLerping)
        {
            if (Input.GetMouseButtonDown(0))
            {
                ray = GameCamera.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 10000.0f))
                {
                    hitObject = hit.transform.gameObject;
                    activated = true;
                    Debug.Log("hit!");
                }
                else
                    hitObject = null;
                
                    
                Debug.Log(activated);
            }
        }
    }
}