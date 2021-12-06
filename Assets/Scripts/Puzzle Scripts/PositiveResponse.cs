using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PositiveResponse : MonoBehaviour
{
    #region
    private GameObject mainCamera;
    public AudioSource audioSource;
    public AudioClip rewardingSound;
    #endregion
    private void Awake()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        audioSource = mainCamera.GetComponent<AudioSource>();
    }
    public void Response()
    {
        audioSource.clip = rewardingSound;
        audioSource.Play();
    }
}
