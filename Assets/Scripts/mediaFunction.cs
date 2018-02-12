using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[RequireComponent (typeof(AudioSource))]

public class mediaFunction : MonoBehaviour {

    private AudioSource audioSource;
    public GameObject player;

    public VideoPlayer videoPlayer;
    private VideoSource videoSource;

	// Use this for initialization
	void Start () {

        Application.runInBackground = true;
        videoPlayer.source = VideoSource.VideoClip;

        videoPlayer.Prepare();
    }
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(this.transform.position, player.transform.position);
        if(distance < 4.0f && videoPlayer.isPrepared && !videoPlayer.isPlaying)
        {
            videoPlayer.Play();
        }
        if(distance > 4.0f && videoPlayer.isPlaying)
        {
            videoPlayer.Pause();
        }
	}
}
