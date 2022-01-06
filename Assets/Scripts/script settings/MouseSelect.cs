using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseSelect : MonoBehaviour
{
    public float speed = 0.5f;
    private float x, y;
    public bool invert;
    [SerializeField, Range(1, 99)] private float maxXAngle = 85f;
    public Transform raycastHit;
    public GameObject hitObject;
    public GameObject TPmachine;
    private Camera gameCamera;
    public bool activated;
    public bool isClicked;
    public bool inPuzzle = false;
    public bool isLerping = false;
    public bool isAnimating = false;

    // Start is called before the first frame update
    void Start()
    {
        isClicked = false;
        gameCamera = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
      
        if (!isLerping)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = gameCamera.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 10000.0f))
                {
                    raycastHit = hit.transform;
                    hitObject = hit.transform.gameObject;
                    activated = true;
                    Debug.Log("hit!");
                    if (TPmachine.CompareTag("TypeMachine") && hit.transform.gameObject)
                    {
                        //roll credits Artists: Vera Hiemstra, Thijn Wolf
                        //Developers: Max Abbink, Laurens van Eijk, David Cigri
                        //Animators: Max Abbink
                        //UI/UX Developer: David Cigri
                        //Project Manager: Wouter van Kooten
                        //3d model: Vincent Poorthuis
                    }
                }
                else
                    activated = false;
                //Debug.Log(activated);
                isClicked = true;
            }
            if (isClicked == true && !inPuzzle&&!isAnimating)
            {
                if (!invert)
                {
                    x -= Input.GetAxis("Mouse Y") * speed;
                    x = Mathf.Clamp(x, -maxXAngle, maxXAngle);
                    y += Input.GetAxis("Mouse X") * speed;
                    transform.rotation = Quaternion.Euler(x, y, 0);
                }
                else if (invert)
                {
                    x += Input.GetAxis("Mouse Y") * speed;
                    x = Mathf.Clamp(x, -maxXAngle, maxXAngle);
                    y -= Input.GetAxis("Mouse X") * speed;
                    transform.rotation = Quaternion.Euler(x, y, 0);
                }
            }
            if (Input.GetMouseButtonUp(0))
                isClicked = false;
            hitObject = null;
        }
  
    }
}

