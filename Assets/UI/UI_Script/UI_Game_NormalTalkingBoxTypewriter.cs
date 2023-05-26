using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Game_NormalTalkingBoxTypewriter : MonoBehaviour {
	public GameObject TalkingBoxText;
	public AudioClip TyperSound;
	public AudioSource AudioSource_Sound;

	string TalkSub = "You are challenged by \nNormal Mode - Rich Pikachu!";
	int SubID = 0;

	// Use this for initialization
	void Start () {
		StartCoroutine (delay(2f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Print(float time){
		while(SubID < TalkSub.Length){
			TalkingBoxText.GetComponent<Text> ().text += TalkSub[SubID];
			SubID++;
			AudioSource_Sound.GetComponent<AudioSource> ().PlayOneShot(TyperSound);
			yield return new WaitForSeconds (time);
		}
	}

	private IEnumerator delay(float time)
	{
		yield return new WaitForSeconds(time);
		StartCoroutine (Print (0.075f));
	}
}
