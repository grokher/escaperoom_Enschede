using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoHandler : MonoBehaviour
{
    #region variables
    GameObject Camera;
    VideoPlayer videoPlayer;
    public VideoClip videoClip;
    public skyboxRotation nextLevel;
    #endregion
    void Awake()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        Camera.AddComponent<VideoPlayer>();
        videoPlayer = Camera.GetComponent<VideoPlayer>();
        Camera.GetComponent<MouseSelect>().enabled = false;
        if (videoPlayer.clip == null)
        {
            videoPlayer.clip = videoClip;
        }
        videoPlayer.renderMode = VideoRenderMode.CameraNearPlane;
        videoPlayer.SetDirectAudioMute(0, true);
        videoPlayer.Prepare();
        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        videoPlayer.loopPointReached += EndReached;
    }

    void EndReached(VideoPlayer vp)
    {
        vp.enabled = false;
        Camera.GetComponent<MouseSelect>().enabled = true;
        nextLevel.NextAreaOnClick();
    }
}
