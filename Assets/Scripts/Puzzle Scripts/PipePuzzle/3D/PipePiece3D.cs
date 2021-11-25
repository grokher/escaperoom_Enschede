using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePiece3D : MonoBehaviour
{
    [SerializeField] GameObject Camera;
    Quaternion currentRotation;
    float currentYRotation;
    public float correctRotation, correctRotation2;
    private void Awake()
    {
        Camera = GameObject.FindGameObjectWithTag("GameCamera");
    }
    private void Update()
    {
        try
        {
            if (Camera.GetComponent<GameMouseSelect>().hitObject.name.Contains("Straight Pipe") && Camera.GetComponent<GameMouseSelect>().activated)
            {
                currentRotation = Camera.GetComponent<GameMouseSelect>().hitObject.transform.rotation;
                currentYRotation = Camera.GetComponent<GameMouseSelect>().hitObject.transform.rotation.eulerAngles.y;
                StartCoroutine(Rotate(Vector3.up, 90f, 0.3f));
                Camera.GetComponent<GameMouseSelect>().activated = false;
            }
            else if (Camera.GetComponent<GameMouseSelect>().hitObject.name.Contains("Corner Pipe") && Camera.GetComponent<GameMouseSelect>().activated)
            {
                currentRotation = Camera.GetComponent<GameMouseSelect>().hitObject.transform.rotation;
                currentYRotation = Camera.GetComponent<GameMouseSelect>().hitObject.transform.rotation.eulerAngles.y;
                StartCoroutine(Rotate(Vector3.right, 90f, 0.3f));
                Camera.GetComponent<GameMouseSelect>().activated = false;
            }
        }
        catch
        {

        }

    }
    public void OnClickRotate()
    {
        //Camera.GetComponent<MouseSelect>().hitObject.transform.Rotate(0f,0f, Mathf.Lerp(currentYRotation,currentYRotation + 90f, 1f));
        StartCoroutine(Rotate(Vector3.up, 90f, 0.3f));
        //Camera.GetComponent<MouseSelect>().hitObject.transform.localEulerAngles = new Vector3(currentRotation.x, Mathf.LerpAngle(currentYRotation, currentYRotation + 90f, turnTime), currentRotation.z);
        //transform.rotation = Quaternion.Lerp(currentRotation, currentRotation = new Quaternion ( currentRotation.x,currentRotation.y + 90f,0f,0f),Time.time * turnTime);
    }
    IEnumerator Rotate(Vector3 axis, float angle, float duration)
    {
        Quaternion from = Camera.GetComponent<GameMouseSelect>().hitObject.transform.rotation;
        Quaternion to = new Quaternion(currentRotation.x, currentRotation.y, currentRotation.z, Camera.GetComponent<GameMouseSelect>().hitObject.transform.rotation.w);
        to *= Quaternion.Euler(axis * angle);

        float elapsed = 0.0f;
        bool lerping = true;
        while (lerping)
        {
            Camera.GetComponent<GameMouseSelect>().isLerping = true;
            while (elapsed < duration)
            {
                Camera.GetComponent<GameMouseSelect>().hitObject.transform.rotation = Quaternion.Slerp(from, to, elapsed / duration);
                elapsed += Time.deltaTime;
                yield return null;
            }
            Camera.GetComponent<GameMouseSelect>().hitObject.transform.rotation = to;
            lerping = false;
        }
        Camera.GetComponent<GameMouseSelect>().isLerping = false;


    }
}
