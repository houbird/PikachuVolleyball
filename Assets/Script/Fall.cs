using UnityEngine;
using System.Collections;

public class Fall : MonoBehaviour {

	public static Vector3 FallPos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider){
		if (collider.tag == "Ball") {
			FallPos = collider.transform.position;
			GameManager.gamestart = false;
		}
	}
}
