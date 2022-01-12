using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class raamScript : MonoBehaviour
{
    [Header("skybox change win")]
    public Material skyboxArea;
    public GameObject CurrentArea;
    public GameObject NextArea;
    public TextMeshProUGUI counterTxt;
    public MouseSelect mouse;
    //public winCondition win;
    public GameObject raam, raam1, raam2, raam3, raam4, raam5, raam6;
    private int raamCount = 0;
    private bool hasRaam, hasRaam1, hasRaam2, hasRaam3, hasRaam4, hasRaam5, hasRaam6;
    public TextMeshProUGUI pickUpText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(windowPickup());
        counterTxt.text = raamCount.ToString();
    }
    IEnumerator windowPickup()
    {
        if (raam.GetComponent<pickupableItems>().hasThisItem && !hasRaam)
        {
            raamCount++;
            hasRaam = true;
            pickUpText.text = "Je hebt een raam gevonden";
            yield return new WaitForSeconds(3f);
            pickUpText.text = "";
        }
        else if (raam1.GetComponent<pickupableItems>().hasThisItem && !hasRaam1)
        {
            raamCount++;
            hasRaam1 = true;
            pickUpText.text = "Je hebt een raam gevonden";
            yield return new WaitForSeconds(3f);
            pickUpText.text = "";
        }
        else if (raam2.GetComponent<pickupableItems>().hasThisItem && !hasRaam2)
        {
            raamCount++;
            hasRaam2 = true;
            pickUpText.text = "Je hebt een raam gevonden";
            yield return new WaitForSeconds(3f);
            pickUpText.text = "";
        }
        else if (raam3.GetComponent<pickupableItems>().hasThisItem && !hasRaam3)
        {
            raamCount++;
            hasRaam3 = true;
            pickUpText.text = "Je hebt een raam gevonden";
            yield return new WaitForSeconds(3f);
            pickUpText.text = "";
        }
        else if (raam4.GetComponent<pickupableItems>().hasThisItem && !hasRaam4)
        {
            raamCount++;
            hasRaam4 = true;
            pickUpText.text = "Je hebt een raam gevonden";
            yield return new WaitForSeconds(3f);
            pickUpText.text = "";
        }
        else if (raam5.GetComponent<pickupableItems>().hasThisItem && !hasRaam5)
        {
            raamCount++;
            hasRaam5 = true;
            pickUpText.text = "Je hebt een raam gevonden";
            yield return new WaitForSeconds(3f);
            pickUpText.text = "";
        }
        else if (raam6.GetComponent<pickupableItems>().hasThisItem && !hasRaam6)
        {
            raamCount++;
            hasRaam6 = true;
            pickUpText.text = "Je hebt een raam gevonden";
            yield return new WaitForSeconds(3f);
            pickUpText.text = "";
        }

        if (raamCount >= 7)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
