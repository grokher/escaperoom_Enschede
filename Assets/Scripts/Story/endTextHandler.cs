using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class endTextHandler : MonoBehaviour
{
    public float Timer;
    public bool doanim = false;
    private bool hasAnimFinisished = false;
    public GameObject panel;
    public TextMeshProUGUI bodeTxt;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
        bodeTxt.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= 1 * Time.deltaTime;
        if (doanim)
        {
            doanim = true;
            Debug.Log("hij werkt");
            StartCoroutine(gesprek());
           
        }
    }
    IEnumerator gesprek()
    {

        if (Timer <= 0&&!hasAnimFinisished)
        {
            panel.SetActive(true);
            hasAnimFinisished = true;
            bodeTxt.text = "Bode: Hey wakker worden!";
            yield return new WaitForSeconds(3f);
            bodeTxt.text = "Jij: Nee nee . . . Maar ik heb net alle ramen weer terug gevonden en het verhaal van Enschede verteld";
            yield return new WaitForSeconds(5f);
            bodeTxt.text = "Jij: Heb ik nou echt dat allemaal gedroomd";
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("Credits");
        }
    }
}
