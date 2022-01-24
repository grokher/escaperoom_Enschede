using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndCredits : MonoBehaviour
{
    private Animator Animator;

    public GameObject credits;
    private void Start()
    {
        Animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        endCredits();
    }
  
    public void endCredits()
    {
        if (Animator.GetCurrentAnimatorStateInfo(0).IsName("almost ending"))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            if (currentScene.name == "Credits")
                SceneManager.LoadScene("MainMenu");
            else credits.SetActive(false);
        }
    }

}
