using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_GameNormalMusic : MonoBehaviour {
	public AudioSource NormalMusicAudioSource;
	public AudioClip NormalSunGlassesMusic;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SunGlassesMusicDown(){
		NormalMusicAudioSource.GetComponent<AudioSource> ().clip = NormalSunGlassesMusic;
		NormalMusicAudioSource.GetComponent<AudioSource> ().Play ();
	}
}
