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
    private Camera gameCamera;
    public bool activated;
    public bool isClicked;
    public bool inPuzzle = false;
    public bool isLerping = false;

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
                }
                else
                    activated = false;
                Debug.Log(activated);
                isClicked = true;
            }
            if (isClicked == true && !inPuzzle)
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
        }
    }
}

