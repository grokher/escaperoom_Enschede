using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObject : MonoBehaviour
{
    public Transform LookAtTarget;
    void Awake()
    {
        transform.LookAt(LookAtTarget);
    }
}
