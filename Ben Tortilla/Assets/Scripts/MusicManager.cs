﻿using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	
	public AudioClip[] levelMusicChangeArray;
	
	private AudioSource audioSource;

	void Awake(){
		DontDestroyOnLoad(gameObject);
		Debug.Log("Don't destroy on load: " + name);
	}
	
	void Start () {
		audioSource = GetComponent<AudioSource>();
	}
	
	void OnLevelWasLoaded(int level) {
		AudioClip thisLevelMusic = levelMusicChangeArray[level];
		
		Debug.Log("Playing clip: " + thisLevelMusic);
		if (thisLevelMusic) { //if there's some music attached
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play (); 
		}
	}
}
