using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateFeedbackText : MonoBehaviour
{
    // Start is called before the first frame update
    public float secondsToWait = 0;
    private void Update()
    {
        StartCoroutine(Deactivate());
    }

    public IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(secondsToWait);
        gameObject.SetActive(false);
    }
}
