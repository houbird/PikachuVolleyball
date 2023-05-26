using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_StoreUIBgMove : MonoBehaviour {
	public GameObject UI_StoreUIBg;
	public float Speed;
	float rx,ry;
	void Start () {
		UI_StoreUIBg = gameObject;
	}


	void Update () {
		BackgroundMove ();
	}

	void BackgroundMove(){
		rx=UI_StoreUIBg.GetComponent<RawImage> ().uvRect.x;
		ry=UI_StoreUIBg.GetComponent<RawImage> ().uvRect.y;
		UI_StoreUIBg.GetComponent<RawImage> ().uvRect = new Rect (rx+Speed, ry+Speed, 3, 3);
	}
}
