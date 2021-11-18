using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaadzaalPanel : MonoBehaviour
{
    public GameObject Panel;
    public GameObject Raadzaal;
    private bool exit = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void exitButton()
    {
        exit = true;
        Panel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Raadzaal.active&&!exit)
       Panel.SetActive(true);
        if(!Raadzaal.active)
            Panel.SetActive(false);
    }
}
