using UnityEngine;
using System.Collections;

public class SkinController : MonoBehaviour {

	public GameObject[] Skin;
	// Use this for initialization
	void Start () {
		for (int i = 1; i <= 10; i++) {
			if (PlayerPrefs.HasKey ("p" + i + "e") == false) {
				PlayerPrefs.SetInt ("p" + i + "e", 0);
				print ("RESET");
			}
		}
		setActiveofAllSkin ();
		for (int i = 1; i <= 10; i++) {
			if (PlayerPrefs.GetInt ("p" + i + "e") == 1) {
				Skin [i - 1].SetActive (true);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void setActiveofAllSkin(){
		for (int i = 0; i < Skin.Length; i++) {
			Skin [i].SetActive (false);
		}
	}
}
