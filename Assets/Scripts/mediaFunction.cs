using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[RequireComponent (typeof(AudioSource))]

public class mediaFunction : MonoBehaviour {

    public VideoClip videoToPlay;
    private AudioSource audioSource;
    public GameObject player;

    private VideoPlayer videoPlayer;
    private VideoSource videoSource;

	// Use this for initialization
	void Start () {
        videoPlayer = gameObject.AddComponent<VideoPlayer>();
        audioSource = gameObject.AddComponent<AudioSource>();

        Application.runInBackground = true;
        videoPlayer.source = VideoSource.VideoClip;

        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.SetTargetAudioSource(0, audioSource);

        videoPlayer.clip = videoToPlay;

        videoPlayer.Prepare();
    }
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(this.transform.position, player.transform.position);
        if(distance < 3.0f && videoPlayer.isPrepared)
        {
            videoPlayer.Play();
            audioSource.Play();
            print(audioSource.name);
            print(audioSource.clip.name);
        }
        if(distance > 3.0f)
        {
            videoPlayer.Pause();
            audioSource.Pause();
        }
	}
}
