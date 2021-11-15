using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePiece : MonoBehaviour
{
    public void OnClickRotate()
    {
        gameObject.transform.Rotate(0f, 0f,90f);
    }
}
