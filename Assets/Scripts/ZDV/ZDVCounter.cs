using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZDVCounter : MonoBehaviour
{
  //  public GameObject painting;
    public GameObject message;
    public GameObject Text;
    public int Counter = 0;
    private Text counterText;
    // Start is called before the first frame update
    void Start()
    {
        message.SetActive(false);
        counterText = Text.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = Counter.ToString();
        if (Counter == 5)
        {
            message.SetActive(true);
            Counter = 0;
        }
    }
}
