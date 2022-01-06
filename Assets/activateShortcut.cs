using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateShortcut : MonoBehaviour
{
    #region variables
    public GameObject stairsUpArrow;
    #endregion
    // Start is called before the first frame update
    void Awake()
    {
        stairsUpArrow.SetActive(true);
    }
}
