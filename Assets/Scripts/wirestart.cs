using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wirestart : MonoBehaviour
{

    public GameObject mouseSelect;
    public GameObject wireObject;
    bool hasHit;
    // Start is called before the first frame update
    void Start()
    {
        hasHit = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseSelect.GetComponent<MouseSelect>().hitObject.name == gameObject.name&&!hasHit)
        {
            wireObject.SetActive(true);
            mouseSelect.SetActive(false);
            hasHit = true;
            gameObject.SetActive(false);

        }
    }
}
