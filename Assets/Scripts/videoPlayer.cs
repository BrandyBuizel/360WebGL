using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class videoPlayer : MonoBehaviour {

	private VideoPlayer myVideo;

	void Awake(){
		myVideo = GetComponent<VideoPlayer>();
	}

	// Use this for initialization
	void Start () {
		myVideo.Pause();
		Invoke("playVideo", 1f);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void playVideo(){
		myVideo.Play();
	}
}
