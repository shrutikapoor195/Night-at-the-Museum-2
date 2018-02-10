using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[RequireComponent (typeof(AudioSource))]

public class mediaFunction : MonoBehaviour {

    public VideoClip videoToPlay;
    public AudioSource audioSource;
    public GameObject player;

    private VideoPlayer videoPlayer;
    private VideoSource videoSource;

	// Use this for initialization
	void Start () {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        audioSource = gameObject.AddComponent<AudioSource>();

        Application.runInBackground = true;
        videoPlayer.source = VideoSource.VideoClip;
        videoPlayer.clip = videoToPlay;
    }
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(this.transform.position, player.transform.position);
        if(distance < 3.0f)
        {
            videoPlayer.Play();
            audioSource.Play();
        }
        if(distance > 3.0f)
        {
            videoPlayer.Pause();
            audioSource.Pause();
        }
	}
}
