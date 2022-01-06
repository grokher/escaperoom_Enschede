using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGameHandler3D : MonoBehaviour
{
    #region variables
    GameObject[] Pipes;
    public GameObject MainCamera;
    public GameObject BlockedArrow;
    public GameObject SteamEmitter, SteamEmitter1;
    int pipeCounter;
    public bool pipeGameWon;
    #endregion
    void Awake()
    {
        Pipes = GameObject.FindGameObjectsWithTag("Pipe");
       // GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseSelect>().inPuzzle = true;
        //GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = false;
        pipeCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        CheckForWin();
    }
    void CheckForWin()
    {
        foreach (GameObject pipe in Pipes)
        {
            if (pipe.transform.localEulerAngles.y == pipe.GetComponent<PipePiece3D>().correctRotation || pipe.transform.localEulerAngles.y == 360f)
            {
                pipeCounter++;
                
            }
            else if (pipe.transform.localEulerAngles.y == pipe.GetComponent<PipePiece3D>().correctRotation2 && pipe.name.Contains("Straight"))
            {
                pipeCounter++;

            }

        }
        if (pipeCounter == Pipes.Length)
        {
            pipeGameWon = true;
            Debug.Log("All pipes are Correct");
            MainCamera.SetActive(true);
            MainCamera.GetComponent<MouseSelect>().inPuzzle = false;
            MainCamera.GetComponent<MouseSelect>().inPuzzle = true;
            BlockedArrow.SetActive(true);
            SteamEmitter.SetActive(false);
            SteamEmitter1.SetActive(false);
            // GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseSelect>().inPuzzle = false;
            // GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>().enabled = true;
            gameObject.SetActive(false);
            pipeCounter = 0;
        }
        else
        {
            //Debug.Log("PipeCounter: " + pipeCounter + " from the " + Pipes.Length);
            pipeCounter = 0;
        }
    }
}
