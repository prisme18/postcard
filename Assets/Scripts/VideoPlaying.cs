using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlaying : MonoBehaviour
{
    public VideoPlayer vidPly;

    public void Init()
    {
        ToEndVideo();
    }
    // Start is called before the first frame update
    void Start()
    {
        Hide();
    }

    public void PlayVideo() 
    {
        Show();
        vidPly.Play();
    
    }
    void ToEndVideo() 
    {
        vidPly.loopPointReached += EndWithVideoPlay;
    }
    void EndWithVideoPlay(VideoPlayer thsiPlayer) 
    {
        Debug.Log("This is the end of Video.");
        //StopPlay();
        Hide();
    }


    public void Show() 
    {
        this.gameObject.SetActive(true);
    }
    public void Hide() 
    {
        this.gameObject.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
