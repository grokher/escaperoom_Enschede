using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateDial : MonoBehaviour
{
   public float angle;
    private Quaternion localQaud;
    private void Awake()
    {
        localQaud = gameObject.transform.rotation;
    }
    void OnMouseDrag()
    {
        float x = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * x, angle);
    }

}
