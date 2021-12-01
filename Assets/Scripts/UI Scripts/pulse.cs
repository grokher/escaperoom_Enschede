using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pulse : MonoBehaviour
{
    Vector3 originalButtonSize;

    int time = 0;
    public float pulseSpeed;

    private bool doesPulse = true;
    private void Awake()
    {
        originalButtonSize = this.gameObject.transform.localScale;
    }
    private void Update()
    {
        Pulsing();
    }

    void Pulsing()
    {
        if (doesPulse)
        {
            Vector3 newSize;
            float calculatation = (Mathf.Sin(time * pulseSpeed));
            if (calculatation < 0)
            {
                newSize = originalButtonSize * -calculatation / 4;
            }
            else
            {
                newSize = originalButtonSize * calculatation / 4;
            }
            this.transform.localScale = ((originalButtonSize / 4) * 3) + newSize;
            time++;
        }
    }
}
