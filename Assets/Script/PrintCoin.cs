using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PrintCoin : MonoBehaviour {
	public Text text;
	// Use this for initialization
	void Start () {
		text.text = "COIN: " + PlayerPrefs.GetInt ("Coin");
		JoyStick.h = 0;
		JoyStick.v = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
