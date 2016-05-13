﻿using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	public static AudioManager audioManager;
	public AudioSource audioSource;

	void Awake (){
		audioManager = this;
	}

	public void PlayAudio(AudioClip soundEffect){
		audioSource.PlayOneShot (soundEffect);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
