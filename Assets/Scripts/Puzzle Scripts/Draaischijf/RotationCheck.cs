using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCheck : MonoBehaviour
{

    public GameObject turnableRing1;
    public GameObject turnableRing2;
    public GameObject[] answerButtons;
    void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("ring2 Y " + turnableRing2.transform.rotation.eulerAngles.y);
        if (turnableRing1.transform.rotation.eulerAngles.y <= 320 && turnableRing1.transform.rotation.eulerAngles.y >= 305 && turnableRing2.transform.rotation.eulerAngles.y <= 315 && turnableRing2.transform.rotation.eulerAngles.y >= 300)
        {
            Debug.Log(" rings are correct");
            foreach(GameObject button in answerButtons)
            {
                button.gameObject.SetActive(true);
            }
        }else if (answerButtons[0].activeSelf)
        {
            foreach (GameObject button in answerButtons)
            {
                button.gameObject.SetActive(false);
            }
        }
        // turnable ring2 y == -27f
    }
}
