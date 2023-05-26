using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class JoyStick : MonoBehaviour {

	public Transform Stick;
	public static float h = 0;
	public static float v = 0;
	public Canvas canvas;
	private Vector3 zeroPos;
	// Use this for initialization
	void Start () {
		zeroPos = Stick.localPosition;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void OnPress(){
		StickFollow ();
		h = Stick.localPosition.x / 50;
		v = Stick.localPosition.y / 50;
	}

	public void OnDrag(){
		if (Input.touchCount == 1) {
			StickFollow ();
			h = Stick.localPosition.x / 50;
			v = Stick.localPosition.y / 50;
		}
	}

	public void DisPress(){
		Stick.localPosition = Vector3.zero;
		h = 0;
		v = 0;
	}

	void StickFollow(){
		Vector2 pos;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, Input.mousePosition, canvas.worldCamera, out pos);
		Stick.transform.position = canvas.transform.TransformPoint(pos);
		float distance = Vector2.Distance (zeroPos, Stick.localPosition);
		if (distance > 50) {
			Stick.localPosition = Stick.localPosition.normalized * 50;
		} else {
			Stick.transform.position = canvas.transform.TransformPoint(pos);
		}
	}
}
