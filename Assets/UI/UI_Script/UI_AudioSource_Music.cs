using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_AudioSource_Music : MonoBehaviour {

	public AudioSource AudioSource_Music;

	// Use this for initialization
	void Start () {
		AudioSource_Music.GetComponent<AudioSource> ().volume = PlayerPrefs.GetFloat ("MusicVolume")/100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
