using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class flashScreenScript : MonoBehaviour
{
    private int SceneNumber;
    void Start()
    {
            StartCoroutine(ToMainMenu());
    }

    IEnumerator ToMainMenu()
    {
        yield return new WaitForSeconds(7.5f);
        SceneManager.LoadScene(1);
    }
}
