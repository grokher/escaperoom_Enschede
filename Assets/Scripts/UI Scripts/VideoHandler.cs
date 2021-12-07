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
    #endregion
    void Awake()
    {
        Camera = GameObject.FindGameObjectWithTag("MainCamera");
        Camera.AddComponent<VideoPlayer>();
        videoPlayer = Camera.GetComponent<VideoPlayer>();
        if (videoPlayer.clip == null)
        {
            videoPlayer.clip = videoClip;
        }
        videoPlayer.renderMode = VideoRenderMode.CameraNearPlane;
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
    }
}
