using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogboekTracker : MonoBehaviour
{
    public GameObject currentPage;
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;
    public GameObject page5;
    public GameObject page6;
    public GameObject page7;
    public GameObject page8;
    public GameObject page9;
    public GameObject page10;
    public GameObject pageTtrl;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void setActivePage1() {
        currentPage = page1;
            }
    public void setActivePage2()
    {
        currentPage = page2;
    }
    public void setActivePage3()
    {
        currentPage = page3;
    }
    public void setActivePage4()
    {
        currentPage = page4;
    }
    public void setActivePage5()
    {
        currentPage = page5;
    }
    public void setActivePage6()
    {
        currentPage = page6;
    }
    public void setActivePage7()
    {
        currentPage = page7;
    }
    public void setActivePage8()
    {
        currentPage = page8;
    }
    public void setActivePage9()
    {
        currentPage = page9;
    }
    public void setActivePage10()
    {
        currentPage = page10;
    }
    public void setActivePageTtrl()
    {
        currentPage = pageTtrl;
    }
    // Update is called once per frame
    void Update()
    {
        if (currentPage == null)
            currentPage = pageTtrl;
    }
}
