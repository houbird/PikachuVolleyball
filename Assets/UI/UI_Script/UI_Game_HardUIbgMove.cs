using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Game_HardUIbgMove : MonoBehaviour {
	public GameObject HardUIbg;
	public float Speed;
	float ry;
	void Start () {
		HardUIbg = gameObject;
	}


	void Update () {
		BackgroundMove ();
	}

	void BackgroundMove(){
		ry=HardUIbg.GetComponent<RawImage> ().uvRect.y;
		HardUIbg.GetComponent<RawImage> ().uvRect = new Rect (0, ry+Speed, 1, 1);
	}
}
