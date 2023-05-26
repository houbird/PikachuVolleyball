using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_MainUI_OptionControl : MonoBehaviour {
	public GameObject UI_MainUI_Option;
	public GameObject Music;
	public GameObject Effect;
	public Slider MusicSlider;
	public Slider EffectSoundSlider;
	public AudioSource AudioSource_Music;
	public AudioSource AudioSource_Sound;

	void Start () {
		Music.GetComponent<Text> ().text = "Music - " + MusicSlider.value;
		Effect.GetComponent<Text> ().text = "EffectSound - " + EffectSoundSlider.value;
		MusicSlider.value = PlayerPrefs.GetFloat ("MusicVolume");
		EffectSoundSlider.value = PlayerPrefs.GetFloat ("EffectSoundVolume");
	}


	void Update () {
	
	}

	public void MusicSliderValueChange(){
		Music.GetComponent<Text> ().text = "Music - " + MusicSlider.value;
		AudioSource_Music.GetComponent<AudioSource> ().volume = MusicSlider.value/100;
		PlayerPrefs.SetFloat ("MusicVolume", MusicSlider.value);
	}

	public void EffectSoundSliderValueChange(){
		Effect.GetComponent<Text> ().text = "EffectSound - " + EffectSoundSlider.value;
		AudioSource_Sound.GetComponent<AudioSource> ().volume = EffectSoundSlider.value/100;
		PlayerPrefs.SetFloat ("EffectSoundVolume", EffectSoundSlider.value);
	}

	public void UI_MainUI_OptionFadeOut(){
		UI_MainUI_Option.SetActive (false);
	}
}
