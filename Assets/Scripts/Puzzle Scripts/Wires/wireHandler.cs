using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wireHandler : MonoBehaviour
{

    public int counter1 = 0;
    public int counter2 = 0;
    public int winCounter = 0;
    public GameObject Wires;
    public GameObject level1;
    public GameObject level2;
    public GameObject Mouse;
    public GameObject Box;
    public GameObject wiresObj;
    public GameObject liftArrow;
    public GameObject infoWinPanel;
    // Start is called before the first frame update
    void Start()
    {
        level1.SetActive(true);
        level2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(counter1== 4)
        {
            winCounter = 1;
            counter2 = 0;
            level2.SetActive(true);
            level1.SetActive(false);
        }
        if (counter2== 6)
        {
            level2.SetActive(false);
        }
        if (counter2 == 6)
        {
            winCounter = 3;
        }
        if (winCounter == 3)
        {
            Debug.Log("WINWIRES");
            infoWinPanel.SetActive(true);
            liftArrow.SetActive(true);
            Mouse.SetActive(true);
            Box.SetActive(true);
            wiresObj.SetActive(false);
        }
 
    }
}
