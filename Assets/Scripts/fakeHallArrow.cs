using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fakeHallArrow : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject text;
    public TextMesh textChange;
    int count = 0;
    // Start is called before the first frame update
    public void Update()
    {
        if (count >= 1 && mainCamera.GetComponent<MouseSelect>().activated && mainCamera.GetComponent<MouseSelect>().raycastHit.name == gameObject.name)
        {
            mainCamera.GetComponent<MouseSelect>().activated = false;
            textChange.text = "Bureaucratius blokkeert deze hal. Wat zou de \nburgermeester doen bij het beeldje naast de trap";
            
            
            //gameObject.SetActive(false);
           
        }
        else if (count <= 1 && mainCamera.GetComponent<MouseSelect>().activated && mainCamera.GetComponent<MouseSelect>().raycastHit.name == gameObject.name)
        {
            mainCamera.GetComponent<MouseSelect>().activated = false;
            text.SetActive(true);
            count += 1;
        }
        //Debug.Log(mainCamera.transform.eulerAngles);

    }
    void OnDisable()
    {
        text.SetActive(false);
    }
}
