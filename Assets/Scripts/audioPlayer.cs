using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audioPlayer : MonoBehaviour {

	private AudioSource myAudio;

	void Awake(){
		myAudio = GetComponent<AudioSource>();
	}

	// Use this for initialization
	void Start () {
		Invoke("playAudio", 1f);
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void playAudio(){
		myAudio.Play();
	}
}
