using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burgerzaalForceClearArrow : MonoBehaviour
{
    public GameObject eventSys;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (eventSys.GetComponent<SaveToFile>().burgerZaalCleared == 1)
            gameObject.SetActive(false);
    }
}
