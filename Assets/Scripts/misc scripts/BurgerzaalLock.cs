using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerzaalLock : MonoBehaviour
{
    public bool tutorialComplete = false;
    public GameObject burgerzaalExitArrow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!tutorialComplete)
        {
            burgerzaalExitArrow.SetActive(false);
            Debug.Log("tutorial completed" + tutorialComplete);
        }
        if(tutorialComplete)
            burgerzaalExitArrow.SetActive(true);
    }
}
