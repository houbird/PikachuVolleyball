using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_TouchToStart : MonoBehaviour {

	public GameObject TouchToStartText;

	void Start () {
		InvokeRepeating ("ShowText", 0, 0.5f);
	}

	void ShowText(){
		if (TouchToStartText.GetComponent<Text> ().text == "") {
			TouchToStartText.GetComponent<Text> ().text = "Touch To Start";
		} else {
			TouchToStartText.GetComponent<Text> ().text = "";
		}
	}
}
