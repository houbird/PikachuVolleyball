using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_AudioSource_Sound : MonoBehaviour {

	public AudioSource AudioSource_Sound;

	// Use this for initialization
	void Start () {
		AudioSource_Sound.GetComponent<AudioSource> ().volume = PlayerPrefs.GetFloat ("EffectSoundVolume")/100;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
