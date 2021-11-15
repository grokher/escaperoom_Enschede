using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGameHandler : MonoBehaviour
{
    #region variables
    GameObject[] Pipes;
     int pipeCounter;
     public bool pipeGameWon;
    #endregion
    void Awake()
    {
        GameObject.Find("MainCamera").GetComponent<MouseSelect>().enabled = false;
        Pipes = GameObject.FindGameObjectsWithTag("Pipe");
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
            if (pipe.transform.rotation.z == 0f || pipe.transform.rotation.z == 360f)
            {
                pipeCounter++;
            }else if (pipe.transform.rotation.eulerAngles.z == 180f && pipe.name.Contains("Straight"))
            {
                pipeCounter++;
            } 
        }
        if (pipeCounter == Pipes.Length)
        {
            pipeGameWon = true;
            Debug.Log(pipeCounter);
            pipeCounter = 0;
            GameObject.Find("MainCamera").GetComponent<MouseSelect>().inPuzzle = false;
            GameObject.Find("PipesPanel").SetActive(false);
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseSelect>().enabled = true;
        }
        else
        {
            Debug.Log("PipeCounter: " + pipeCounter + " from the " + Pipes.Length);
            pipeCounter = 0;
        }
    }
}
