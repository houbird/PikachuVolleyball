using UnityEngine;
using System.Collections;

public class BallSkinController : MonoBehaviour {

	public GameObject[] BallSkin;
	public static GameObject Ball;
	void Awake(){
		for (int i = 1; i <= 10; i++) {
			if (PlayerPrefs.HasKey ("v" + i + "e") == false) {
				PlayerPrefs.SetInt ("v" + i + "e", 0);
				print ("RESET");
			}
		}
		setActiveofAllSkin ();
		for (int i = 1; i <= 10; i++) {
			if (PlayerPrefs.GetInt ("v" + i + "e") == 1) {
				Ball=Instantiate (BallSkin [i - 1], transform.position, transform.rotation)as GameObject;
				Ball.SetActive (true);
			}
		}
	}

	// Update is called once per frame
	void Update () {

	}

	void setActiveofAllSkin(){
		for (int i = 0; i < BallSkin.Length; i++) {
			BallSkin [i].SetActive (false);
		}
	}
}
