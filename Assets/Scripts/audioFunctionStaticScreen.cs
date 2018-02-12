using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class audioFunctionStaticScreen : MonoBehaviour {

    public AudioSource audioSource;
    public GameObject player;
    public float activationRadius;
	
	// Update is called once per frame
	void Update () {
        float distance = Vector3.Distance(this.transform.position, player.transform.position);
        if (distance < activationRadius && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
        if (distance > activationRadius && audioSource.isPlaying)
        {
            audioSource.Pause();
        }
    }
}
