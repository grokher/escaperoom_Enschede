using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CypherController : MonoBehaviour
{
    #region variables
    public TMP_InputField answerField;
    public string answer;
    public string givenanswer;
    public GameObject checkResponse;
    public bool CypherDone;
    #endregion
    public void InputAnswer()
    {
        givenanswer = answerField.GetComponentInChildren<TextMeshProUGUI>().text;
        CheckAnswer();
    }
    void CheckAnswer()
    {
        Debug.Log(" checked for answer");
        if (givenanswer.Contains("vriendelijke, moedige, eerste") || givenanswer.Contains("Vriendelijke, moedige, eerste") || givenanswer.Contains("Vriendelijke, Moedige, Eerste")
           || givenanswer.Contains("Vriendelijke,moedige,eerste") || givenanswer.Contains("Vriendelijke,Moedige,Eerste") || givenanswer.Contains("vriendelijke,moedige,eerste") || givenanswer.Contains("vriendelijke moedige eerste"))
        {
            checkResponse.GetComponent<TextMeshPro>().text = "dat is Correct!";
            CypherDone = true; // read deze bool om verder te linken met andere scripts (zoals unlock door, etc)
        }
        else
        {

        }
    }
}
