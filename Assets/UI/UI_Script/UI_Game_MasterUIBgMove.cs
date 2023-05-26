using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Game_MasterUIBgMove : MonoBehaviour {
	public GameObject MasterUIBg;
	public float Speed;
	float rx;
	void Start () {
		MasterUIBg = gameObject;
	}


	void Update () {
		BackgroundMove ();
	}

	void BackgroundMove(){
		rx=MasterUIBg.GetComponent<RawImage> ().uvRect.x;
		MasterUIBg.GetComponent<RawImage> ().uvRect = new Rect (rx+Speed, 0, 1, 1);
	}
}
