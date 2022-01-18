using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideoInWebGL : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer splashScreen;
    //[SerializeField]
    //private VideoPlayer liftVideo;
    //[SerializeField]
    //private string liftVideoName;
    [SerializeField]
    private string splashScreenName;

    // Start is called before the first frame update
    void Start()
    {
        if (splashScreen.clip == null)
        {
            splashScreen.url = System.IO.Path.Combine(Application.streamingAssetsPath, splashScreenName);
        }
        splashScreen.SetDirectAudioMute(0, true);
        splashScreen.Play();
        //liftVideo.url = System.IO.Path.Combine(Application.streamingAssetsPath, liftVideoName);
    }

    public void SplashScreenPlay()
    {
        
    }

    /*public void LiftVideoPlay()
    {
        liftVideo.SetDirectAudioMute(0, true);
        liftVideo.Play();
    }*/
}
