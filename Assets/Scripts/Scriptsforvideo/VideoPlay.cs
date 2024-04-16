using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlay : MonoBehaviour
{
    public string VideoFilename;
    public VideoPlayer videoPlayer;

    void Start()
    {
        PlayVideo();
    }

    public void PlayVideo()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        if (videoPlayer)
        {
            string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, VideoFilename);
            videoPlayer.url = videoPath;
            videoPlayer.Prepare();
            videoPlayer.Play();
        }
    }
}
