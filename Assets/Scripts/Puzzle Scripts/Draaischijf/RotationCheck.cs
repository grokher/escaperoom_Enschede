using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCheck : MonoBehaviour
{
    #region variables
    public GameObject turnableRing1;
    public GameObject turnableRing2, klokInfoPanel;
    public GameObject[] answerButtons;
    #endregion
    private void Awake()
    {
        klokInfoPanel.SetActive(true);
    }
    void Update()
    {
        if (turnableRing1.transform.rotation.eulerAngles.y <= 320 && turnableRing1.transform.rotation.eulerAngles.y >= 305 && turnableRing2.transform.rotation.eulerAngles.y <= 315 && turnableRing2.transform.rotation.eulerAngles.y >= 300)
        {
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
    }
}
